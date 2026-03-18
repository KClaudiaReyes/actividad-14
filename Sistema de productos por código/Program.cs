using System;
using System.Collections.Generic;



Dictionary<string, Producto> producto = new Dictionary<string, Producto>();
Console.WriteLine("Cuantos Productos desea registrar? : ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"producto{i + 1}");
    Console.WriteLine("Codigo: "); 
    string Codigo = Console.ReadLine();
    Producto p = new Producto();
    Console.WriteLine("Nombre: "); p.Nombre = Console.ReadLine();
    Console.WriteLine("Precio: "); p.precio = double.Parse(Console.ReadLine());
    Console.WriteLine("Stock: "); p.Stock = int.Parse(Console.ReadLine());
    producto[Codigo]= p;
}
Console.WriteLine("\n PRODUCTOS REGISTRADOS");
foreach(KeyValuePair<string, Producto> item in producto)
{
    Console.Write($"Codigo: {item.Key} |");
    item.Value.MostrarDatos();
}
Console.WriteLine("ingrese un codigo para buscar: ");
string buscar = Console.ReadLine();
if (producto.ContainsKey(buscar))
{
    
    Console.WriteLine("PRODUCTO ENCONTRADO");
}
else { Console.WriteLine("NO EXISTE UN PROCTO CON ESE CODIGO"); }

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
        Console.WriteLine($"nombre: {Nombre}| Precio: Q{precio:F2} | Stock: {Stock} | Estado: {EstadoStock()}");

    }

}