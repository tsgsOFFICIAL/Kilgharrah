using System.Text.Json;
using WWW.Models;

namespace WWW.DAL
{
    public class APIManager
    {
        HttpClient client = new HttpClient();

        public async Task<List<Planet>> GetPlanets()
        {
            string json = await client.GetStringAsync("10.108.149.14/api/planets/");
            
            List<Planet>? planets = JsonSerializer.Deserialize<List<Planet>>(json);

            return planets ?? new List<Planet>();
        }
    }
}
