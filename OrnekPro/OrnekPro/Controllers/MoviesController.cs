using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrnekPro.Data;
using OrnekPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Controllers
{
    public class MoviesController : Controller
    {
      

        //localhost:5000/movies

        //localhost:5000/movies
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult List(int ?id,string q)  
        {
           // var kelime = HttpContext.Request.Query["q"].ToString();
            var movies = MovieRepository.Movies;
            if(id != null)
            {
                movies = movies.Where(m => m.TurId==id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => 
                i.Title.ToLower().Contains(q.ToLower())||
                i.Description.ToLower().Contains(q.ToLower())).ToList();
            }
           
            var model = new MoviesViewModel()
            {
                Movie = movies
               

            };
                
            return View("Movies",model);
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
       
        public IActionResult Edit(int id)
        {
            ViewBag.Turler = new SelectList (TurRepository.Turler,"TurId","Name");
            return View(MovieRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Edit(m);
                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
            }
            ViewBag.Turler = new SelectList(TurRepository.Turler, "TurId", "Name");
            return View(m);
        }
        public IActionResult Create()
        {
            ViewBag.Turler = new SelectList(TurRepository.Turler, "TurId", "Name");
            return View();

        }
        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Add(m);
                return RedirectToAction("List");
            }
            ViewBag.Turler = new SelectList(TurRepository.Turler, "TurId", "Name");
            return View();
        
        }
        [HttpPost]
        public IActionResult Delete(int MovieId)
        {
            MovieRepository.Delete(MovieId);
            return RedirectToAction("List");
        }


    }
}
