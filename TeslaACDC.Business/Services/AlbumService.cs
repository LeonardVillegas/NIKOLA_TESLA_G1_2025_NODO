using Microsoft.VisualBasic;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    private List<Album> _listaAlbum = new();

    public AlbumService()
    {
        _listaAlbum.Add(new (){Name = "Cowboy Carter", Genre = Genre.Pop, Year = 2024, Id = 1});
        _listaAlbum.Add(new (){Name = "Metanoia", Genre = Genre.Metal, Year = 2024, Id = 2});
        _listaAlbum.Add(new (){Name = "Ihsahn", Genre = Genre.Metal, Year = 2024, Id = 3});
        Album album = new Album();
    }

    public async Task<BaseMessage<Album>> AddAlbum()
    {
        try{
            _listaAlbum.Add(new (){Name = "Sunrise Over Rigor Mortis", Genre = Genre.Metal, Year = 2024, Id = 4});
        }catch{
            return new BaseMessage<Album>() {
                Message = "",
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                TotalElements = 0,
                ResponseElements = new ()
            };
        }
        
        
        return new BaseMessage<Album>() {
            Message = "",
            StatusCode = System.Net.HttpStatusCode.OK,
            TotalElements = _listaAlbum.Count,
            ResponseElements = _listaAlbum
        };
        
    }

    public async Task<BaseMessage<Album>> GetList()
    {
        return new BaseMessage<Album>() {
            Message = "",
            StatusCode = System.Net.HttpStatusCode.OK,
            TotalElements = _listaAlbum.Count,
            ResponseElements = _listaAlbum
        };
    }
}

    