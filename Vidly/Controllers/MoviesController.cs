using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreck" };
            //return View(movie);
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("ID=" + id);
        }

    }
}