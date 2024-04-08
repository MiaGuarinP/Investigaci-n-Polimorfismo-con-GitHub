using System;

public abstract class FiguraGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularDiametro();
}

// Clase para círculo
public class Circulo : FiguraGeometrica
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    public override double CalcularDiametro()
    {
        return 2 * Radio;
    }
}

// Clase para cuadrado
public class Cuadrado : FiguraGeometrica
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Math.Pow(Lado, 2);
    }

    public override double CalcularDiametro()
    {
        return Math.Sqrt(2) * Lado;
    }
}

// Clase para triángulo
public class Triangulo : FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double bas, double altura)
    {
        Base = bas;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public override double CalcularDiametro()
    {
        // En un triángulo el diámetro no tiene sentido, así que se devuelve 0
        return 0;
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso del polimorfismo
        FiguraGeometrica circulo = new Circulo(5);
        FiguraGeometrica cuadrado = new Cuadrado(4);
        FiguraGeometrica triangulo = new Triangulo(3, 6);

        Console.WriteLine("Área y Diámetro de Figuras Geométricas:");
        Console.WriteLine("Círculo:");
        Console.WriteLine($"Área: {circulo.CalcularArea()}, Diámetro: {circulo.CalcularDiametro()}");
        Console.WriteLine("Cuadrado:");
        Console.WriteLine($"Área: {cuadrado.CalcularArea()}, Diámetro: {cuadrado.CalcularDiametro()}");
        Console.WriteLine("Triángulo:");
        Console.WriteLine($"Área: {triangulo.CalcularArea()}, Diámetro: {triangulo.CalcularDiametro()}");
    }
}
