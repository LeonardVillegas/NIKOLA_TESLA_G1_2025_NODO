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

    //[HttpPost]
    //[Route("ReciboValor")]
    //public async Task<IActionResult> ReciboValor(Album album)
    //{
    //    return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    //}

    [HttpPost]
    [Route("AddTwoNumbers")]
    public async Task<IActionResult> AddTwoNumbers(Suma payload)
    {
        var sumatoria = await _matematika.AddTwoNumbers(payload.numeroa, payload.numerob);
        return Ok(sumatoria);
    }

    [HttpPost]
    [Route("SquareArea")]
    public async Task<IActionResult> SquareArea(AreaCuadrado areaDTO)
    {
        var area = await _matematika.Divide(areaDTO.baseC, areaDTO.alturaC);
        //var sumatoria = sumaDTO.numeroa + sumaDTO.numerob;
        return Ok(area);

        //return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    }

    [HttpPost]
    [Route("TriangleArea")]
    public async Task<IActionResult> TriangleArea(TriangleAreaDTO triangeAreaDTO)
    {
        var area = await _matematika.TriangleArea(triangeAreaDTO.baseT, triangeAreaDTO.alturaT);
        //var sumatoria = sumaDTO.numeroa + sumaDTO.numerob;
        return Ok(area);

        //return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    }

}

