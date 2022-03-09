namespace API.Models
{
    public class Planet
    {
        /// <summary>
        /// Id is the Id for the DataBase.
        /// </summary>
        public int id { get; private set; }
        /// <summary>
        /// Translation_Id is the foreign key for the Id of TranslatedPlanet.
        /// </summary>
        public int translation_id { get; private set; }
        /// <summary>
        /// Distance from the sun in KM.
        /// </summary>
        public int distance_from_sun { get; private set; }
        /// <summary>
        /// Diameter of the planets in KM.
        /// </summary>
        public int diameter { get; private set; }
        /// <summary>
        /// Rotation period is for a planet's time circling around it's own axis. 
        /// </summary>
        public double rotation_period { get; private set; }
        /// <summary>
        /// Orbital period is for a planet's time circling around another object, for ex.: the Sun.
        /// </summary>
        public double orbital_period { get; private set; }
        /// <summary>
        /// "Has life" is for where humans and(or) animals do live.
        /// </summary>
        public bool has_life { get; private set; } 
        
    }
}
