public class Cuadrado
{
    // Atributo que define el lado de un cuadrado
    int lado;

    // Constructor de la clase Cuadrado
    public Cuadrado(int lado)
    {
        this.lado = lado;
    }

    // Método que calcula y devuelve el �rea de un cuadrado como el
    // lado elevado al cuadrado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método que calcula y devuelve el per�metro de un cuadrado como
    // cuatro veces su lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
