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
    public async Task<IActionResult> AddTwoNumbers(SumaDTO sumaDTO)
    {
        var sumatoria = _matematika.AddTwoNumbers(sumaDTO.numeroa, sumaDTO.numerob);
        //var sumatoria = sumaDTO.numeroa + sumaDTO.numerob;
        return Ok(sumatoria);

        //return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    }

    //[HttpPost]
    //[Route("ReciboUnValor")]
    //public async Task<IActionResult> ReciboUnValor([FromBody]string album)
    //{
    //    return Ok(album);
    //}

    //[HttpGet]
    //[Route("ListAlbums")]
    //public async Task<IActionResult> GetList()
    //{
    //    var listaAlbums = new List<Album>(){
    //        new Album {Nombre = "Dark Saga", Anio = 1996, Genero = "Speed Metal"},
    //        new Album {Nombre = "Night of the StormRider", Anio = 1993, Genero = "Speed Metal"},
    //        new Album {Nombre = "Horror Show", Anio = 2001, Genero = "Speed Metal"}
    //    };

        //listaAlbums.Add(new Album {Nombre = "Dark Saga", Anio = 1996, Genero = "Speed Metal"});
    //    return Ok(listaAlbums);
    //}

    //[HttpPost]
    //[Route("Sum")]
    //public async Task<IActionResult> Sum([FromBody]float sumando, float sumando_2)
    //{
    //    var sumatoria = sumando + sumando_2;
    //    return Ok(sumatoria);
    //}

    //[HttpPost]
    //[Route("AreaCuadrado")]
    //public async Task<IActionResult> SquareArea([FromBody] float sideLenght)
    //{
    //    var area = Math.Pow(sideLenght, 2);
    //    return Ok(area);
    //}


    [HttpPost]
    [Route("SquareArea")]
    public async Task<IActionResult> SquareArea(AreaCuadradoDTO areaDTO)
    {
        var area = _matematika.SquareArea(areaDTO.baseC, areaDTO.alturaC);
        //var sumatoria = sumaDTO.numeroa + sumaDTO.numerob;
        return Ok(area);

        //return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    }

    [HttpPost]
    [Route("TriangleArea")]
    public async Task<IActionResult> TriangleArea(TriangleAreaDTO triangeAreaDTO)
    {
        var area = _matematika.TriangleArea(triangeAreaDTO.baseT, triangeAreaDTO.alturaT);
        //var sumatoria = sumaDTO.numeroa + sumaDTO.numerob;
        return Ok(area);

        //return Ok("Mi nombre es: " + album.Nombre);
        // return BadRequest("Esto es un error 400");
    }







}

