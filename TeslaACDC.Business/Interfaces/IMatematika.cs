using System;

namespace TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

public interface IMatematika
{
    Task<float> Sum(float sumando, float sumando_2);
    Task<float> AddTwoNumbers(float numeroa, float numerob);
    Task<float> TriangleArea(float baseT, float alturaT);
    Task<BaseMessage<string>> Divide(float numeroa, float numerob);
    Task<float> SquareArea(float sideLenght);
}
