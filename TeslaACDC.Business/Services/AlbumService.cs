using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    private List<Album> _albumList = new();
    private int _conunter;
    public AlbumService()
    {
        _albumList.Add(new Album { Nombre = "Insahn", Anio = 1996, Genero = "Black Metal", Id = 3 });
        _albumList.Add(new Album { Nombre = "Cowboy Carter", Anio = 1996, Genero = "pop", Id = 1 });
        _albumList.Add(new Album { Nombre = "Metanoia", Anio = 1996, Genero = "Prog", Id = 2 });
        _conunter = 3;
    }
    public async Task<BaseMessage<Album>> AddAlbum(Album album)
    {
        album.Id = _conunter++;
        _albumList.Add(album);
        return new BaseMessage<Album>()
        {
            Message = "Album was Created",
            StatusCode = System.Net.HttpStatusCode.Created,
            TotalElements = 1,
            ResponseElements = new List<Album>() { album }
        };
    }

    public async Task<BaseMessage<Album>> DeleteAlbum(int Id)
    {
        var match = from value in _albumList where value.Id == Id select value;

        if (match.Any())
        {
            var element = match.First();
            _albumList.RemoveAll(item => item.Id == Id);
            var response = new List<Album>();
            response.Add(element);
            return new BaseMessage<Album>()
            {
                Message = "Album Deleted",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = 1,
                ResponseElements = response
            };
        }
        else
        {
            return new BaseMessage<Album>()
            {
                Message = "Id not found",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = 1,
                ResponseElements = new List<Album>()
            };
        }
    }

    public async Task<BaseMessage<Album>> EditAlbum(int Id, Album album)
    {
        //

        //var match = from value in _albumList where value.Id == Id select value;
        var match = _albumList.Where(value => value.Id == Id);

        if (match.Any())
        {
            var element = match.First();
            _albumList.RemoveAll(item => item.Id == Id);
            var item = album;
            item.Id = Id;
            var response = new List<Album>();
            response.Add(item);

            return new BaseMessage<Album>()
            {
                Message = "Album Edited",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = 0,
                ResponseElements = response
            };
        }
        else
        {
            return new BaseMessage<Album>()
            {
                Message = "Invalid request",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = 0,
                ResponseElements = new List<Album>()
            };
        }
    }

    /*     
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
    */
    public async Task<BaseMessage<Album>> GetAlbumByName(string name)
    {
        var result = _albumList.Where(a => a.Nombre.ToLower().Contains(name.ToLower()));

        if (result.Any())
        {
            var ReturnedValue = result.ToList();
            return new BaseMessage<Album>()
            {
                Message = "",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = ReturnedValue.Count,
                ResponseElements = ReturnedValue
            };

        }
        return new BaseMessage<Album>()
        {
            Message = "Object Not Found",
            StatusCode = System.Net.HttpStatusCode.NotFound,
            TotalElements = 0,
            ResponseElements = new List<Album>()
        };
    }
    public async Task<BaseMessage<Album>> GetAlbumById(int id)
    {
        var result = _albumList.Where(a => a.Id == id);

        if (result.Any())
        {
            var ReturnedValue = result.ToList();
            return new BaseMessage<Album>()
            {
                Message = "",
                StatusCode = System.Net.HttpStatusCode.OK,
                TotalElements = ReturnedValue.Count,
                ResponseElements = ReturnedValue
            };

        }
        return new BaseMessage<Album>()
        {
            Message = "Object Not Found",
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

