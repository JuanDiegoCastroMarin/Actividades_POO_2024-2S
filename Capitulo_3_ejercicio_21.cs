public class Cap3Ejer21
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor del primer lado del triángulo: ");
        double firstSide = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el valor del segundo lado del triángulo: ");
        double secondSide = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el valor del tercer lado del triángulo: ");
        double thirdSide = double.Parse(Console.ReadLine() ?? "0");
        double perimeter = firstSide + secondSide + thirdSide;
        double semiperimeter = perimeter / 2;
        double area = Math.Sqrt(
            semiperimeter * 
            (semiperimeter - firstSide) *
            (semiperimeter - secondSide) * 
            (semiperimeter - thirdSide)
        );
        
        Console.WriteLine(@$" 
                    - Perímetro: {perimeter},
                    - Semiperímetro: {semiperimeter},
                    - Área: {area}
                ");
    }
}
