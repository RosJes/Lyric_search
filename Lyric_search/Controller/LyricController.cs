using Lyric_search.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lyric_search.LyricController
{

   
    public class LyricController : Controller
    {
        LyricService service;


        public LyricController(LyricService service) // DI
        {
            this.service = service;
        }

        
        [Route("Latest")]

        public IActionResult Latest()
        {
            var model = service.Latest_Search();
            return View(model);

        }

        [Route("Lyric")]
        [Route("")]
        public IActionResult Lyric()
        {
            var model = service.DisplayRequest();
            return View(model);
            
        }



        [Route("_Create")]
        [HttpGet]
        public IActionResult Create()
        {
            // Show empty form
            return PartialView();
        }


        [Route("_Create")]
        [HttpPost]
        public IActionResult Create(Lyric request) // Model binding
        {
            // Validate (server-side)
            if (!ModelState.IsValid)
                return PartialView(request);

            service.Create_Request(request);

            // Redirect to index
            return RedirectToAction("Lyric");
        }



    }
}
