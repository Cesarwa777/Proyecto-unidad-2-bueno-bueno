using System;
using System.Threading;

namespace InvernaderoSimulacionSinHerencia
{
    // Sensor de temperatura
    class SensorTemperatura
    {
        private double valor;
        private Random random;
        private string nombre = "Sensor de Temperatura";

        public SensorTemperatura()
        {
            random = new Random();
        }

        public void LeerValor()
        {
            valor = random.Next(18, 36); // Simula entre 18 y 35 °C
        }

        public void MostrarValor()
        {
            Console.WriteLine($"{nombre}: {valor} °C");
        }

        public double ObtenerValor()
        {
            return valor;
        }
    }

    // Sensor de humedad
    class SensorHumedad
    {
        private string nombre = "Sensor de Humedad";
        private double valor;
        private Random random;

        public SensorHumedad()
        {
            random = new Random();
        }

        public void LeerValor()
        {
            valor = random.Next(30, 91); // Entre 30% y 90%
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

    // Sistema de riego automático
    class SistemaRiego
    {
        private bool activado;

        public void EvaluarCondiciones(double humedad)
        {
            activado = humedad < 50; // Activar si humedad < 50%
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

    // Controlador principal del invernadero
    class ControladorInvernadero
    {
        private SensorTemperatura sensorTemp;
        private SensorHumedad sensorHum;
        private SistemaRiego sistemaRiego;

        public ControladorInvernadero()
        {
            sensorTemp = new SensorTemperatura();
            sensorHum = new SensorHumedad();
            sistemaRiego = new SistemaRiego();
        }

        public void EjecutarMonitoreo()
        {
            sensorTemp.LeerValor();
            sensorHum.LeerValor();

            sensorTemp.MostrarValor();
            sensorHum.MostrarValor();

            double humedad = sensorHum.ObtenerValor();
            sistemaRiego.EvaluarCondiciones(humedad);
            sistemaRiego.MostrarEstado();
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            ControladorInvernadero controlador = new ControladorInvernadero();

            Console.WriteLine("SIMULACIÓN DEL INVERNADERO");

            // Ejecutar 5 ciclos de simulación
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nLectura #{i}");
                controlador.EjecutarMonitoreo();
                Console.WriteLine("-----------------------------");
                Thread.Sleep(1000); // Espera 1 segundo
            }

            Console.WriteLine("\nSimulación finalizada.");
        }
    }
}
