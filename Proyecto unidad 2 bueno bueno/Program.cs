// Clase que representa el sensor de temperatura 
class SensorTemperatura
{
    private string nombre = "Sensor de Temperatura";
    private double valor;
    private Random random;

    public SensorTemperatura()
    {
        random = new Random();
    }

    // Simula la lectura de temperatura entre 15 y 35 °C
    public void LeerValor()
    {
        valor = random.Next(15, 36);
    }

    public void MostrarValor()
    {
        Console.WriteLine($"{nombre}: {valor}°C");
    }

    public double ObtenerValor()
    {
        return valor;
    }
}
