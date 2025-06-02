using System;

/*
## TODO
- [x] Encapsulamiento
- [x] Constructor
- [x] Herencia
- [x] Polimorfismo
*/

class Usuario { // todas las clases heredaran estos atributos y metodos
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    private string Contraseña; //encapsulada

    public Usuario(string nombre, string apellido, int edad, string contraseña) { //Constructor
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Contraseña = contraseña; 
    }
    public void CambiarInfo(string nombre, string apellido, int edad) {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }
    public virtual void MostrarInfo() {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Apellido: " + Apellido);
        Console.WriteLine("Edad: " + Edad);
    }
    public void CambiarContraseña(string contraseña) {
        Contraseña = contraseña;
    }
}

class Docente : Usuario {
    private string Especialidad = "";
    private string Horario = ""; 

    public Docente(string nombre, string apellido, int edad, string contraseña, string especialidad, string horario)
    : base(nombre, apellido, edad, contraseña) {
        this.Especialidad = especialidad;
        this.Horario = horario;
    }

    public override void MostrarInfo() { // Sobreescribe el método de la clase base Usuario 
        base.MostrarInfo(); // Llama al método de la clase base Usuario
        Console.WriteLine("Especialidad: " + Especialidad);
        Console.WriteLine("Horario: " + Horario);
    }
}
class Alumno : Usuario {
    private int matricula;
    private string carrera = "";
    private string semestre = "";
    private string grupo = "";
    
    public Alumno(string nombre, string apellido, int edad, string contraseña, int matricula, string carrera, string semestre, string grupo)
    : base(nombre, apellido, edad, contraseña) {
        this.matricula = matricula;
        this.carrera = carrera;
        this.semestre = semestre;
        this.grupo = grupo;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo(); // Llama al método de la clase base Usuariox
        Console.WriteLine("Matrícula: " + matricula);
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Semestre: " + semestre);
        Console.WriteLine("Grupo: " + grupo);
    }
}