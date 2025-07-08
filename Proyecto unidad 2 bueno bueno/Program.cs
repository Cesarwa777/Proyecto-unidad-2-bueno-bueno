class SistemaRiego // Declara la clase SistemaRiego que representará un sistema de riego automático
{
    private bool activado; // Variable privada que indica si el sistema de riego está activado (true) o no (false)

    // Evalúa si se debe activar el riego según el valor de humedad
    public void EvaluarCondiciones(double humedad) // Método público que recibe el valor de humedad y evalúa si se debe activar el riego
    {
        activado = humedad < 50; // Si la humedad es menor a 50, se activa el sistema de riego (activado = true), si no, se desactiva (activado = false)
    }

    public void Activar() // Método público que activa manualmente el sistema de riego
    {
        activado = true; // Establece el estado de 'activado' en true (riego activado)
    }

    public void Desactivar() // Método público que desactiva manualmente el sistema de riego.
    {
        activado = false; // Establece el estado de 'activado' en false (riego desactivado)
    }

    public void MostrarEstado() // Método público que muestra por consola el estado actual del sistema de riego
    {
        if (activado) // Verifica si el sistema está activado
            Console.WriteLine("Riego ACTIVADO"); // Si está activado, imprime "Riego ACTIVADO"
        else
            Console.WriteLine("Riego DESACTIVADO"); // Si no está activado, imprime "Riego DESACTIVADO"
    }
}
