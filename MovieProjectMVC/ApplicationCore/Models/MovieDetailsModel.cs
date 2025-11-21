namespace ApplicationCore.Models;

public class MovieDetailsModel
{
    public int  Id { get; set; }
    public string Title { get; set; }
    public string PosterUrl { get; set; }
    public string? Overview { get; set; }
    public string? Tagline { get; set; }
    public decimal? Budget { get; set; }
    public decimal? Revenue { get; set; }
}