class Cap4Ejer23
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el valor de A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        if (A == 0)
        {
            Console.WriteLine("No es una ecuación de segundo grado.");
        }
        else
        {
            double D = Math.Pow(B, 2) - 4 * A * C;

            if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-B - Math.Sqrt(D)) / (2 * A);
                Console.WriteLine($"Dos soluciones reales: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -B / (2 * A);
                Console.WriteLine($"Una solución real: x = {x}");
            }
            else
            {
                double parteReal = -B / (2 * A);
                double parteImaginaria = Math.Sqrt(-D) / (2 * A);
                Console.WriteLine($"Dos soluciones complejas: {parteReal} + {parteImaginaria}i, {parteReal} - {parteImaginaria}i");
            }
        }
    }
}