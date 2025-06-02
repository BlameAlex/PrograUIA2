using System;

class Program {
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Usuario
        Usuario usuario = new Usuario("Juan", "Pérez", 25, "contraseña123");
        usuario.MostrarInfo();
        Console.WriteLine(); //Espaciador
        
        // Cambiar información del usuario
        usuario.CambiarInfo("Juan Carlos", "Pérez López", 26);
        usuario.MostrarInfo();

        // Cambiar contraseña del usuario
        usuario.CambiarContraseña("nuevaContraseña456");
        Console.WriteLine(); //Espaciador

        // Crear un objeto de la clase Docente
        Docente docente = new Docente("Ana", "Gómez", 30, "docente123", "Matemáticas", "Matutino");
        docente.MostrarInfo();
        Console.WriteLine(); //Espaciador

        // Crear un objeto de la clase Alumno
        Alumno alumno = new Alumno("Luis", "Martínez", 20, "alumno123", 123456, "Ingeniería en Desarrollo de Software", "Segundo", "LITIID32");
        alumno.MostrarInfo();

    }
}