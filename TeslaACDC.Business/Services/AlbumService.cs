using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    private List<Album> _albumList = new ();
    public AlbumService()
    {
        _albumList.Add(new Album {Nombre = "Insahn", Anio = 1996, Genero = "Black Metal", Id=3});
        _albumList.Add(new Album {Nombre = "Cowboy Carter", Anio = 1996, Genero = "pop", Id=1});
        _albumList.Add(new Album {Nombre = "Metanoia", Anio = 1996, Genero = "Prog", Id=2});
    }
    public async Task<List<Album>> AddAlbum()
    {
        throw new NotImplementedException();
    }

    public async Task<BaseMessage<Album>> GetAlbumList()
    {
        return new BaseMessage<Album>() {
            Message="",
            StatusCode=System.Net.HttpStatusCode.OK,
            TotalElements=_albumList.Count,
            ResponseElements=_albumList
        };
    }
}

