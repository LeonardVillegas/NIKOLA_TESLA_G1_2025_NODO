using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    private List<Album> _albumList = new();
    public AlbumService()
    {
        _albumList.Add(new Album { Nombre = "Insahn", Anio = 1996, Genero = "Black Metal", Id = 3 });
        _albumList.Add(new Album { Nombre = "Cowboy Carter", Anio = 1996, Genero = "pop", Id = 1 });
        _albumList.Add(new Album { Nombre = "Metanoia", Anio = 1996, Genero = "Prog", Id = 2 });
    }
    public async Task<List<Album>> AddAlbum()
    {
        throw new NotImplementedException();
    }

    public async Task<BaseMessage<Album>> GetAlbumById(int? Id, string? name)
    {
        // Define resoultMatch outside the conditional blocks
        IEnumerable<Album> resoultMatch;
        if (Id.HasValue && name == null)
        {
            resoultMatch = from value in _albumList
                           where value.Id == Id
                           select value;
        }
        else if (Id.HasValue && name != null)
        {
            resoultMatch = from value in _albumList
                           where value.Id == Id && value.Nombre == name
                           select value;
        }
        else if (Id == null && name != null)
        {
            resoultMatch = from value in _albumList
                           where value.Nombre == name
                           select value;
        }
        //else if (Id == null && name == null)
        else
        {
            return new BaseMessage<Album>()
            {
                Message = "Invalid request",
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                TotalElements = 0,
                ResponseElements = new List<Album>()
            };
        }



        if (resoultMatch.Any())
        {
            return new BaseMessage<Album>()
            {
                Message = "Sucess",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = resoultMatch.ToList().Count,
                ResponseElements = resoultMatch.ToList()
            };
        }

        return new BaseMessage<Album>()
        {
            Message = "Not Matching elements",
            StatusCode = System.Net.HttpStatusCode.NotFound,
            TotalElements = 0,
            ResponseElements = new List<Album>()
        };

    }

    public async Task<BaseMessage<Album>> GetAlbumList()
    {
        return new BaseMessage<Album>()
        {
            Message = "",
            StatusCode = System.Net.HttpStatusCode.OK,
            TotalElements = _albumList.Count,
            ResponseElements = _albumList
        };
    }
}

