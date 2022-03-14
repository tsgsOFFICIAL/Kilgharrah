﻿using API.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationsController : ControllerBase
    {
        DBManager manager = new DBManager();

        // GET: api/Translations
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(manager.GetTranslations, new JsonSerializerOptions() { WriteIndented = true });
        }
    }
}