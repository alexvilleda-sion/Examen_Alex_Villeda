public class Alumno
{
    public string NombreAlumno { get; set; }
    public string NumeroCuenta { get; set; }
    public string Email { get; set; }

    public Alumno(string nombreAlumno, string numeroCuenta, string email)
    {
        NombreAlumno = nombreAlumno;
        NumeroCuenta = numeroCuenta;
        Email = email;
    }
}
