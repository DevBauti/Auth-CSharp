using Auth.Models;

namespace Auth.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Get(int Id);
        public List<Movie> List();
        public Movie Update(Movie movie);
        public bool Delete(int Id);
    }
}