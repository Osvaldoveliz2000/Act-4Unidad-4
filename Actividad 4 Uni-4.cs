using System;

// Definición de la interfaz
public interface IAnimal
{
    void hacerSonido();
}

// Definición de la clase que implementa la interfaz
public class Perro : IAnimal
{
    public void hacerSonido()
    {
        Console.WriteLine("El perro está ladrando.");
    }
}

// Uso de la interfaz para implementar el polimorfismo
public class Program
{
    static void Main(string[] args)
    {
        IAnimal miAnimal;

        miAnimal = new Perro();
        miAnimal.hacerSonido();
    }
}
