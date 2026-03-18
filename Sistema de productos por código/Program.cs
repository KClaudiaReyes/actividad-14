using System;
using System.Collections.Generic;



Dictionary<string, Producto> producto = new Dictionary<string, Producto>();
Console.WriteLine("Cuantos Productos desea registrar? : ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    
}


class Producto
{
    public string Nombre;
    public double precio;
    public int Stock;

    public string EstadoStock()
    {
        if (Stock == 0) return "AGOTADO";
        else if (Stock <= 10) return "BAJO";
        else return "NORMAL";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"nombre: {Nombre}  | Precio: Q{precio: F2} | Stock: {Stock} | Estado: {EstadoStock()}");

    }

}