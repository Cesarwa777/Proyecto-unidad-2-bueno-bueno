// Clase que representa el sensor de humedad 
using System;
class SensorHumedad
{
    private string nombre = "Sensor de Humedad";
    private double valor;
    private Random random;

    public SensorHumedad()
    {
        random = new Random();
    }

    // Simula la lectura de humedad entre 30% y 90%
    public void LeerValor()
    {
        valor = random.Next(30, 91);
    }

    public void MostrarValor()
    {
        Console.WriteLine($"{nombre}: {valor}%");
    }

    public double ObtenerValor()
    {
        return valor;
    }
}
