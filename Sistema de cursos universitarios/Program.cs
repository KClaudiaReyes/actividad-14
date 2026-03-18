using System;
using System.Collections.Generic;


List<Curso> cursos = new List<Curso>();
Console.WriteLine("Cuantos cursos desea ingresar? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Curso c = new Curso();
    Console.WriteLine($"\n curso {i+1}: ");
    Console.Write("Nombre Del Curso: ");c.nombre = Console.ReadLine();
    Console.Write("Creditos: ");c.creditos = int.Parse(Console.ReadLine());
    Console.WriteLine("Nota Promedio del Curso: "); c.NotaPromedio = int.Parse(Console.ReadLine());
    cursos.Add(c);
  
}
Curso destacado = cursos[0];
Console.WriteLine($"\n CURSOS REGISTRADOS ");
foreach(Curso c in cursos )
{
    c.MostarDatos();
    if(c.NotaPromedio > destacado.NotaPromedio) { destacado = c; }
}
Console.WriteLine($"\n Curso con MEjor PRomedio: ");
destacado.MostarDatos();
class Curso
{
    public string nombre;
    public int creditos;
    public double NotaPromedio;

    public string EvaluarREndimiento()
    {
        if (NotaPromedio >= 80) { return "EXELENTE"; }
        else if (NotaPromedio >= 61) return "ACEPTABLE";
        else return "BAJO";
    }

    public void MostarDatos()
    {
        Console.WriteLine($"Curso: {nombre} | CReditos: {creditos} |Promedio: {NotaPromedio:F2} | Rendimiento: {EvaluarREndimiento()}");
    }
}