using System;
/*
 public class ClasseBase
 {
 public void MetodoBase()
 {
 Console.WriteLine(" Método da classe base ") ;
 }
 }

 public class ClasseDerivada : ClasseBase { 
 // Herda MetodoBase ()
 }


public class Animal
{
protected string Nome { get; set; }
    protected void FazerSom()
{
        Console.WriteLine("Som genérico de animal ") ;
}
}

 public class Cachorro : Animal
{
    public void Latir()
 {
 Nome = "Rex ";
 FazerSom();
 Console.WriteLine("Au au!");
 }
}

public abstract class Animal
{
    public abstract void FazerSom();
}

public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}

public sealed class ClasseSelada
 {
    // Não pode ser herdada
}

public class Animal
{
public string Nome { get; set; }

public Animal(string nome)
{
Nome = nome ;
}
 }


 public class Cachorro : Animal
 {
 public Cachorro(string nome) : base(nome)
 {
 }
 }
 


public class Veiculo
{
    public string Marca { get; set; }
    
    protected int VelocidadeMaxima { get; set; }

    public Veiculo(string marca, int velocidadeMaxima)
    {
        Marca = marca;
        VelocidadeMaxima = velocidadeMaxima;
    }

    public virtual void ExibirDescricao()
    {
        Console.WriteLine($"Veículo da marca {Marca}, velocidade máxima: {VelocidadeMaxima} km/h");
    }

    public int GetVelocidadeMaxima()
    {
        return VelocidadeMaxima;
    }
}

public class Carro : Veiculo
{
    public int Portas { get; set; }

    public Carro(string marca, int velocidadeMaxima, int portas)
        : base(marca, velocidadeMaxima)
    {
        Portas = portas;
    }

    public override void ExibirDescricao()
    {
       
        Console.WriteLine($"Carro da marca {Marca}, velocidade máxima: {GetVelocidadeMaxima()} km/h, portas: {Portas}");
    }
}

class Program
{
    static void Main()
    {
        Veiculo veiculo = new Veiculo("Toyota", 180);
        Carro carro = new Carro("Honda", 200, 4);

        veiculo.ExibirDescricao();
        carro.ExibirDescricao();
    }
}
*/

public class Animal
{
    public string Nome { get; set; }
}

public interface IVoador
{
    void Voar();
}

public class Passaro : Animal, IVoador
{
    public void Voar()
    {
        Console.WriteLine("Pássaro voando!");
    }
}
