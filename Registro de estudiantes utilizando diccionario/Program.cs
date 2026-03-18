using System;
using System.Collections.Generic; 



Dictionary <int ,Estudiante> estudiantes = new Dictionary <int ,Estudiante> ();
Console.WriteLine("cuantos Estudiantes desea ingresar? ");
int n = int.Parse (Console.ReadLine ());
for (int i = 0; i < n; i++)
{

    Console.WriteLine($"Estudiante{i + 1}");
    Console.WriteLine("Carnet: ");
    int carnet = int.Parse (Console.ReadLine ());
    Estudiante e = new Estudiante ();
    Console.WriteLine($"Nombre:"); e.nombre = Console.ReadLine();
    Console.WriteLine("Carrera: "); e.carrera = Console.ReadLine();
    Console.WriteLine("nota Final: "); e.notafinal = int.Parse (Console.ReadLine ());
    estudiantes[carnet] = e;
}
Console.WriteLine("LISTADO DE ESTUDIANTES ");
foreach(KeyValuePair <int , Estudiante> item  in estudiantes)
{
    Console.Write($"Carnet: {item.Key} | ");
    item.Value.MostrarDatos();
}
Console.WriteLine("ingrese un Carnet para buscar: ");
    int buscar = int.Parse (Console.ReadLine ());
if(estudiantes.ContainsKey(buscar))
{
    Console.WriteLine("Estudiante Encontrado");
    estudiantes[buscar].MostrarDatos();
}
else
{
    Console.WriteLine(" no existe el carnet ingresado");
}
class Estudiante
{
    public string nombre;
    public string carrera;
    public double notafinal;

    public string ObtenerEStado()
    { return notafinal >= 61 ? "APROBADO" : "REPROBADO"; }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre{nombre} | Carrera: {carrera} | Nota: {notafinal :F2} Estado: {ObtenerEStado}");

    }
}