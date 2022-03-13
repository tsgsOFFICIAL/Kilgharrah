namespace API.Models
{
    public class PlanetModel_Obsolete
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
        /// <summary>
        /// Creates a new instance of the class Planet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="translation_id"></param>
        /// <param name="distance_from_sun"></param>
        /// <param name="diameter"></param>
        /// <param name="rotation_period"></param>
        /// <param name="orbital_period"></param>
        /// <param name="has_life"></param>
        //public Planet(int id, int translation_id, int distance_from_sun, int diameter, double rotation_period, double orbital_period, bool has_life)
        //{
        //    this.id = id;
        //    this.translation_id = translation_id;
        //    this.distance_from_sun = distance_from_sun;
        //    this.diameter = diameter;
        //    this.rotation_period = rotation_period;
        //    this.orbital_period = orbital_period;
        //    this.has_life = has_life;
        //}
    }
}
