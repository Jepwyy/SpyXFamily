using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyXFamily.Models;
namespace SpyXFamily.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            var videos = new List<VideoModel>()
            {
                new VideoModel()
                {
                    Id = "loid",
                    Name = "Loid Forger",
                    Description = @"Loid Forger, codenamed Twilight, is the titular main protagonist of the 2019 comedy spy manga series Spy × Family and its anime adaptation.",
                    VideoURL = "https://www.youtube.com/embed/PfGBtGaXnGc"
                },
                new VideoModel()
                {
                    Id = "yor",
                    Name = "Yor Forger",
                    Description = @"Yor Forger is the tritagonist of the Japanese anime and manga series Spy × Family. She is a 27-year-old assassin who is pretending to be married to Loid Forger and pretending to be the mother of Anya Forger. As an assassin working for the Garden, she is known by her code-name, the ""Thorn Princess"".",
                    VideoURL = "https://youtube.com/embed/bwIFDaB2kzI"
                },
                new VideoModel()
                {
                    Id = "anya",
                    Name = "Anya Forger",
                    Description = @"Anya Forger is the deuteragonist in the Japanese anime and manga series Spy X Family. She is the adoptive daughter of Loid Forger and Yor Forger, having been taking under Loid's care as part of his current mission.",
                    VideoURL = "https://youtube.com/embed/CyAWx6knxak"
                }
            };

            return View(videos);
        }
    }
}
