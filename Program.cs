// See https://aka.ms/new-console-template for more information

using EspacioPersonaje;

Personaje personaje1 = new Personaje();

personaje1.nombre= "William";

Console.WriteLine("El nombre es "+ personaje1.nombre);

personaje1.edad=33;

Console.WriteLine(personaje1.nombre + " tiene " + personaje1.edad + " años");