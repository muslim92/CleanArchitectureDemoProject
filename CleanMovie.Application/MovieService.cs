using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        //Inject dependenices through Constructor

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> lstAllMovies = new List<Movie>();
            lstAllMovies = _movieRepository.GetAllMovies();
            return lstAllMovies;
        }
    }
}
