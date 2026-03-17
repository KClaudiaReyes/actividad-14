using System;
using System.Collections.Generic;



List <Producto> producto = new List <Producto> ();






class Producto 
{
    public string Nombre;
    public double precio;
    public int Cantidad;

    public double CalcularValorINventario()
    {return precio * Cantidad;}

    public string EvaluarEstock()
    {
        if (Cantidad == 0) return "SIN EXISTENCIA";
        else if (Cantidad == 10) return " Stock Bajo";
        else return "Stock Suficiente";
    }

    public void MostarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} |Precio:Q {precio}:F2 | cantidad: {Cantidad} ");
    }
}