using System;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;


namespace TeslaACDC.Business.Services;

public class Matematika : IMatematika
{
    public async Task<float> AddTwoNumbers(float numeroa, float numerob)
    {
        return numeroa + numerob;
    }

    public async Task<float> SquareArea(float numeroa, float numerob)
    {
        return numeroa * numerob;
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
