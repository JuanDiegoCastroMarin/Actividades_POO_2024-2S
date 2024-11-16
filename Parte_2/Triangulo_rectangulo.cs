using System;

public class TrianguloRectangulo
{
    // Atributo que define la base de un triángulo rectángulo
    int base;

    // Atributo que define la altura de un triángulo rectángulo
    int altura;

    // Constructor de la clase TriánguloRectángulo
    public TrianguloRectangulo(int base, int altura)
    {
        this.base = base;
        this.altura = altura;
    }

    // Método que calcula y devuelve el área de un triángulo rectángulo
    // como la base multiplicada por la altura sobre 2
    public double CalcularArea()
    {
        return (base * altura / 2.0);
    }

    // Método que calcula y devuelve el perímetro de un triángulo rectángulo
    // como la suma de la base, la altura y la hipotenusa
    public double CalcularPerimetro()
    {
        return (base + altura + CalcularHipotenusa());
    }

    // Método que calcula la hipotenusa de un triángulo rectángulo
    // utilizando el teorema de Pitágoras
    public double CalcularHipotenusa()
    {
        return Math.Pow((base * base) + (altura * altura), 0.5);
    }

    // Método que determina el tipo de triángulo:
    // - Equilátero: si sus tres lados son iguales
    // - Escaleno: si sus tres lados son diferentes
    // - Isósceles: si dos de sus lados son iguales y el otro es diferente
    public void DeterminarTipoTriangulo()
    {
        // Calculamos la hipotenusa
        double hipotenusa = CalcularHipotenusa();

        // Comprobamos el tipo de triángulo
        if ((base == altura) && (base == hipotenusa) && (altura == hipotenusa))
        {
            Console.WriteLine("Es un triángulo equilátero"); // Todos sus lados son iguales
        }
        else if ((base != altura) && (base != hipotenusa) && (altura != hipotenusa))
        {
            Console.WriteLine("Es un triángulo escaleno"); // Todos sus lados son diferentes
        }
        else
        {
            Console.WriteLine("Es un triángulo isósceles"); // Dos lados son iguales
        }
    }
}
