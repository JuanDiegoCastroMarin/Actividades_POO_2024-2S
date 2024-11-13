public class Cap4Ejer12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del trabajador:");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese el número de horas trabajadas:");
        decimal hours = decimal.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el valor de la hora trabajada:");
        decimal payRate = decimal.Parse(Console.ReadLine() ?? "0");
        decimal extraHours = hours - 40;
        decimal total;
        if (hours > 40)
        {
            total = payRate * 40;
            if (extraHours > 8) 
                total += (2 * payRate * 8) + (3 * (extraHours - 8) * payRate);
            else total += 2 * payRate * extraHours;
        }
        else total = payRate * hours;
        
        
        Console.WriteLine(@$"EL TRABAJADOR {name} DEVENGÓ: ${total}");
    }
}
