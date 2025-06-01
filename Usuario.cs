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

// Docente va a heredar de Usuario

class Docente: Usuario
{
    public string Especialidad;

    public Docente(string nombre, string apellido, string edad, string especialidad)
    {
        CambiarInfo(nombre, apellido, int.Parse(edad));       
        Especialidad = especialidad;
    
    }

    public void MostrarInfoCompleta()
    {
        // Llama al metodo heredado y agrega su parte

        base.MostrarInfo();
        Console.WriteLine($"Especialidad: {Especialidad}");
    }

}