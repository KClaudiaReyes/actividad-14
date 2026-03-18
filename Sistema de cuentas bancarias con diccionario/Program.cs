using System;
using System.Collections.Generic;

List<Cuenta> cuentas = new List<Cuenta>();
Console.WriteLine("Cuantas Cuentas Desea Ingresar? :");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Cuenta c = new Cuenta();
    Console.WriteLine($"Cuenta {i + 1}");
    Console.WriteLine("Titular: "); c.Titular = Console.ReadLine();
    Console.WriteLine("Saldo Inicial: "); c.Saldo = double.Parse(Console.ReadLine());
    Console.WriteLine("Monto a Depositar: ");
    double deposito = double.Parse(Console.ReadLine());
    Console.Write("Monto a Retirar");
    double retiro = double.Parse(Console.ReadLine());
    bool retiroExitoso = c.Retirar(retiro);
    if(!retiroExitoso)
    {
        Console.WriteLine("No se puede realizar el retiro por saldo insuficiente");
    }
    cuentas.Add(c);
}
Console.WriteLine("\n CUENTAS REGISTRADAS ");
foreach (Cuenta c in cuentas)
{
    c.MostrarDatos();
}
class Cuenta
{
    public string Titular;
    public double Saldo;

    public void Depositar(double monto) 
    {   Saldo += monto; }

    public bool Retirar(double monto)
    {
        if(monto <= Saldo) 
        { Saldo -= monto;
            return true; 
        }
        return false;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Titular: {Titular} | Saldo: Q{Saldo:F2}");
    }


}