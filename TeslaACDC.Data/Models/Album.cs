using System;

namespace TeslaACDC.Data.Models;

public class Album : BaseEntity<int>
{
    public string Nombre{get; set;} = String.Empty;
    public int Anio{get;set;}
    public string Genero{get;set;} = String.Empty;

}
