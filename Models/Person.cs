using System.Text.Json.Serialization;

namespace BlazorMovieDB.Models
{
    public class Person
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for")]
        public List<Movie> KnownFor { get; set; } = [];

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; } = null!;
    }
}
