using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Interfaces;



public interface IAlbumService
{
    Task<BaseMessage<Album>> GetAlbumList();
    Task<BaseMessage<Album>> GetAlbumById(int? Id, string? name);
    Task<List<Album>> AddAlbum();
}