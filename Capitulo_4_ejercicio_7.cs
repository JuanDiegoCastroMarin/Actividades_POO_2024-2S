public class Cap4Ejer7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor A: ");
        double a = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el valor B: ");
        double b = double.Parse(Console.ReadLine() ?? "0");
        
        if (a > b) Console.Write("A es mayor a B");
        else if (a < b) Console.Write("A es menor a B");
        else Console.Write("A es igual a B");
    }
}
