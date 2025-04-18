using System.Text.Json;
using System.Text.Json.Nodes;
using BlazorMovieDB.Models;

namespace BlazorMovieDB.Services
{
    public class MovieDBService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient =  httpClient;

        public async Task<List<Movie>> GetMoviesAsync(string listType)
        {
            var response = await _httpClient.GetAsync($"movie/{listType}?language=en-US&page=1");
            if (!response.IsSuccessStatusCode)
            {
                return [];
            }
            var result = await response.Content.ReadAsStringAsync();
            var jsonNode = JsonNode.Parse(result);
            return jsonNode?["results"].Deserialize<List<Movie>>() ?? [];
        }
    }
}
