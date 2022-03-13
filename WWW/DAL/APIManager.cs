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
        public async Task<List<PlanetModel>> GetPlanets()
        {
            string json = await _client.GetStringAsync($"{_client.BaseAddress}/planets");
            
            List<PlanetModel>? planets = JsonSerializer.Deserialize<List<PlanetModel>>(json);

            return planets ?? new List<PlanetModel>();
        }
        /// <summary>
        /// Get a list of all translations, in all languages available
        /// </summary>
        /// <returns>This method returns a list of TranslationText</returns>
        public async Task<List<TranslationTextModel>> GetTranslation()
        {
            string json = await _client.GetStringAsync($"{_client.BaseAddress}/translations");

            List<TranslationTextModel>? text = JsonSerializer.Deserialize<List<TranslationTextModel>>(json);

            return text ?? new List<TranslationTextModel>();
        }
    }
}
