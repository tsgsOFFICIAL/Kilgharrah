﻿using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace WWW
{
    /// <summary>
    /// The WebSocketServer handles a connection via a websocket, a client can be used for connecting.
    /// </summary>
    public class WebSocketServer
    {
        /// <summary>
        /// The IP of the server
        /// </summary>
        public string Ip { get; private set; }
        /// <summary>
        /// The Port of the server
        /// </summary>
        public int Port { get; private set; }
        /// <summary>
        /// The TcpListener / WebSocketServer
        /// </summary>
        public TcpListener Listener { get; private set; }
        public SerialPort SerialPort { get; private set; }

        /// <summary>
        /// Creates a new instance of the WebSocketServer class
        /// </summary>
        public WebSocketServer()
        {
            Ip = "127.0.0.1";
            Port = 8008;
            Listener = new TcpListener(IPAddress.Parse(Ip), Port);
            SerialPort = new SerialPort("COM5", 9600);
        }

        /// <summary>
        /// Starts the listener
        /// </summary>
        /// <returns>This method returns a boolean value indicating the success state of the method call</returns>
        public void Open()
        {
            try
            {
                Listener.Start();
                SerialPort.Open();
                Listen();
            }
            catch (Exception)
            { }
        }
        /// <summary>
        /// Stops the listener
        /// </summary>
        /// <returns>This method returns a boolean value indicating the success state of the method call</returns>
        public bool Close(bool restart = false)
        {
            try
            {
                Listener.Stop();
                SerialPort.Close();

                if (restart)
                {
                    Open();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Runs the websocket
        /// </summary>
        private void Listen()
        {
            while (true)
            {
                TcpClient client = Listener.AcceptTcpClient();

                Console.WriteLine("A client connected.");

                NetworkStream stream = client.GetStream();

                // Enter to an infinite cycle to be able to handle every change in stream
                while (true)
                {
                    while (!stream.DataAvailable) ;
                    while (client.Available < 3) ; // match against "get"

                    byte[] bytes = new byte[client.Available];
                    stream.Read(bytes, 0, client.Available);
                    string s = Encoding.UTF8.GetString(bytes);

                    if (Regex.IsMatch(s, "^GET", RegexOptions.IgnoreCase))
                    {
                        Console.WriteLine($"\n=====Handshaking from client=====\n\n{s}");

                        // 1. Obtain the value of the "Sec-WebSocket-Key" request header without any leading or trailing whitespace
                        // 2. Concatenate it with "258EAFA5-E914-47DA-95CA-C5AB0DC85B11" (a special GUID specified by RFC 6455)
                        // 3. Compute SHA-1 and Base64 hash of the new value
                        // 4. Write the hash back as the value of "Sec-WebSocket-Accept" response header in an HTTP response
                        string swk = Regex.Match(s, "Sec-WebSocket-Key: (.*)").Groups[1].Value.Trim();
                        string swka = swk + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
                        byte[] swkaSha1 = System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(swka));
                        string swkaSha1Base64 = Convert.ToBase64String(swkaSha1);

                        // HTTP/1.1 defines the sequence CR LF as the end-of-line marker
                        byte[] response = Encoding.UTF8.GetBytes(
                            "HTTP/1.1 101 Switching Protocols\r\n" +
                            "Connection: Upgrade\r\n" +
                            "Upgrade: websocket\r\n" +
                            "Sec-WebSocket-Accept: " + swkaSha1Base64 + "\r\n\r\n");

                        stream.Write(response, 0, response.Length);
                    }
                    else
                    {
                        bool fin = (bytes[0] & 0b10000000) != 0,
                            mask = (bytes[1] & 0b10000000) != 0; // must be true, "All messages from the client to the server have this bit set"

                        int opcode = bytes[0] & 0b00001111, // expecting 1 - text message
                            msglen = bytes[1] - 128, // & 0111 1111
                            offset = 2;

                        if (msglen == 126)
                        {
                            msglen = BitConverter.ToUInt16(new byte[] { bytes[3], bytes[2] }, 0);
                            offset = 4;
                        }
                        #region unused code
                        /*
                        else if (msglen == 127)
                        {
                            Console.WriteLine("TODO: msglen == 127, needs qword to store msglen");
                        }

                        if (msglen == 0)
                        {
                            Console.WriteLine("msglen == 0");
                        }
                        */
                        #endregion

                        else if (mask)
                        {
                            byte[] decoded = new byte[msglen];
                            byte[] masks = new byte[4] { bytes[offset], bytes[offset + 1], bytes[offset + 2], bytes[offset + 3] };
                            offset += 4;

                            for (int i = 0; i < msglen; ++i)
                                decoded[i] = (byte)(bytes[offset + i] ^ masks[i % 4]);

                            string text = Encoding.UTF8.GetString(decoded);

                            switch (text)
                            {
                                case "exit":
                                    Close(true);
                                    Console.WriteLine("Connection ended, waiting for a new connection...");
                                    break;
                                case "moveUfoToMars":
                                    Console.WriteLine("Arduino");
                                    // SERIAL TIL Arduino
                                    SerialPort.Write("moveUfoToMars");
                                    break;
                                default:
                                    SerialPort.Write(text);
                                    //Console.WriteLine($"Message Recieved: \"{text}\"");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("mask bit not set");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
