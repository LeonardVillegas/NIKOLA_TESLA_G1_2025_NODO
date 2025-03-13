using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Interfaces;

public interface IArtistService
{
    public Task<BaseMessage<Artist>> FindById(int id);
    public Task<BaseMessage<Artist>> AddArtist(Artist artist);
}