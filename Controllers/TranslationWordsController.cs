using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestTranslation;
using TestTranslation.Models;

namespace TestTranslation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationWordsController : Controller
    {
        private readonly TranslationDBContext _context;

        public TranslationWordsController(TranslationDBContext context)
        {
            _context = context;
        }

        [HttpGet("{English}")]
        public async Task<IActionResult> GetTranslation(string English)
        {
            
            if (!string.IsNullOrEmpty(English))
            {
               var Text  = await _context.TranslationWord.FirstOrDefaultAsync(w => w.English.ToLower() == English.ToLower());
                if (Text == null) return NotFound("Translation not found.");
                return Ok(Text.Hungarian);
            }

            return BadRequest("Something Went Wrong");
        }
    }
}
