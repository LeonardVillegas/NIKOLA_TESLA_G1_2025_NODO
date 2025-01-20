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
        var listaAlbums = new List<Album>(){
            new Album {Nombre = "Dark Saga", Anio = 1996, Genero = "Speed Metal"},
            new Album {Nombre = "Night of the StormRider", Anio = 1993, Genero = "Speed Metal"},
            new Album {Nombre = "Horror Show", Anio = 2001, Genero = "Speed Metal"}
        };
        return listaAlbums;
    }
}

