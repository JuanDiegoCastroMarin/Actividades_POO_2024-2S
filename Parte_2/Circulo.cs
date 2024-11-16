public class Circulo
{
    // Atributo que define el radio de un círculo
    int radio;

    // Constructor de la clase Círculo
    public Circulo(int radio)
    {
        this.radio = radio;
    }

    // Método que calcula y devuelve el área de un círculo
    // como pi multiplicado por el radio al cuadrado
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // Método que calcula y devuelve el perímetro de un círculo
    // como la multiplicación de pi por el radio por 2
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
