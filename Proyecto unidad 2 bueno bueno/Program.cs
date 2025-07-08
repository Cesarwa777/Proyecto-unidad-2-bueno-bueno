
﻿using System; // Importa el espacio de nombres System para usar funciones básicas como Console

namespace InvernaderoSimulacionSinHerencia
{
    // Clase principal del programa
    class Program
    {
        // Método principal, punto de entrada de la aplicación
        static void Main(string[] args)
        {
            // Crear el controlador principal del sistema
            ControladorInvernadero controlador = new ControladorInvernadero();

            Console.WriteLine("SIMULACIÓN DEL INVERNADERO");

            // Ejecutar 10 ciclos de monitoreo
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nLectura #{i}"); // Muestra el número de lectura
                controlador.EjecutarMonitoreo();      // Ejecuta un ciclo de monitoreo
                Console.WriteLine("-------------------------------");
                System.Threading.Thread.Sleep(1000);  // Esperar 1 segundo (1000 milisegundos)
            }

            Console.WriteLine("\nSimulación finalizada.");
        }
    }

    // Clase principal que coordina sensores y sistema de riego
    class ControladorInvernadero
    {
        // Atributos: sensores y sistema de riego
        private SensorTemperatura sensorTemp;
        private SensorHumedad sensorHum;
        private SistemaRiego sistemaRiego;

        // Constructor: inicializa los sensores y el sistema de riego
        public ControladorInvernadero()
        {
            sensorTemp = new SensorTemperatura();
            sensorHum = new SensorHumedad();
            sistemaRiego = new SistemaRiego();
        }

        // Ejecuta un ciclo de monitoreo del sistema
        public void EjecutarMonitoreo()
        {
            // Leer valores de los sensores
            sensorTemp.LeerValor();
            sensorHum.LeerValor();

            // Mostrar valores leídos
            sensorTemp.MostrarValor();
            sensorHum.MostrarValor();

            // Obtener el valor de humedad para tomar decisiones
            double humedad = sensorHum.ObtenerValor();

            // Evaluar si el sistema de riego debe activarse
            sistemaRiego.EvaluarCondiciones(humedad);

            // Mostrar el estado del riego
            sistemaRiego.MostrarEstado();
        }
    }

    // Clase para simular un sensor de temperatura
    class SensorTemperatura
    {
        private double valor; // Atributo que almacena el valor de temperatura

        // Simula la lectura de temperatura con un valor aleatorio
        public void LeerValor()
        {
            Random rnd = new Random();
            valor = rnd.Next(18, 35); // Simular temperatura entre 18 y 35 °C
        }

        // Muestra el valor leído
        public void MostrarValor()
        {
            Console.WriteLine($"Temperatura: {valor} °C");
        }
    }

    // Clase para simular un sensor de humedad
    class SensorHumedad
    {
        private double valor; // Atributo que almacena el valor de humedad

        // Simula la lectura de humedad con un valor aleatorio
        public void LeerValor()
        {
            Random rnd = new Random();
            valor = rnd.Next(20, 80); // Simular humedad entre 20% y 80%
        }

        // Muestra el valor leído
        public void MostrarValor()
        {
            Console.WriteLine($"Humedad: {valor}%");
        }

        // Devuelve el valor de humedad para tomar decisiones
        public double ObtenerValor()
        {
            return valor;
        }
    }

    // Clase que representa el sistema de riego
    class SistemaRiego
    {
        private bool activo; // Indica si el sistema está activado

        // Evalúa si debe activarse el riego según la humedad
        public void EvaluarCondiciones(double humedad)
        {
            activo = humedad < 40; // Activar si la humedad es menor a 40%
        }

        // Muestra si el sistema de riego está activado o no
        public void MostrarEstado()
        {
            if (activo)
                Console.WriteLine("Riego: ACTIVADO");
            else
                Console.WriteLine("Riego: DESACTIVADO");
        }
=======
﻿// Clase que representa el sensor de humedad 
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
