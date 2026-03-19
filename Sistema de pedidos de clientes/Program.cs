using System;
using System.Collections.Generic;

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