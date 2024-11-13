public class Cap4Ejer11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        int first = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el segundo número:");
        int second = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el tercer número:");
        int third = int.Parse(Console.ReadLine() ?? "0");
        int greatest;
        if (first > second && first > third) greatest = first;
        else if (second > first && second > third) greatest = second;
        else greatest = third;
        
        Console.WriteLine(@$"EL VALOR MAYOR ENTRE: {first}, {second} Y {third} ES: {greatest}");
    }
}
