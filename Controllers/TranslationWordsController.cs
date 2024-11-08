using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestTranslation;
using TestTranslation.Interfaces;
using TestTranslation.Models;

namespace TestTranslation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationWordsController : Controller
    {
        private readonly ITranslationWordRepository _translationWordRepository;
        public TranslationWordsController(ITranslationWordRepository translationWordRepository)
        {
            _translationWordRepository = translationWordRepository;
        }


        [HttpGet("{English}")]
        public async Task<IActionResult> GetTranslation(string English)
        {
            if (string.IsNullOrEmpty(English))
            {
                return BadRequest("The English word parameter is required.");
            }

            var text = await _translationWordRepository.GetTranslationAsync(English);
            if (text == null)
            {
                return NotFound("Translation not found.");
            }

            return Ok(text.Hungarian);
        }
    }
}
