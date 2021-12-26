using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrnekPro.Data;
using OrnekPro.Entity;
using OrnekPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;
        public MoviesController(MovieContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult List(int ?id,string q)  
        {

            //var movies = MovieRepository.Movies;
            var movies = _context.Movies.AsQueryable();
            if(id != null)
            {
                movies = movies.Where(m => m.TurId==id);
            }
            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => 
                i.Title.ToLower().Contains(q.ToLower())||
                i.Description.ToLower().Contains(q.ToLower()));
            }

            var model = new MoviesViewModel()
            {
                Movie = movies.ToList()
               

            };
                
            return View("Movies",model);
        }
        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }
       
        public IActionResult Edit(int id)
        {
            ViewBag.Turler = new SelectList (TurRepository.Turler,"TurId","Name");
            return View(_context.Movies.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                //  MovieRepository.Edit(m);
                _context.Movies.Update(m);
                _context.SaveChanges();
                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
            }
            ViewBag.Turler = new SelectList(_context.Turler, "TurId", "Name");
            return View(m);
        }
        public IActionResult Create()
        {
            ViewBag.Turler = new SelectList(_context.Turler, "TurId", "Name");
            return View();

        }
        

      
        [HttpPost]
       
        
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
               
                _context.Movies.Add(m);
                _context.SaveChanges();
               
                return RedirectToAction("List");
            }
            ViewBag.Turler = new SelectList(TurRepository.Turler, "TurId", "Name");
            return View();
        
        }
        [HttpPost]
        public IActionResult Delete(int MovieId)
        {
            var thing = _context.Movies.Find(MovieId);
            _context.Movies.Remove(thing);
            _context.SaveChanges();
            return RedirectToAction("List");
        }


    }
}
