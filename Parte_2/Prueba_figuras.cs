public class PruebaFiguras
{
    // Método main que crea un círculo, un rectángulo, un cuadrado y un triángulo rectángulo.
    // Para cada uno de estas figuras geométricas, se calcula su área y perímetro.
    public static void Main(string[] args)
    {
        // Crear objetos de cada figura con sus respectivos parámetros
        Circulo figura1 = new Circulo(2);
        Rectangulo figura2 = new Rectangulo(1, 2);
        Cuadrado figura3 = new Cuadrado(3);
        TrianguloRectangulo figura4 = new TrianguloRectangulo(3, 5);

        // Calcular y mostrar el área y perímetro de cada figura
        Console.WriteLine("El área del círculo es = " + figura1.CalcularArea());
        Console.WriteLine("El perímetro del círculo es = " + figura1.CalcularPerimetro());
        Console.WriteLine();

        Console.WriteLine("El área del rectángulo es = " + figura2.CalcularArea());
        Console.WriteLine("El perímetro del rectángulo es = " + figura2.CalcularPerimetro());
        Console.WriteLine();

        Console.WriteLine("El área del cuadrado es = " + figura3.CalcularArea());
        Console.WriteLine("El perímetro del cuadrado es = " + figura3.CalcularPerimetro());
        Console.WriteLine();

        Console.WriteLine("El área del triángulo es = " + figura4.CalcularArea());
        Console.WriteLine("El perímetro del triángulo es = " + figura4.CalcularPerimetro());
        
        // Determinar el tipo de triángulo
        figura4.DeterminarTipoTriangulo();
    }
}
