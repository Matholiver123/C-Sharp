using System;
using ContaCorrente1; // Importa as classes Pessoa, Fisica e Juridica

class Program
{
    static void Main(string[] args)
    {
        // Pessoa Física
        Fisica clienteFisica = new Fisica("Maria", "1234", 0.00, "123.456.789-00");
        Console.WriteLine("Conta Pessoa Física");
        clienteFisica.MostrarSaldo();      
        clienteFisica.Depositar(1500);     
        clienteFisica.Sacar(500);         
        clienteFisica.MostrarSaldo();      

        Console.WriteLine();

        Juridica clienteJuridica = new Juridica("Empresa XYZ", "5678", 0.00, "12.345.678/0001-99");
        Console.WriteLine("Conta Pessoa Jurídica");
        clienteJuridica.MostrarSaldo();    
        clienteJuridica.Depositar(2000);  
        clienteJuridica.Sacar(1000);      
        clienteJuridica.MostrarSaldo();    

        Console.ReadLine();
    }
}
