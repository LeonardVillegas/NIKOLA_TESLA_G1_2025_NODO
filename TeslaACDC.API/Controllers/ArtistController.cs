using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistController : ControllerBase
{
    private readonly IArtistService _artistService;

    public ArtistController(IArtistService artistService)
    {
        _artistService = artistService;
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        var artist = await _artistService.FindById(id);
        return Ok(artist);
    }

    [HttpPost]
    [Route("AddArtist")]
    public async Task<IActionResult> AddArtist(Artist artist)
    {
        var response = await _artistService.AddArtist(artist);
        return Ok(response);

    }
}
