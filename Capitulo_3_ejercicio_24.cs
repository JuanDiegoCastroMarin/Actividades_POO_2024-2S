class Cap4Ejer24
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el peso de la esfera A: ");
        double pesoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el peso de la esfera B: ");
        double pesoB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el peso de la esfera C: ");
        double pesoC = Convert.ToDouble(Console.ReadLine());

        if (pesoA > pesoB && pesoA > pesoC)
        {
            Console.WriteLine("La esfera A es la de mayor peso.");
        }
        else if (pesoB > pesoA && pesoB > pesoC)
        {
            Console.WriteLine("La esfera B es la de mayor peso.");
        }
        else
        {
            Console.WriteLine("La esfera C es la de mayor peso.");
        }
    }
}
