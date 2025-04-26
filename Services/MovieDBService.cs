using System.Text.Json;
using System.Text.Json.Nodes;
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
    }
}
