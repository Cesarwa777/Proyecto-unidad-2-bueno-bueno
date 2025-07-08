using System;

namespace InvernaderoSimulacionSinHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el controlador principal del sistema
            ControladorInvernadero controlador = new ControladorInvernadero();

            Console.WriteLine("SIMULACIÓN DEL INVERNADERO");

            // Ejecutar 10 ciclos de monitoreo
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nLectura #{i}");
                controlador.EjecutarMonitoreo();
                Console.WriteLine("-------------------------------");
                System.Threading.Thread.Sleep(1000); // Esperar 1 segundo
            }

            Console.WriteLine("\nSimulación finalizada.");
        }
    }

    // Clase principal que coordina sensores y riego
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

        // Ejecuta un ciclo de monitoreo del sistema
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

    // Clase para sensor de temperatura
    class SensorTemperatura
    {
        private double valor;

        public void LeerValor()
        {
            Random rnd = new Random();
            valor = rnd.Next(18, 35); // Simular temperatura entre 18 y 35 °C
        }

        public void MostrarValor()
        {
            Console.WriteLine($"Temperatura: {valor} °C");
        }
    }

    // Clase para sensor de humedad
    class SensorHumedad
    {
        private double valor;

        public void LeerValor()
        {
            Random rnd = new Random();
            valor = rnd.Next(20, 80); // Simular humedad entre 20% y 80%
        }

        public void MostrarValor()
        {
            Console.WriteLine($"Humedad: {valor}%");
        }

        public double ObtenerValor()
        {
            return valor;
        }
    }

    // Clase para el sistema de riego
    class SistemaRiego
    {
        private bool activo;

        public void EvaluarCondiciones(double humedad)
        {
            activo = humedad < 40; // Activar si la humedad es baja
        }

        public void MostrarEstado()
        {
            if (activo)
                Console.WriteLine("Riego: ACTIVADO");
            else
                Console.WriteLine("Riego: DESACTIVADO");
        }
    }
}
