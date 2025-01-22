using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Interfaces;



public interface IAlbumService
{
    Task<BaseMessage<Album>> GetList();
    Task<BaseMessage<Album>> AddAlbum();
}