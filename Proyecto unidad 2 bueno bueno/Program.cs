using System;  // Importa las funcionalidades básicas como Console y Random.

// Clase que representa el sensor de humedad 
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

// Clase principal con el punto de entrada del programa
class Program
{
    static void Main(string[] args)  // Este es el método que el compilador necesita para empezar.
    {
        // Crear un objeto del sensor de humedad
        SensorHumedad sensor = new SensorHumedad();

        // Leer y mostrar el valor de humedad
        sensor.LeerValor();
        sensor.MostrarValor();

        // También podrías usar ObtenerValor si lo necesitas
        double valorHumedad = sensor.ObtenerValor();
        Console.WriteLine("Valor obtenido por método: " + valorHumedad + "%");
    }
}
