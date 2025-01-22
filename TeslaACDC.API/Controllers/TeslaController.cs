namespace TeslaACDC.Controllers;

using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Business.Services;
using TeslaACDC.Data.Models;
using TeslaACDC.Data.DTO;
using System.Net;

[ApiController] // @Controller
[Route("api/[controller]")]
public class TeslaController : ControllerBase
{
    private readonly IAlbumService _albumService;
    private readonly IMatematika _matematikaService;

    public TeslaController(IAlbumService albumService, IMatematika matematikaService)
    {
        _albumService = albumService;
        _matematikaService = matematikaService;
    }

    [HttpGet]
    [Route("GetAlbum")]
    public async Task<IActionResult> GetAlbum()
    {
        var lista = await _albumService.GetList();
        return Ok(lista);
    }

    [HttpPost]
    [Route("ReciboValor")]
    public async Task<IActionResult> ReciboValor(Album album)
    {
        return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    }

    [HttpPost]
    [Route("ReciboUnValor")]
    public async Task<IActionResult> ReciboUnValor([FromBody]string album)
    {
        return Ok(album);
    }

    [HttpGet]
    [Route("ListAlbums")]
    public async Task<IActionResult> GetList()
    {
        return Ok(await _albumService.GetList());
    }

    [HttpPost]
    [Route("Sum")]
    public async Task<IActionResult> Sum([FromBody]float sumando, float sumando_2)
    {
        var sumatoria = sumando + sumando_2;
        return Ok(sumatoria);
    }

    [HttpPost]
    [Route("AreaCuadrado")]
    public async Task<IActionResult> SquareArea(float sideLenght)
    {
        var area = Math.Pow(sideLenght, 2);
        return Ok(area);
    }

    [HttpPost]
    [Route("Multiplicar")]
    public async Task<IActionResult> Multiply()
    {
        var operationMatematika = 5f + 5f + await _matematikaService.Multiply(40f, 20f);
        return Ok();
    }

    [HttpPost]
    [Route("VoyAFallar")]
    public async Task<IActionResult> Fallo(int dividendo)
    {
        var resultado = await _matematikaService.Divide(dividendo);
        return resultado.StatusCode == HttpStatusCode.OK ? Ok(resultado) : 
            StatusCode((int)resultado.StatusCode, resultado);

        // if(resultado.StatusCode == HttpStatusCode.OK)
        // {
        //     return Ok(resultado);
        // }
        // else
        // {
        //     return StatusCode((int)resultado.StatusCode, resultado);
        // }
    }


   
    
    
}

