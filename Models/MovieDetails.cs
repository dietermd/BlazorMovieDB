using System.Text.Json.Serialization;

namespace BlazorMovieDB.Models
{
    public class MovieDetails
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = null!;

        [JsonPropertyName("belongs_to_collection")]
        public BelongsToCollection? BelongsToCollection { get; set; }

        [JsonPropertyName("budget")]
        public int Budget { get; set; }

        [JsonPropertyName("genres")]
        public List<Genre> Genres { get; set; } = [];

        [JsonPropertyName("homepage")]
        public string Homepage { get; set; } = null!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; } = null!;

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } = null!;

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = null!;

        [JsonPropertyName("overview")]
        public string Overview { get; set; } = null!;

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = null!;

        [JsonPropertyName("production_companies")]
        public List<ProductionCompany> ProductionCompanies { get; set; } = [];

        [JsonPropertyName("production_countries")]
        public List<ProductionCountry> ProductionCountries { get; set; } = [];

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; } = null!;

        [JsonPropertyName("revenue")]
        public long Revenue { get; set; }

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

        [JsonPropertyName("spoken_languages")]
        public List<SpokenLanguage> SpokenLanguages { get; set; } = [];

        [JsonPropertyName("status")]
        public string Status { get; set; } = null!;

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; } = null!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        [JsonPropertyName("credits")]
        public Credits Credits { get; set; } = null!;

        [JsonPropertyName("videos")]
        public Videos Videos { get; set; } = null!;
    }

    public class BelongsToCollection
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = null!;

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = null!;
    }

    public class Genre
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }

    public class ProductionCompany
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("logo_path")]
        public string? LogoPath { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; set; } = null!;
    }

    public class ProductionCountry
    {
        [JsonPropertyName("iso_3166_1")]
        public string Iso3166_1 { get; set; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }

    public class SpokenLanguage
    {
        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; } = null!;

        [JsonPropertyName("iso_639_1")]
        public string Iso639_1 { get; set; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }

    public class Credits
    {
        [JsonPropertyName("cast")]
        public List<Cast> Cast { get; set; } = [];

        [JsonPropertyName("crew")]
        public List<Cast> Crew { get; set; } = [];
    }

    public class Cast
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; } = null!;

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string? ProfilePath { get; set; }

        [JsonPropertyName("cast_id")]
        public int? CastId { get; set; }

        [JsonPropertyName("character")]
        public string? Character { get; set; }

        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; } = null!;

        [JsonPropertyName("order")]
        public int? Order { get; set; }

        [JsonPropertyName("department")]
        public string? Department { get; set; }

        [JsonPropertyName("job")]
        public string? Job { get; set; }
    }

    public class Videos
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; } = [];
    }

    public class Result
    {
        [JsonPropertyName("iso_639_1")]
        public string Iso639_1 { get; set; } = null!;

        [JsonPropertyName("iso_3166_1")]
        public string Iso3166_1 { get; set; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("key")]
        public string Key { get; set; } = null!;

        [JsonPropertyName("site")]
        public string Site { get; set; } = null!;

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

        [JsonPropertyName("official")]
        public bool Official { get; set; }

        [JsonPropertyName("published_at")]
        public string PublishedAt { get; set; } = null!;

        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;
    }
}
