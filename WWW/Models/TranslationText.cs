namespace WWW.DAL
{
    public class TranslationText
    {
        /// <summary>
        /// The id from the database
        /// </summary>
        public int id { get; private set; }
        /// <summary>
        /// The text in danish
        /// </summary>
        public string da { get; private set; }
        /// <summary>
        /// The text in english
        /// </summary>
        public string en { get; private set; }
        /// <summary>
        /// The text in hungarian
        /// </summary>
        public string hu { get; private set; }
    }
}