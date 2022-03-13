using API.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationsController : ControllerBase
    {
        DBManager man = new DBManager();

        // GET: api/Translations
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(man.GetTranslations, new JsonSerializerOptions() { WriteIndented = true });
        }
    }
}