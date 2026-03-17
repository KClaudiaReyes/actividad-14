using System;
using System.Collections.Generic;


List <Venta> venta = new List <Venta> ();
Console.WriteLine("cuantas ventas desea registrar? ");
int n = int.Parse (Console.ReadLine ());

for (int i = 0; i < n; i++)
{
   Venta v = new Venta ();
    Console.WriteLine($" venta {i + 1}");
    Console.WriteLine("N0mbre del producto: "); v.producto = Console.ReadLine();
    Console.WriteLine("Precio: "); v.precio = double.Parse (Console.ReadLine());
    Console.WriteLine(" cantidad vendida : "); v.cantidad = int.Parse (Console.ReadLine());
    venta.Add(v);
}
double totalGEneral = 0;
Console.WriteLine("\n LISTADO DE VENTAS ");
foreach (Venta v in venta)
{
    v.MostarDatos();
    totalGEneral += v.CalcularTotal();
}
Console.WriteLine($"total General vendido:Q {totalGEneral :F2} ");

class Venta
{
    public string producto;
    public double precio;
    public int cantidad;

    public double CalcularSubTotal() { return precio * cantidad; }
    public double CalcularDescuento()
    {
        double subTotal = CalcularSubTotal();
        if (subTotal >= 500) return subTotal * 0.10;
        else if (subTotal >= 200) return subTotal * 0.05;
        else return 0;

    }
        
    public double CalcularTotal() { return CalcularSubTotal() - CalcularDescuento(); }

    public void MostarDatos()
    {
        Console.WriteLine($"Producto: { producto} | precio: {precio :F2} | Suntotal {CalcularSubTotal():F2} |Descuento: {CalcularDescuento()} " +
            $"| Total a pagar: {CalcularTotal()}");
    }
}