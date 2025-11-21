using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService: IMovieService
{
    private readonly IMovieRepository _repository;
    public MovieService(IMovieRepository movieRepository)
    {
        _repository = movieRepository;
    }
    public List<MovieCardModel> Top20GrossingMovie()
    {
        var movies = _repository.GetTop20GrossingMovies();
        var movieCardModels = new List<MovieCardModel>();
        foreach (var movie in movies)
        {
            movieCardModels.Add(new MovieCardModel()
            {
                Title = movie.Title,
                Id = movie.Id,
                PosterUrl = movie.PosterUrl
            });
        }
        return movieCardModels;
    }

    public MovieDetailsModel GetMovieDetails(int id)
    {
        var movie = _repository.GetById(id);
        if (movie == null)
        {
            return null;
        }

        var movieDetailsModel = new MovieDetailsModel()
        {
            Id = movie.Id,
            Title = movie.Title,
            PosterUrl = movie.PosterUrl,
            Overview = movie.Overview,
            Tagline = movie.Tagline,
            Budget = movie.Budget,
            Revenue = movie.Revenue
        };
        return movieDetailsModel;
    }

    public bool DeleteMovie(int id)
    {
        var movie = _repository.DeleteById(id);
        if (movie == null)
        {
            return false;
        }

        return true;
    }
}
