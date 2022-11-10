using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyXFamily.Models;

namespace SpyXFamily.Controllers
{    
    public class DetailController : Controller
    {
        public IActionResult Index(string id, string pageType)
        {
            var characters = new List<CharacterModel>()
            {
                new CharacterModel()
                {
                    Id = "loid",
                    Name = "Loid Forger",
                    Description = @"Loid Forger (ロイド・フォージャー, Roido Fōjā?) is the main protagonist of the SPY x FAMILY series. He had discarded everything about his past to work for his country as an undercover spy who acts under the codename ""Twilight"""
                },
                new CharacterModel()
                {
                    Id = "yor",
                    Name = "Yor Forger",
                    Description = @"Yor Forger (ヨル・フォージャー, Yoru Fōjā?), née Briar (ブライア, Buraia?) is the tritagonist of the SPY x FAMILY series. While she works as an ordinary clerk at Berlint City Hall, she also leads a secret life as a Garden assassin with the code name ""Thorn Princess""",
                },
                new CharacterModel()
                {
                    Id = "anya",
                    Name = "Anya Forger",
                    Description = @"Anya Forger (アーニャ・フォージャー, Ānya Fōjā?) is the deuteragonist of the SPY x FAMILY series. Formerly known as Test Subject ""007"" (被験体""007"", Hikentai ""007""?), she is a telepath whose abilities were created in an experiment conducted by an unknown organization."
                }
            };

            var detail = characters.FirstOrDefault(c => c.Id == id);
            ViewBag.PageType = pageType;

            return View(detail);
        }
    }
}
