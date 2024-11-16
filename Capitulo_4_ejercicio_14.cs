class Cap4Ejer14
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las ventas del departamento 1:");
        decimal ventasDepto1 = decimal.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese las ventas del departamento 2:");
        decimal ventasDepto2 = decimal.Parse(Console.ReadLine() ?? "0");
        
        Console.WriteLine("Ingrese las ventas del departamento 3:");
        decimal ventasDepto3 = decimal.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el salario mensual de los vendedores:");
        decimal salarioBase = decimal.Parse(Console.ReadLine() ?? "0");

        decimal totalVentas = ventasDepto1 + ventasDepto2 + ventasDepto3;
        decimal porcentajeVentas = totalVentas * 0.33m;

        decimal salarioDepto1 = ventasDepto1 > porcentajeVentas
            ? salarioBase + salarioBase * 0.2m
            : salarioBase;

        decimal salarioDepto2 = ventasDepto2 > porcentajeVentas
            ? salarioBase + salarioBase * 0.2m
            : salarioBase;

        decimal salarioDepto3 = ventasDepto3 > porcentajeVentas
            ? salarioBase + salarioBase * 0.2m
            : salarioBase;

        Console.WriteLine($"\nSalario de los vendedores por departamento:");
        Console.WriteLine($"- Departamento 1: ${salarioDepto1:F2}");
        Console.WriteLine($"- Departamento 2: ${salarioDepto2:F2}");
        Console.WriteLine($"- Departamento 3: ${salarioDepto3:F2}");
    }
}

