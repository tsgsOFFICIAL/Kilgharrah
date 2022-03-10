﻿using API.Models;
using Npgsql;
using System.Reflection;

namespace API.DAL
{
    /// <summary>
    /// Class for managing the DataBase.
    /// </summary>
    public class DBManager
    {
        private NpgsqlConnection Connection;
        private readonly string _connectionString = "Host=10.108.149.7;Username=postgres;Password=Code1234@;Database=Kilgharrah";
        public DBManager()
        {
            Connection = new NpgsqlConnection(_connectionString);
            Connection.Open();

            //string sql = "SELECT version()";
            //NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
            //string outPut = cmd.ExecuteScalar().ToString();

        }
        /// <summary>
        /// Method for getting all planets and all the information.
        /// </summary>
        /// <returns></returns>
        public List<Planet> GetPlanets()
        {
            List<Planet> planets = new List<Planet>();
            string sql = "SELECT * FROM planets";



            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection)) // "Using" automatically disposes of objects after use.
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Planet planet = new Planet();
                        int i = 0;

                        // This loop gets all the properties from the DataBase and sets them to the object.
                        foreach (PropertyInfo property in planet.GetType().GetProperties().Where(PropInfo => !PropInfo.GetGetMethod().GetParameters().Any()))
                        {
                            property.SetValue(planet, reader.GetValue(i++));
                            //Console.WriteLine($"{p.Name}: \"{p.GetValue(planet, null)}\"");
                        }

                        planets.Add(planet);
                    }

                    return planets;
                }
            }
        }
        /// <summary>
        /// Gets a single Planet Object from an ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>This method returns a planet.</returns>
        public Planet GetPlanet(int id)
        {
            string sql = $"SELECT * FROM Planets WHERE id = '{id}'";
            Planet planet = new Planet();

            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int i = 0;

                        foreach (PropertyInfo property in planet.GetType().GetProperties().Where(PropInfo => !PropInfo.GetGetMethod().GetParameters().Any()))
                        {
                            property.SetValue(planet, reader.GetValue(i++));
                        }

                    }
                }
            }

            return planet;
        }
    }
}
