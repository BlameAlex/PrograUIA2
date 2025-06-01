using System;

/*
## TODO
- [x] Encapsulamiento
- [x] Constructor
- [x] Herencia
- [ ] Polimorfismo
*/

class Usuario
{
    string Nombre;
    string Apellido;
    int Edad;
    private string Contraseña; //encapsulada

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


}

class Persona
{
    public string Nombre;
    public int Edad;

    // este es l constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

// Estudiante va a heredar de Persona

class Estudiante : Persona
{
    public string Escuela;

    public Estudiante(string nombre, int edad, string escuela) 
        : base(nombre, edad)
        // Llama al constructor de la clase base
    {
        // y agrega lo suyo xd
        Escuela = escuela;
    }

    public void MostrarInfoCompleta()
    {
        // Llama al metodo heredado y agrega su parte

        MostrarInfo();
        Console.WriteLine($"Escuela: {Escuela}");
    }

}