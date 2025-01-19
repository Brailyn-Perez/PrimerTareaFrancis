internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public abstract class Persona
{
    public string Nombre { get; set; }
}

public class Estudiante : Persona
{
    public string NumeroUnico { get; set; }
}

public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();
}

public class Curso
{
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }
}

public class Clase
{
    public string Identificador { get; set; }
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    public List<Profesor> Profesores { get; set; } = new List<Profesor>();
}
