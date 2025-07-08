// Clase que representa el sensor de humedad 
using System;  // Importa el espacio de nombres System, necesario para usar funciones como Console y Random.

class SensorHumedad  // Define una clase llamada SensorHumedad.
{
    private string nombre = "Sensor de Humedad";  // Atributo privado que almacena el nombre del sensor.
    private double valor;  // Atributo privado que almacenará el valor actual de la humedad.
    private Random random;  // Atributo privado para generar números aleatorios.

    public SensorHumedad()  // Constructor de la clase SensorHumedad.
    {
        random = new Random();  // Inicializa el objeto random para poder generar valores aleatorios.
    }

    // Simula la lectura de humedad entre 30% y 90%
    public void LeerValor()  // Método público que simula la lectura de un valor de humedad.
    {
        valor = random.Next(30, 91);  // Genera un número entero aleatorio entre 30 y 90 (el 91 no se incluye) y lo asigna a 'valor'.
    }

    public void MostrarValor()  // Método público que muestra el valor actual de humedad en consola.
    {
        Console.WriteLine($"{nombre}: {valor}%");  // Imprime en consola el nombre del sensor y el valor de humedad con el símbolo de porcentaje.
    }

    public double ObtenerValor()  // Método público que permite obtener el valor actual de humedad.
    {
        return valor;  // Retorna el valor de humedad almacenado.
    }
}
