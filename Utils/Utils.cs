using BlazorMovieDB.Models;

namespace BlazorMovieDB.Utils
{
    public class Utils
    {
        public class MovieListTypes
        {
            public const string NowPlaying = "now_playing";
            public const string Popular = "popular";
            public const string TopRated = "top_rated";
            public const string Upcoming = "upcoming";
        }

        public const string ImagesBaseURL = "https://image.tmdb.org/t/p";

        public class ImageSizes
        {
            public const string Original = "/original";
            public const string W500 = "/w500";
        }

        public static string GetImageUrl(string imagePath, string size)
        {
            return $"{ImagesBaseURL}{size}{imagePath}";
        }

        public static string GetFormatedDate(string date)
        {
            return string.IsNullOrWhiteSpace(date) ?
                string.Empty :
                DateTime.Parse(date).ToString("MMM dd, yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static readonly Dictionary<int, string> GenresDictionary = new()
        {
            { 28, "Action" },
            { 12, "Adventure" },
            { 16, "Animation" },
            { 35, "Comedy" },
            { 80, "Crime" },
            { 99, "Documentary" },
            { 18, "Drama" },
            { 10751, "Family" },
            { 14, "Fantasy" },
            { 36, "History" },
            { 27, "Horror" },
            { 10402, "Music" },
            { 9648, "Mystery" },
            { 10749, "Romance" },
            { 878, "Science Fiction" },
            { 10770, "TV Movie" },
            { 53, "Thriller" },
            { 10752, "War" },
            { 37, "Western" }
        };
    }
}
