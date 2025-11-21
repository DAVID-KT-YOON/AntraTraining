using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MovieRepository: BaseRepository<Movie>, IMovieRepository
{
    public MovieRepository(MovieShopDbContext context) : base(context)
    {
    }

    public IEnumerable<Movie> GetTop20GrossingMovies()
    {
        var movies = _context.Movies.OrderByDescending(m => m.Revenue).Take(20);
        return movies;
    }
}