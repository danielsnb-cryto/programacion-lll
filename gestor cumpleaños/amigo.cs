using System;

public class Amigo
{
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Amigo(string nombre, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
    }

    public int CalcularDiasParaCumple()
    {
        DateTime hoy = DateTime.Today;

        DateTime proximoCumple = new DateTime(
            hoy.Year,
            FechaNacimiento.Month,
            FechaNacimiento.Day
        );

        if (proximoCumple < hoy)
        {
            proximoCumple = proximoCumple.AddYears(1);
        }

        return (proximoCumple - hoy).Days;
    }
}