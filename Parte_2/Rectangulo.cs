public class Rectangulo
{
    // Atributo que define la base de un rectángulo
    int baseRectangulo;
    
    // Atributo que define la altura de un rectángulo
    int altura;

    // Constructor de la clase Rectangulo
    public Rectangulo(int baseRectangulo, int altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    // Método que calcula y devuelve el área de un rectángulo
    // como la multiplicación de la base por la altura
    public double CalcularArea()
    {
        return baseRectangulo * altura;
    }

    // Método que calcula y devuelve el perímetro de un rectángulo
    // como (2 * base) + (2 * altura)
    public double CalcularPerimetro()
    {
        return (2 * baseRectangulo) + (2 * altura);
    }
}
