// Clase que representa el sistema de riego
class SistemaRiego
{
    private bool activado;

    // Evalúa si se debe activar el riego según el valor de humedad
    public void EvaluarCondiciones(double humedad)
    {
        activado = humedad < 50;
    }

    public void Activar()
    {
        activado = true;
    }

    public void Desactivar()
    {
        activado = false;
    }

    public void MostrarEstado()
    {
        if (activado)
            Console.WriteLine("Riego ACTIVADO");
        else
            Console.WriteLine("Riego DESACTIVADO");
    }
}