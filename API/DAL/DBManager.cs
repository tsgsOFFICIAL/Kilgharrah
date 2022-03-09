using Npgsql;
namespace API.DAL
{
    public class DBManager
    {
        private readonly string _connectionString = "Host=10.108.149.7;Username=postgres;Password=Code1234@;Database=Kilgharrah";
        public DBManager()
        {
            NpgsqlConnection Connection = new NpgsqlConnection(_connectionString);
            Connection.Open();

            string sql = "SELECT version()";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Connection);
            string outPut = cmd.ExecuteScalar().ToString();
            
        }
    }
}
