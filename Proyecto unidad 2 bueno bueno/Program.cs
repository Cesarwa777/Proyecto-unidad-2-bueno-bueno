using System;  // Importa el espacio de nombres System, necesario para usar funcionalidades básicas como Console y Random.

// Clase que representa el sensor de humedad 
class SensorHumedad  // Define una clase llamada SensorHumedad.
{
    private string nombre = "Sensor de Humedad";  // Atributo privado que almacena el nombre del sensor.
    private double valor;  // Atributo privado que guardará el valor actual de humedad.
    private Random random;  // Atributo privado para generar números aleatorios.

    public SensorHumedad()  // Constructor de la clase SensorHumedad.
    {
        random = new Random();  // Inicializa el objeto random para poder generar valores aleatorios.
    }

    // Simula la lectura de humedad entre 30% y 90%
    public void LeerValor()  // Método público que simula leer un valor de humedad.
    {
        valor = random.Next(30, 91);  // Genera un número aleatorio entre 30 y 90 (91 no incluido) y lo asigna a 'valor'.
    }

    public void MostrarValor()  // Método público que muestra el valor de humedad en consola.
    {
        Console.WriteLine($"{nombre}: {valor}%");  // Imprime el nombre del sensor y su valor actual seguido del símbolo de porcentaje.
    }

    public double ObtenerValor()  // Método público que devuelve el valor actual de humedad.
    {
        return valor;  // Retorna el valor almacenado en el atributo 'valor'.
    }
}

class Program  // Clase principal que contiene el punto de entrada del programa.
{
    static void Main(string[] args)  // Método Main: punto de entrada del programa, requerido para que se ejecute.
    {
        SensorHumedad sensor = new SensorHumedad();  // Crea una nueva instancia del sensor de humedad.

        sensor.LeerValor();  // Llama al método para simular una lectura de humedad.

        sensor.MostrarValor();  // Llama al método para mostrar en pantalla el valor leído.

        double valorHumedad = sensor.ObtenerValor();  // Llama al método que devuelve el valor leído y lo guarda en una variable.

        Console.WriteLine("Valor obtenido por método: " + valorHumedad + "%");  // Imprime en consola el valor obtenido directamente.
    }
}
