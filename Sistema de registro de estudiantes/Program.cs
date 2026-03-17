using System;
using System.Collections.Generic;




List<Estudiante> estudiantes = new List<Estudiante>();


Console.WriteLine("cuantos estidiantes desea agregar? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"Estudiante{i + 1} ");
    Console.WriteLine("Nombre: "); e.Nombre = Console.ReadLine();
    Console.WriteLine("Nota 1: "); e.nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 2: "); e.nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 3: "); e.nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}

double SumarPromedios = 0;
Estudiante mejor = estudiantes[0];
Console.WriteLine(" \n LISTADO DE ESTUDIANTES ");
foreach (Estudiante e in estudiantes)
{
    e.MostarDatos();
    SumarPromedios += e.CalcularPromedio();
    if (e.CalcularPromedio() > mejor.CalcularPromedio())
    { mejor = e; }

}
Console.WriteLine($"Promedio general del Grupo: {SumarPromedios / estudiantes.Count:F2} ");
Console.WriteLine("Mejor estudainte: "); mejor.MostarDatos();




class Estudiante
{
    public string Nombre;
    public double nota1;
    public double nota2;
    public double nota3;

    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public string ObtenerEstado()
    {
        if (CalcularPromedio() >= 61)
            return "Aprobado";
        else return " Reprobado";
    }

    public void MostarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado()}");
    }

}
