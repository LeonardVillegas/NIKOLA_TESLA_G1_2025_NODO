namespace TeslaACDC.Controllers;

using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Business.Services;
using TeslaACDC.Data.Models;

[ApiController] // @Controller
[Route("api/[controller]")]
public class TeslaController : ControllerBase
{
    private readonly IAlbumService _albumService;
    private readonly IMatematika _matematika;

    public TeslaController(
    IAlbumService albumService,
    IMatematika matematika
    )
    {
        _albumService = albumService;
        _matematika = matematika;
    }

    [HttpGet]
    [Route("GetAlbumList")]
    public async Task<IActionResult> GetAlbum()
    {
        var lista = await _albumService.GetAlbumList();
        return Ok(lista);
    }
    [HttpGet]
    [Route("SearchAlbum")]
    public async Task<IActionResult> GetAlbumById([FromQuery] int? id, [FromQuery] string? name)
    {

            var lista = await _albumService.GetAlbumById(id, name);
            return Ok(lista);
    }

    [HttpPost]
    [Route("AddTwoNumbers")]
    public async Task<IActionResult> AddTwoNumbers(Suma payload)
    {
        var sumatoria = await _matematika.AddTwoNumbers(payload.numeroa, payload.numerob);
        return Ok(sumatoria);
    }

    [HttpPost]
    [Route("SquareArea")]
    public async Task<IActionResult> SquareArea(AreaCuadrado valores)
    {
        var area = await _matematika.Divide(valores.baseC, valores.alturaC);
        return Ok(area);
    }

    [HttpPost]
    [Route("TriangleArea")]
    public async Task<IActionResult> TriangleArea(TriangleArea triangeArea)
    {
        var area = await _matematika.TriangleArea(triangeArea.baseT, triangeArea.alturaT);
        //var sumatoria = sumaDTO.numeroa + sumaDTO.numerob;
        return Ok(area);
    }

}

