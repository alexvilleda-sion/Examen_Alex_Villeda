using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el nombre del alumno:");
            string nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cuenta del alumno:");
            string numeroCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese el email del alumno:");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la asignatura:");
            string nombreAsignatura = Console.ReadLine();
            Console.WriteLine("Ingrese el horario de la asignatura:");
            string horario = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del docente:");
            string nombreDocente = Console.ReadLine();

            int n1 = ObtenerNota("primer parcial (0-30)", 30);
            int n2 = ObtenerNota("segundo parcial (0-30)", 30);
            int n3 = ObtenerNota("tercer parcial (0-40)", 40);

            Asignatura asignatura = new Asignatura(nombreAlumno, numeroCuenta, email, nombreAsignatura, horario, nombreDocente);
            asignatura.N1 = n1;
            asignatura.N2 = n2;
            asignatura.N3 = n3;

            asignatura.Imprimir();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static int ObtenerNota(string mensaje, int maxNota)
    {
        int nota;
        while (true)
        {
            Console.WriteLine($"Ingrese la nota del {mensaje}:");
            if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= maxNota)
                return nota;
            else
                Console.WriteLine($"Nota inválida. Debe ser un número entero entre 0 y {maxNota}.");
        }
    }
}
