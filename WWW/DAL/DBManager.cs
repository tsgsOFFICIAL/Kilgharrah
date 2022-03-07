using WWW.Models;

namespace WWW.DAL
{
    public class DBManager
    {

        #region Fields

        private IConfiguration configuration;
        private readonly string connectionString;
        #endregion




        #region Constructors
        public DBManager(IConfiguration _configuration)
        {
            this.configuration = _configuration;
            connectionString = configuration.GetConnectionString("DBContext");

        }
        #endregion


        public List<Planet> GetPlanets()
        {
            return null;
        }
}
