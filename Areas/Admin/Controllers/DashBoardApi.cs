using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Data;
using project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "CanManageMovie")]
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardApi : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DashBoardApi(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public IActionResult GetMovies()
        {
            var movie = _context.Movies.ToList();
            return Ok(movie);
        }

        [Route("api/[controller]/Add")]
        public IActionResult Add()
        {
            return Ok();
        }

        [HttpPost, ActionName("Add")]
        public IActionResult Added(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    movie.Banner = p1;
                }
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return Ok(movie);
        }

        [Route("api/[controller]/{id}")]
        public IActionResult Movie(int? id, Movie cat)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = _context.Movies.FindAsync(id);
            return Ok(movie);
        }

        [Route("api/[controller]/Edit/{id}")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = _context.Movies.FindAsync(id);
            return Ok(movie);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Movie mov)
        {
            
            var movieFromDb =  _context.Movies.Where(c => c.Id == mov.Id).FirstOrDefault();
            if (movieFromDb == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    movieFromDb.Banner = p1;
                }
                movieFromDb.Name = mov.Name;
                movieFromDb.About = mov.About;
                movieFromDb.Category = mov.Category;
                movieFromDb.Director = mov.Director;
                movieFromDb.Actors = mov.Actors;
                movieFromDb.Producer = mov.Producer;
                movieFromDb.WatchTime = mov.WatchTime;
                movieFromDb.Release = mov.Release;
                movieFromDb.Ratings = mov.Ratings;
                movieFromDb.MovieLink = mov.MovieLink;

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return Ok(mov);
        }

        [HttpDelete]
        public IActionResult Delete(Movie mov)
        {
            var movieFromDb = _context.Movies.Where(c => c.Id == mov.Id).FirstOrDefault();
            if (movieFromDb == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(mov);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
