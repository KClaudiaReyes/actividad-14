using System;
using System.Collections.Generic;

class  Estudiante
{
   public string nombre;
  public  double nota1;
  public  double nota2;
   public double nota3;

    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public string ObtenerEstado ()
    {
        if (CalcularPromedio() >= 61)
            return "Aprobado";
        else return " Reprobado";
    }

    public void MostarDatos()
    {
        Console.WriteLine($"Nombre: {nombre} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado()}");
    }

}

List <Estudiante> estudiantes = new List<Estudiante>();

Console.WriteLine("cuantos estidiantes desea agregar? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0;i > n; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"Estudiante{i + 1} ");
    Console.WriteLine("Nombre: "); e.nombre = Console.ReadLine();
    Console.WriteLine("Nota 1: "); e.nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 2: "); e.nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 3: "); e.nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}

double SumarPromedio = 0;
Estudiante mejor = estudiantes[0];
Console.WriteLine(" \n LISTADO DE ESTUDIANTES ");



