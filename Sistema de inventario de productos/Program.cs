using System;
using System.Collections.Generic;



List <Producto> producto = new List <Producto> ();

Console.WriteLine("cuantos Productos desea registrar? ");
int n = int.Parse (Console.ReadLine ());

for(int i = 0; i < n; i++)
{
    Producto p = new Producto ();
    Console.WriteLine($"\n  Producto {i + 1}");
    Console.WriteLine("Nombre: "); p.Nombre = Console.ReadLine();
    Console.WriteLine("Precio: "); p.precio = double.Parse (Console.ReadLine());
    Console.WriteLine("Cantidad: "); p.Cantidad = int.Parse (Console.ReadLine());
    producto.Add (p);
}

double InventarioTotal = 0;
Producto MasCostoso = producto[0];
Console.WriteLine("\n INVENTARIO ");
foreach(Producto p in producto)
{
    InventarioTotal += p.CalcularValorINventario();
    if (p.precio > MasCostoso.precio)
    { MasCostoso = p; }
}
Console.WriteLine($"Valor Total del inventario:Q {InventarioTotal}:F2");
Console.WriteLine("Producto con mayor precio: "); MasCostoso.MostarDatos();
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