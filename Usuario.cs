using System;

class Usuario
{
    string Nombre;
    string Apellido;
    int Edad;
    string Contraseña; //encapsulada

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Edad: " + Edad);
    }

    public void CambiarInfo(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }


    public void CambiarContraseña(string contraseña)
    {
        Contraseña = contraseña;
    }

    public class Docente()
    {
        private string Materia;
    }

}
// This is a simple C# program that prints "hello World" to the console.