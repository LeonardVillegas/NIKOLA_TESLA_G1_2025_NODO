using System;

namespace TeslaACDC.Business.Interfaces;

public interface IMatematika
{
    Task<float> Sum(float sumando, float sumando_2);
    Task<float> SumDosNumeros(float numeroa, float numerob);
    Task<float> areaCuadrado(float numeroa, float numerob);
    Task<float> SquareArea(float sideLenght);
}
