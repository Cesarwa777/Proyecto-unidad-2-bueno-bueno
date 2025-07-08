using System;

namespace InvernaderoSimulacionSinHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aquí podrías crear una instancia del sensor y probarlo si gustas
        }
    }

    // Clase que representa un sensor de temperatura simulado
    class SensorTemperatura
    {
        // Nombre del sensor (puede usarse para identificarlo en la salida)
        private string nombre = "Sensor de Temperatura";

        // Almacena el valor actual de temperatura leído por el sensor
        private double valor;

        // Objeto para generar valores aleatorios
        private Random random;

        // Constructor: inicializa el generador de números aleatorios
        public SensorTemperatura()
        {
            random = new Random();
        }

        // Simula la lectura de un nuevo valor de temperatura entre 15 y 35 °C
        public void LeerValor()
        {
            valor = random.Next(15, 36); // Next excluye el número superior
        }

        // Muestra el valor actual de la temperatura en consola con el nombre del sensor
        public void MostrarValor()
        {
            Console.WriteLine($"{nombre}: {valor}°C");
        }

        // Devuelve el valor actual de la temperatura
        public double ObtenerValor()
        {
            return valor;
        }
    }
}


