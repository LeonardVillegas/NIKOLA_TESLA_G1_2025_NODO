using System;

namespace TeslaACDC.Business.Interfaces;

public interface IMatematika
{
    Task<float> Sum(float sumando, float sumando_2);
    Task<float> SquareArea(float sideLenght);
}
