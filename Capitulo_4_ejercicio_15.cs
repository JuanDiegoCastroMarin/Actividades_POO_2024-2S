class Cap4Ejer15
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el peso de la esfera A:");
        int pesoA = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el peso de la esfera B:");
        int pesoB = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el peso de la esfera C:");
        int pesoC = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingrese el peso de la esfera D:");
        int pesoD = int.Parse(Console.ReadLine() ?? "0");

        if (pesoA == pesoB && pesoA == pesoC)
        {
            if (pesoD > pesoA)
            {
                Console.WriteLine("La esfera D es la diferente y es de mayor peso.");
            }
            else
            {
                Console.WriteLine("La esfera D es la diferente y es de menor peso.");
            }
        }
        else if (pesoA == pesoB && pesoA == pesoD)
        {
            if (pesoC > pesoA)
            {
                Console.WriteLine("La esfera C es la diferente y es de mayor peso.");
            }
            else
            {
                Console.WriteLine("La esfera C es la diferente y es de menor peso.");
            }
        }
        else if (pesoA == pesoC && pesoA == pesoD)
        {
            if (pesoB > pesoA)
            {
                Console.WriteLine("La esfera B es la diferente y es de mayor peso.");
            }
            else
            {
                Console.WriteLine("La esfera B es la diferente y es de menor peso.");
            }
        }
        else
        {
            if (pesoA > pesoB)
            {
                Console.WriteLine("La esfera A es la diferente y es de mayor peso.");
            }
            else
            {
                Console.WriteLine("La esfera A es la diferente y es de menor peso.");
            }
        }
    }
}

