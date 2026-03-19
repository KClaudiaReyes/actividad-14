using System;
using System.Collections.Generic;





List<Pedido> pedidos = new List<Pedido>();
Console.WriteLine("cuantos Pedidos desea Registrar? :");
int n = int.Parse(Console.ReadLine());

for(int i =0; i<n;i++)
{
    Pedido p = new Pedido();
    Console.WriteLine($"\n Pedido {i + 1}");
    Console.WriteLine("Cliente: "); p.Cliente = Console.ReadLine();
    Console.Write("Producto: ") ; p.Producto = Console.ReadLine();
    Console.WriteLine("Cantidad: ");p.cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("Precio Unitario: ");p.PrecioUnitario = double.Parse(Console.ReadLine());
    pedidos.Add(p);
}
double TotalVentas =0;
Console.WriteLine("\n PEDIDOS REGISTRADOS ");
foreach(Pedido p in pedidos)
{
    p.MostrarDatos();
    TotalVentas += p.CalcularTotal();
}

Console.WriteLine($"\n TOTAL general de pedidos: {TotalVentas:F2}");


class Pedido
{
    public string Cliente;
    public string Producto;
    public int cantidad;
    public double PrecioUnitario;

    public double CalcularSubtotal()
    {
        return cantidad * PrecioUnitario;
    }
    public double CalcularEnvio()
    {
        if (CalcularSubtotal() >= 300) return 0;
        else return 25;
    }
    public double CalcularTotal() { return CalcularSubtotal() + CalcularEnvio(); }
    public void MostrarDatos()
    {
        Console.WriteLine($"Cliente: {Cliente} | Producto: {Producto} | Cantidad: {cantidad} | Subtotal: {CalcularSubtotal()} | Envio: {CalcularEnvio():F2} | TOtal Final: {CalcularTotal():F2}");
    }

}