using System;
using System.Collections.Generic;


List <Libro> libros = new List <Libro> ();
Console.WriteLine("cuantos libro desea registrar? :");
int n = int.Parse (Console.ReadLine ());

for (int i = 0; i < n; i++)
{
    Libro l = new Libro ();
    Console.WriteLine($" Libro{i + 1}");
    Console.WriteLine("Titulo: "); l.Titulo = Console.ReadLine();
    Console.WriteLine("Autor: "); l.autor = Console.ReadLine();
    Console.WriteLine("Categoria: "); l.categoria = Console.ReadLine();
    Console.WriteLine("Libro por cantidad de paginas: "); l.paginas = int.Parse (Console.ReadLine());
    libros.Add (l);

}

Libro mayor = libros[0];
Console.WriteLine("LISTADO DE LIBROS ");
foreach(Libro l in libros)
{
    l.MostarDatos();
    if(l.paginas > mayor.paginas) { mayor = l; }
}
Console.WriteLine("\n Libro con mas paginas: ");
mayor.MostarDatos();
class Libro
{
    public string Titulo;
    public string autor;
    public string categoria;
    public int paginas;

    public string ClasificarLibro()
    {
        if (paginas >= 600) return "Extenso";
        else if (paginas >= 300) return " Mediano";
        else return " Corto";
    }

    public string MostarDatos()
    {
        Console.WriteLine($"Titulo: {Titulo} | Autor: {autor} | Categoria: {categoria} | Tipo: {ClasificarLibro()}");
    }
}