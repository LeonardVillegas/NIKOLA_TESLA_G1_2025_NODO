using System;
using System.Net;


using System.Security;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;


namespace TeslaACDC.Business.Services;

public class Matematika : IMatematika
{
    public async Task<float> AddTwoNumbers(float numeroa, float numerob)
    {
        return numeroa + numerob;
    }

    public async Task<BaseMessage<string>> Divide(float numeroa, float numerob)
    {
        if (numerob == 0)
        {
            return new BaseMessage<string>
            {
                Message = "No se puede dividir entre cero",
                StatusCode = HttpStatusCode.InternalServerError,
                TotalElements = 0,
                ResponseElements = new() { }
            };
        }
        var side = 10;
        float cociente = 0f;
        try
        {
            cociente = side / numerob;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new BaseMessage<string>
            {
                Message = $"[Error] {ex.Message}",
                StatusCode = HttpStatusCode.InternalServerError,
                TotalElements = 0,
                ResponseElements = new() { }
            };
        }

        return new BaseMessage<string>
        {
            Message = "",
            StatusCode = HttpStatusCode.OK,
            TotalElements = 0,
            ResponseElements = new() { cociente.ToString() }
        };
    }

    public async Task<float> SquareArea(float sideLenght)
    {
        return (sideLenght * sideLenght);
    }

    public async Task<float> Sum(float sumando, float sumando_2)
    {
        throw new NotImplementedException();
    }

    public async Task<float> SumDosNumeros(float numeroa, float numerob)
    {
        float sumatoria = numeroa + numerob;
        return sumatoria;
    }

    public async Task<float> TriangleArea(float baseT, float alturaT)
    {
        return ((baseT * alturaT) / 2);
    }
}
