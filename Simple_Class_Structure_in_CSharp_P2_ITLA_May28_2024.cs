using System;

public abstract class MiembroComunidad
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public abstract void Save();

    public virtual void Get()
    {
    }
}

public class Empleado : MiembroComunidad
{
    public Empleado()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando Empleado...");
    }
}

public class Estudiante : MiembroComunidad
{
    public Estudiante()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando Estudiante...");
    }
}

public class ExAlumno : MiembroComunidad
{
    public ExAlumno()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando ExAlumno...");
    }
}

public class Docente : Empleado
{
    public Docente()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando Docente...");
    }
}

public class Administrativo : Empleado
{
    public Administrativo()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando Administrativo...");
    }
}

public class Administrador : Docente
{
    public Administrador()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando Administrador...");
    }
}

public class Maestro : Docente
{
    public Maestro()
    {
    }

    public override void Get()
    {
        base.Get();
    }

    public override void Save()
    {
        Console.WriteLine("Guardando Maestro...");
    }
}
