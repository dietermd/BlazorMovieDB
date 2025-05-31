using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using BlazorMovieDB.Models;
using Microsoft.AspNetCore.WebUtilities;

namespace BlazorMovieDB.Services
{
    public class MovieDBService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient =  httpClient;

        public async Task<List<Movie>> GetMoviesAsync(string listType)
        {
            var response = await _httpClient.GetAsync($"movie/{listType}");
            if (!response.IsSuccessStatusCode)
            {
                return [];
            }
            var result = await response.Content.ReadAsStringAsync();
            var jsonNode = JsonNode.Parse(result);
            return jsonNode?["results"].Deserialize<List<Movie>>() ?? [];
        }

        public async Task<List<Movie>> SearchMoviesAsync(string movieSearch, CancellationToken cancellationToken)
        {
            var queryParams = new Dictionary<string, string?>
            {
                { "query", movieSearch }
            };
            var url = QueryHelpers.AddQueryString($"search/movie", queryParams);
            var response = await _httpClient.GetAsync(url, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return [];
            }
            var result = await response.Content.ReadAsStringAsync(cancellationToken);
            var jsonNode = JsonNode.Parse(result);
            return jsonNode?["results"].Deserialize<List<Movie>>() ?? [];
        }

        public async Task<MovieDetails?> GetMovieDetails(int movieId, CancellationToken cancellationToken)
        {
            var queryParams = new Dictionary<string, string?>
            {
                { "append_to_response", "credits,videos" }
            };
            var url = QueryHelpers.AddQueryString($"movie/{movieId}", queryParams);
            var response = await _httpClient.GetAsync(url, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var result = await response.Content.ReadAsStringAsync(cancellationToken);
            var movieDetails = JsonSerializer.Deserialize<MovieDetails>(result);
            return movieDetails;
        }

        public async Task<List<Person>> GetPopularPeople(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($"person/popular", cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return [];
            }
            var result = await response.Content.ReadAsStringAsync(cancellationToken);
            var jsonNode = JsonNode.Parse(result);
            return jsonNode?["results"].Deserialize<List<Person>>() ?? [];
        }
    }
}
