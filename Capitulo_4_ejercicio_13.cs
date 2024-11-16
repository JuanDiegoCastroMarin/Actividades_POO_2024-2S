class Cap4Ejer13
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor de la compra:");
        decimal valorCompra = decimal.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Ingrese el color de la bolita Blanco|Verde|Amarillo|Azul|Roja):");
        string colorBolita = Console.ReadLine()?.ToLower() ?? string.Empty;
        decimal porcentajeDescuento = colorBolita switch
        {
            "blanco" => 0,
            "verde" => 10,
            "amarillo" => 25,
            "azul" => 50,
            _ => 100
        };

        decimal valorPagar = valorCompra - (porcentajeDescuento * valorCompra / 100);

        Console.WriteLine($"El cliente debe pagar: ${valorPagar:F2}");
    }
}

