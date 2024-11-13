public class Cap4Ejer10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número de inscripción: ");
        string inscriptionNumber = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese el nombre: ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese el patrimonio: ");
        double heritage = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el estrato social: ");
        int socialStratum = int.Parse(Console.ReadLine() ?? "0");
        double total = 50_000;
        if (socialStratum > 3 && heritage > 2_000_000) total += 0.03 * heritage;
        
        Console.WriteLine(@$"EL ESTUDIANTE CON NÚMERO DE INSCRIPCIÓN {inscriptionNumber},
            Y NOMBRE {name},
            DEBE PAGAR: ${total}
        ");
    }
}
