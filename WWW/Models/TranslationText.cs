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
        public string daText { get; private set; }
        /// <summary>
        /// The text in english
        /// </summary>
        public string enText { get; private set; }
        /// <summary>
        /// The text in hungarian
        /// </summary>
        public string huText { get; private set; }
    }
}