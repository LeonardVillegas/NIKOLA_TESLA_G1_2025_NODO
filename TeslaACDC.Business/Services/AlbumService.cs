using Microsoft.VisualBasic;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    private List<Album> _listaAlbum = new();

    public AlbumService()
    {
        _listaAlbum.Add(new (){Name = "Cowboy Carter", Genre = Genre.Pop, Year = 2024, Id = 1, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Metanoia", Genre = Genre.Metal, Year = 2024, Id = 2, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Ihsahn", Genre = Genre.Metal, Year = 2024, Id = 3, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Dua Lipa live from the Royal Albert Hall", Genre = Genre.Pop, Year = 2024, Id = 4, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Charcoal Grace", Genre = Genre.Metal, Year = 2024, Id = 5, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "From Zero", Genre = Genre.Metal, Year = 2024, Id = 6, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Short n' Sweet", Genre = Genre.Pop, Year = 2024, Id = 0, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Título de Amor", Genre = Genre.Vallenato, Year = 1993, Id = 0, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Vasos Vacíos", Genre = Genre.Metal, Year = 1998, Id = 0, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "La tierra del olvido", Genre = Genre.Metal, Year = 1991, Id = 0, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Pies descalzos", Genre = Genre.Metal, Year = 1995, Id = 0, ArtistId = 0});
        _listaAlbum.Add(new (){Name = "Chemical Brothers", Genre = Genre.Electronica, Year = 1998, ArtistId = 0});        
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

    public async Task<BaseMessage<Album>> FindById(int id)
    {
        //Album album;

        // foreach (var item in _listaAlbum)
        // {
        //     if(item.Id == id)
        //     {
        //         album = item;
        //     }
        // }

        // LINQ -> ORM Entity Framework
        // Dapper -> ORM (Framework Distinto)
        // IEnumerable
        // Select * from Album WHERE Id == 1 AND Nombre == Shakira || Producido < COLIOMBIA
        var lista = _listaAlbum.Where(x => x.Id == id).ToList();
        
        return lista.Any() ?  BuildResponse(lista, "", HttpStatusCode.OK, lista.Count) : 
            BuildResponse(lista, "", HttpStatusCode.NotFound, 0);
    }

    public async Task<BaseMessage<Album>> FindByName(string name)
    {
        var lista = _listaAlbum.FindAll(x => x.Name.ToLower().Contains(name.ToLower()));
        // x.Name.Include(name.ToLower())
        
        return lista.Any() ?  BuildResponse(lista, "", HttpStatusCode.OK, lista.Count) : 
            BuildResponse(lista, "", HttpStatusCode.NotFound, 0);
    }

    public Task<BaseMessage<Album>> FindByProperties(string name, int year)
    {
        throw new NotImplementedException();
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

    

    private BaseMessage<Album> BuildResponse(List<Album> lista, string message = "", HttpStatusCode status = HttpStatusCode.OK, 
        int totalElements = 0)
    {
        return new BaseMessage<Album>(){
            Message = message,
            StatusCode = status,
            TotalElements = totalElements,
            ResponseElements = lista
        };
    }
}

