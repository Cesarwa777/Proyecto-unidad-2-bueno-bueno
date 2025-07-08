
using System;  // Importa el espacio de nombres System




﻿using System;  // Importa el espacio de nombres System, necesario para usar funcionalidades básicas como Console y Random.

// Clase que representa el sensor de humedad 
class SensorHumedad  // Define una clase llamada SensorHumedad.

﻿using System;

class SistemaRiego // Declara la clase SistemaRiego que representará un sistema de riego automático
{
    private bool activado; // Variable privada que indica si el sistema de riego está activado (true) o no (false)

    // Evalúa si se debe activar el riego según el valor de humedad
    public void EvaluarCondiciones(double humedad) // Método público que recibe el valor de humedad y evalúa si se debe activar el riego

﻿using System;

namespace InvernaderoSimulacionSinHerencia
{
    class Program

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

// Este es el punto de entrada del programa
class Program
{
    static void Main()
    {
        SistemaRiego sistema = new SistemaRiego();

        sistema.EvaluarCondiciones(40); // Simulamos humedad menor a 50
        sistema.MostrarEstado();

        sistema.Desactivar(); // Desactivamos manualmente
        sistema.MostrarEstado();



﻿using System; // Importa el espacio de nombres System para usar funciones básicas como Console


namespace InvernaderoSimulacionSinHerencia
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {



            // Crear el controlador principal del sistema
            ControladorInvernadero controlador = new ControladorInvernadero();


            Console.WriteLine("SIMULACIÓN DEL INVERNADERO");

            // Crear el controlador principal
            ControladorInvernadero controlador = new ControladorInvernadero();

            // Ejecutar 5 ciclos de simulación
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nLectura #{i}");
                controlador.EjecutarMonitoreo();
                Console.WriteLine("-----------------------------");
                System.Threading.Thread.Sleep(1000); // Espera 1 segundo
            }

            Console.WriteLine("\nSimulación finalizada.");
        }
    }

    // Clase que coordina sensores y sistema de riego
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

    // Sensor de temperatura
    class SensorTemperatura
    {
        private double valor;
        private Random random = new Random();
        private string nombre = "Sensor de Temperatura";

        public void LeerValor()
        {
            valor = random.Next(18, 35); // Simula entre 18 y 35 °C
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

            if (activo)
                Console.WriteLine("Riego: ACTIVADO");
            else
                Console.WriteLine("Riego: DESACTIVADO");

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
}


