using Npgsql;
namespace API.DAL
{
    public class DBManager
    {
        private NpgsqlConnection Connection;
        private readonly string _connectionString = "Host=10.108.149.7;Username=postgres;Password=Code1234@;Database=Kilgharrah";
        public DBManager()
        {
            Connection = new NpgsqlConnection(_connectionString);
            Connection.Open();

            string sql = "SELECT version()";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
            string outPut = cmd.ExecuteScalar().ToString();
            
        }
        public string GetPlanets()
        {
            string sql = "SELECT * FROM planets";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetValue(0)}");
                        return reader.GetValue(2).ToString();
                    }
                    return sql;
                }
            }
        }
    }
}
