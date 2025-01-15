namespace TeslaACDC.Controllers;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Model;

[ApiController] // @Controller
[Route("api/[controller]")]
public class TeslaController : ControllerBase
{
    
    [HttpGet]
    [Route("GetAlbum")]
    public async Task<IActionResult> GetAlbum()
    {
        Album album = new () 
        {
            Nombre = "Mañana será bonito",
            Genero = "Urbano",
            Anio = 2022
        };

        var album2 = new Album() 
        {
            Nombre = "Mañana será bonito",
            Genero = "Urbano",
            Anio = 2022
        };

        var numero = 0;
        var palabra = "Ni nombre es";
        var letra = 'a';
        var esCierto = false;
        
        return Ok(album);
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

    // Tres métodos: 
    /*
        1ro: debe devolver una array de albums
        2do: debe recibir dos valores y sumarlos, devolver el resultado
        3ro: debe calcular el area de un cuadrado.

        EXTRA CURRICULAR
        Crear una clase extra, y poner la lógica afuera del controlador.
        4to: Calcular area de un triangulo
        5to: capturar con errores.
    */
    
}

