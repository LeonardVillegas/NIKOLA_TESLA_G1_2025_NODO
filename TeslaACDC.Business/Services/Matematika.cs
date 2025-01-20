using System;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;


namespace TeslaACDC.Business.Services;

public class Matematika : IMatematika
{
    public Task<float> AddTwoNumbers(float numeroa, float numerob)
    {
        return Task.FromResult(numeroa + numerob);
    }

    public Task<float> SquareArea(float numeroa, float numerob)
    {
        return Task.FromResult(numeroa * numerob);
    }

    public Task<float> SquareArea(float sideLenght)
    {
        throw new NotImplementedException();
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

    public Task<float> TriangleArea(float baseT, float alturaT)
    {
        return Task.FromResult((baseT * alturaT) / 2);
    }
}
