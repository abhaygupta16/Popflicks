using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Areas.Users.Controllers
{
    [Area("Users")]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeControllerApi : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HomeControllerApi(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }

        [Authorize]
        [HttpGet("detail/{id:int}")]
        public IActionResult Detail(int? id)
        {
            var movie = _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            
            return Ok(movie);
        }

        [HttpGet("actionmovies")]
        //for categories
        [Route("api/[controller]/{action}")]
        public IActionResult ActionMovies()
        {
            var movies = _context.Movies.Where(c => c.Category == "0").ToList();
            return Ok(movies);
        }

        [HttpGet]
        [Route("api/[controller]/[action]")]
        public IActionResult AdventureMovies()
        {
            var movies = _context.Movies.Where(c => c.Category == "1").ToList();
            return Ok(movies);
        }

        [HttpGet]
        [Route("api/[controller]/[action]")]
        public IActionResult HorrorMovies()
        {
            var movies =  _context.Movies.Where(c => c.Category == "2").ToList();
            return Ok(movies);
        }

        [HttpGet]
        [Route("api/[controller]/[action]")]
        public IActionResult CartoonMovies()
        {
            var movies =  _context.Movies.Where(c => c.Category == "3").ToList();
            return Ok(movies);
        }

        [HttpGet("romancemovies")]
        public IActionResult RomanceMovies()
        {
            var movies = _context.Movies.Where(c => c.Category == "4").ToList();
            return Ok(movies);
        }

        [HttpGet("comedymovies")]

        public IActionResult ComedyMovies()
        {
            var movies = _context.Movies.Where(c => c.Category == "5").ToList();
            return Ok(movies);
        }
    }
}
