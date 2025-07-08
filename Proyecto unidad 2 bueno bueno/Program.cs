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
            // Leer datos de sensores
            sensorTemp.LeerValor();
            sensorHum.LeerValor();

            // Mostrar valores actuales
            sensorTemp.MostrarValor();
            sensorHum.MostrarValor();

            // Evaluar si se necesita activar el riego
            double humedad = sensorHum.ObtenerValor();
            sistemaRiego.EvaluarCondiciones(humedad);

            // Mostrar estado del sistema de riego
            sistemaRiego.MostrarEstado();
        }
    }
}
