using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        /*
        public enum ChurchMovieGenre
        {
            Drama,
            Inspirational,
            FaithBased,
            Biblical,
            Documentary,
            Musical,
            Family,
            Historical,
            Comedy
        }*/
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string MovieGenre { get; set; }
        public string? SearchString { get; set; }
        public string? ReleaseDate { get; set; }
    }
}
