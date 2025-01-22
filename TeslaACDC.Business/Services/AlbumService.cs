using Microsoft.VisualBasic;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    private List<Album> _listaAlbum = new();

    public AlbumService()
    {
        _listaAlbum.Add(new (){Nombre = "Cowboy Carter", Genero = "Pop", Anio = 2024, Id = 1});
        _listaAlbum.Add(new (){Nombre = "Metanoia", Genero = "Prog", Anio = 2024, Id = 2});
        _listaAlbum.Add(new (){Nombre = "Ihsahn", Genero = "Black Metal", Anio = 2024, Id = 3});
    }

    public async Task<BaseMessage<Album>> AddAlbum()
    {
        try{
            _listaAlbum.Add(new (){Nombre = "Sunrise Over Rigor Mortis", Genero = "Extreme Black Metal", Anio = 2024, Id = 4});
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

    