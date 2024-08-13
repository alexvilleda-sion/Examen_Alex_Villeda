public class Asignatura : Alumno, IAsignatura
{
    public int N1 { get; set; }
    public int N2 { get; set; }
    public int N3 { get; set; }
    public string NombreAsignatura { get; set; }
    public string Horario { get; set; }
    public string NombreDocente { get; set; }

    public Asignatura(string nombreAlumno, string numeroCuenta, string email,
                      string nombreAsignatura, string horario, string nombreDocente)
        : base(nombreAlumno, numeroCuenta, email)
    {
        NombreAsignatura = nombreAsignatura;
        Horario = horario;
        NombreDocente = nombreDocente;
    }

    public double CalcularNotaFinal()
    {
        return N1 + N2 + N3;
    }

    public double CalcularNotaFinal(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }

    public string MensajeNotaFinal(double notaFinal)
    {
        if (notaFinal >= 0 && notaFinal < 60)
            return "Reprobado";
        else if (notaFinal >= 60 && notaFinal < 80)
            return "Bueno";
        else if (notaFinal >= 80 && notaFinal < 90)
            return "Muy Bueno";
        else if (notaFinal >= 90 && notaFinal <= 100)
            return "Sobresaliente";
        else
            return "Nota fuera de rango";
    }

    public void Imprimir()
    {
        double notaFinal = CalcularNotaFinal();
        Console.WriteLine("Datos del Alumno:");
        Console.WriteLine($"Nombre: {NombreAlumno}");
        Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine("Datos de la Asignatura:");
        Console.WriteLine($"Nombre Asignatura: {NombreAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Nombre Docente: {NombreDocente}");
        Console.WriteLine($"Nota Final (sin parámetros): {notaFinal} - {MensajeNotaFinal(notaFinal)}");
        Console.WriteLine($"Nota Final (con parámetros): {CalcularNotaFinal(N1, N2, N3)} - {MensajeNotaFinal(CalcularNotaFinal(N1, N2, N3))}");
    }
}
