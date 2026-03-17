using System;
using System.Collections.Generic;
using System.Xml.Schema;





List <Empleados>empleados = new List <Empleados> ();

Console.WriteLine("cuantos empleados desea ingresar? ");
int n = int.Parse (Console.ReadLine ());

for (int i = 0; i < n; i++)
{
    Empleados empleado = new Empleados ();
    Console.WriteLine($"Empleado {i + 1}");
    Console.WriteLine("Nombre :"); empleado.Nombre = Console.ReadLine();
    Console.WriteLine("Puesto :"); empleado.Puesto = Console.ReadLine();
    Console.WriteLine(" Salario Mensual: "); empleado.SalarioMensual = double.Parse (Console.ReadLine());
    empleados.Add(empleado);
}

Console.WriteLine("\n LISTA DE EMPLEADOS ");
foreach(Empleados empleado in empleados)
{
    empleado.MostrarDatos();
}


class Empleados
{
    public string Nombre;
    public string Puesto;
    public double SalarioMensual;

public double CalcularSalarioAnua()
    {
        return SalarioMensual * 14; 
            
    }

    public double CalcularBono()
    {
        if (SalarioMensual >= 6000) return SalarioMensual * 0.15;
        else return SalarioMensual * 0.08;      
    }

    public string ClasificarSalario()
    {
        if (SalarioMensual >= 7000) return "SALARIO ALTO ";
        else if (SalarioMensual >= 4000) return "SALARIO MEDIO";
        else return "SALARIO BASICO ";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Puesto: {Puesto}  | Salario Mensual: Q{SalarioMensual :F2} |" +
            $" Salario Anual:Q {CalcularSalarioAnua():F2} | Bono: Q{CalcularBono()} | Nivel: {ClasificarSalario} " );
    }
}