using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data;
//using TeslaACDC.Data.IRepository;
using TeslaACDC.Data.Models;
//using TeslaACDC.Data.Repository;
using System.Net;

namespace TeslaACDC.Business.Services;


public class ArtistService : IArtistService
{
    //private readonly NikolaContext _context;
    //private IArtistRepository<int, Artist> _artistRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ArtistService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        //_artistRepository = new ArtistRepository<int, Artist>(_context);
    }
    
    public async Task<BaseMessage<Artist>> AddArtist(Artist artist)
    {
        try{
        await _unitOfWork.ArtistRepository.AddAsync(artist);
        await _unitOfWork.SaveAsync();

        }
        catch(Exception ex){

                return new BaseMessage<Artist>() {
                Message = $"[Exception]: {ex.Message}",
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                TotalElements = 0,
                ResponseElements = new ()
            };

        }

        return new BaseMessage<Artist>() {
            Message = "",
            StatusCode = System.Net.HttpStatusCode.OK,
            TotalElements = 1,
            ResponseElements = new List<Artist>{artist}
        };

        //return artist;
    }

    public async Task<BaseMessage<Artist>> FindById(int id)
    {
        //var artist = await _artistRepository.FindAsync(id);
        //return  artist;
        Artist? artist = new();
        artist = await _unitOfWork.ArtistRepository.FindAsync(id);
        return artist != null ?
            BuildResponse(new List<Artist>(){artist},"",HttpStatusCode.OK) :
            BuildResponse(new List<Artist>(), "", HttpStatusCode.NotFound, 0);
    }

        private BaseMessage<Artist> BuildResponse(List<Artist> lista, string message = "", HttpStatusCode status = HttpStatusCode.OK, 
        int totalElements = 0)
    {
        return new BaseMessage<Artist>(){
            Message = message,
            StatusCode = status,
            TotalElements = totalElements,
            ResponseElements = lista
        };
    }
}