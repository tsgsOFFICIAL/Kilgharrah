namespace API.Models
{
    public class TranslatedPlanets
    {
        /// <summary>
        /// Id is for the DataBase Id.
        /// </summary>
        public int id { get; private set; }
        /// <summary>
        /// Lang is for setting up the language.
        /// </summary>
        public string lang { get; private set; }
        /// <summary>
        /// Name is for setting up a name.
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Description_json contains all the descriptions of all planets.
        /// </summary>
        public string description_json { get; private set; }
    }
}
