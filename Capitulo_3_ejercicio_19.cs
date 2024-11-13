public class Cap3Ejer19
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor del lado del triángulo: ");
        double side = double.Parse(Console.ReadLine() ?? "0");
        double perimeter = side * 3;
        double semiperimeter = perimeter / 2;
        double area = Math.Pow(side, 2) * Math.Sqrt(3) / 4;
        
        Console.WriteLine(@$" 
                    - Perímetro: {perimeter},
                    - Semiperímetro: {semiperimeter},
                    - Área: {area}
                ");
    }
}
