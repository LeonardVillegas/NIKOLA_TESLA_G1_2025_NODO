using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    public async Task<List<Album>> AddAlbum()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Album>> GetList()
    {
        Album album = new () 
        {
            Nombre = "Mañana será bonito",
            Genero = "Urbano",
            Anio = 2022
        };
        return new List<Album>{album};
    }
}

    