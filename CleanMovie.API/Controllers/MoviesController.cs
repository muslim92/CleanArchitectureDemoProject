﻿using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesList = _movieService.GetAllMovies();
            return Ok(moviesList);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie) 
        {
            var Movie = _movieService.CreateMovie(movie);
            return Ok(Movie);
        }
    }
}
