Console.WriteLine("SISTEMA DE MOTOR");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura del motor: ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor: ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Solicitar al objeto que verifique la temperatura
string estado = motor1.VerificarTemperatura();

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura} °C");
Console.WriteLine($"Velocidad: {motor1.Velocidad} rpm");
Console.WriteLine($"Estado: {estado}");

// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Velocidad { get; set; }

    // Método para determinar el estado
    public string VerificarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "TEMPERATURA ALTA";
        }
        else
        {
            return "Temperatura normal";
        }
    }
}
