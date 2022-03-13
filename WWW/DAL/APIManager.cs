using System.Text.Json;
using WWW.Models;

namespace WWW.DAL
{
    /// <summary>
    /// Manages the connection to the API
    /// </summary>
    public class APIManager
    {
        /// <summary>
        /// The HttpClient
        /// </summary>
        private readonly HttpClient _client = new HttpClient();
        /// <summary>
        /// Creates a new instance of the APIManager
        /// </summary>
        public APIManager()
        {
            _client.BaseAddress = new Uri("10.108.149.14/api");
        }
        /// <summary>
        /// Get a list of all planets
        /// </summary>
        /// <returns>This method a List of Planets </returns>
        public async Task<List<Planet>> GetPlanets()
        {
            string json = await _client.GetStringAsync($"{_client.BaseAddress}/planets");
            
            List<Planet>? planets = JsonSerializer.Deserialize<List<Planet>>(json);

            return planets ?? new List<Planet>();
        }
        /// <summary>
        /// Get a list of all translations, in all languages available
        /// </summary>
        /// <returns>This method returns a list of TranslationText</returns>
        public async Task<List<TranslationText>> GetTranslation()
        {
            string json = await _client.GetStringAsync($"{_client.BaseAddress}/translations");

            List<TranslationText>? text = JsonSerializer.Deserialize<List<TranslationText>>(json);

            return text ?? new List<TranslationText>();
        }
    }
}
