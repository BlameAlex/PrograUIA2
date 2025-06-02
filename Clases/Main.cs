using System;

class Program {
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Usuario
        Usuario usuario = new Usuario("Juan", "Pérez", 25, "contraseña123");
        usuario.MostrarInfo();

        // Cambiar información del usuario
        usuario.CambiarInfo("Juan Carlos", "Pérez López", 26);
        usuario.MostrarInfo();

        // Cambiar contraseña del usuario
        usuario.CambiarContraseña("nuevaContraseña456");
    }
}