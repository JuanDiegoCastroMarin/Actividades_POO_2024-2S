public class Cap3Ejer18
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el código del empleado: ");
        string code = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese el nombre del empleado: ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese el número de horas trabajadas al mes: ");
        decimal hoursWorked = decimal.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el valor de la hora trabajada: ");
        decimal payHourRate = decimal.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el porcentaje (%) de retención en la fuente: ");
        decimal retentionRate = decimal.Parse(Console.ReadLine() ?? "0");
        
        decimal bruteSalary = hoursWorked * payHourRate;
        decimal netSalary = bruteSalary * (1 - (retentionRate/100));
        
        Console.WriteLine(@$"
            Los datos del empleado son: 
            - Código: {code},
            - Nombres: {name},
            - Salario bruto: {hoursWorked},
            - Salario neto: {netSalary}
        ");
    }
}
