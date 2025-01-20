using System;

namespace TeslaACDC.Business.Interfaces;

public interface IMatematika
{
    Task<float> Sum(float sumando, float sumando_2);
    Task<float> AddTwoNumbers(float numeroa, float numerob);
    Task<float> TriangleArea(float baseT, float alturaT);
    Task<float> SquareArea(float numeroa, float numerob);
    Task<float> SquareArea(float sideLenght);
}
