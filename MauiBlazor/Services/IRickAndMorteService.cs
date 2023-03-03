using MauiBlazor.Models;

namespace MauiBlazor.Services; 
public interface IRickAndMortyService {
    public Task<RickAndMorty> Get();
}