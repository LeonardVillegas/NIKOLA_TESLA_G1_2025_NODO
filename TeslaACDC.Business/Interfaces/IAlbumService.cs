using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Interfaces;



public interface IAlbumService
{
    Task<BaseMessage<Album>> GetAlbumList();
    //Task<BaseMessage<Album>> GetAlbumById(int? Id, string? name);
    Task<BaseMessage<Album>> AddAlbum(Album album);
    Task<BaseMessage<Album>> EditAlbum(int Id, Album album);
    Task<BaseMessage<Album>> DeleteAlbum(int Id);

    Task<BaseMessage<Album>> GetAlbumById(int id);

    Task<BaseMessage<Album>> GetAlbumByName(string name);
}