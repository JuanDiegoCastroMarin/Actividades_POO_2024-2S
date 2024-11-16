class Cap4Ejer22
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el salario por hora:");
        decimal salarioPorHora = decimal.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el número de horas trabajadas en el mes:");
        int horasTrabajadas = int.Parse(Console.ReadLine() ?? "0");

        decimal salarioMensual = salarioPorHora * horasTrabajadas;

        if (salarioMensual > 450000)
        {
            Console.WriteLine($"Nombre del empleado: {nombre}");
            Console.WriteLine($"Salario Mensual: ${salarioMensual}");
        }
        else
        {
            Console.WriteLine($"Nombre del empleado: {nombre}");
        }
    }
}
