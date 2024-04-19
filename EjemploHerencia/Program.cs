// See https://aka.ms/new-console-template for more information
using EjemploHerenciaService;
using static System.Runtime.InteropServices.JavaScript.JSType;

Veterinaria veterinaria = new Veterinaria();

Console.WriteLine("Ingresar animal (s/n)");
string ingreso = Console.ReadLine();

while (ingreso.ToLower() == "s") {
    Console.WriteLine("Ingresar Nombre: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingresar Sexo (h/m): ");
    string sexo = Console.ReadLine();

    Console.WriteLine("Ingresar Edad: ");
    int edad = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresar Tipo (P/G): ");
    string tipo = Console.ReadLine();
    string raza;
    if (tipo.ToUpper() == "P")
    {
        Console.WriteLine("Ingresar Raza: ");
        raza = Console.ReadLine();

        Perro perro = new Perro();
        perro.Nombre = nombre;
        perro.Edad = edad;
        perro.Raza = raza;

        veterinaria.AgregarAnimal(perro);

        string mover = perro.Mover();
        string dormir = perro.Dormir();
        Console.WriteLine(mover);
    }
    else {
        Gato gato = new Gato();
        gato.Nombre = nombre;
        gato.Edad = edad;

        veterinaria.AgregarAnimal(gato, tipo);

        string mover = gato.Mover();
        string dormir = gato.Dormir();
        Console.WriteLine(mover);
    }

    Console.WriteLine("Ingresar animal (s/n)");
    ingreso = Console.ReadLine();
}
