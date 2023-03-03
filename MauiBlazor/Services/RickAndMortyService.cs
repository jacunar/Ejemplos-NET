using MauiBlazor.Models;
using System.Text.Json;

namespace MauiBlazor.Services;
public class RickAndMortyService : IRickAndMortyService {
    const string url = "https://rickandmortyapi.com/api/character";
    public async Task<RickAndMorty> Get() {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        var rickandmorty = JsonSerializer.Deserialize<RickAndMorty>(content);

        return rickandmorty;
    }
}
