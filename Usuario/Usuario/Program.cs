using System;

namespace Usuario
{
    class Usuario
    {
        //atributos
        public string nome;
        public string email;
        public string login;
        public string senha;

        //método especifico da classe
        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu existo!");
        }
        static void Main(string[] args)
        {
            //método construtor
            //NomeDaClasse | nomeDaInstancia | = |comando new | método construtor 
            Usuario u1 = new Usuario();

            //invocar o método provarExistencia
            //nomeDaIntancia.nomeDoMétodo();
            u1.provarExistencia();

            //inserindo dados no objeto (instância)
            //nomeDaInstãcia.atributo = dados;
            u1.nome = "Matheus Oliveira";
            u1.email = "e@e";
            u1.login = "matheus";
            u1.senha = "123";

            //exibindo os dados do objeto
            //Console.WriteLine(nomeDainstância.atributo)
            Console.WriteLine(u1.nome);
            Console.WriteLine(u1.email);
            Console.WriteLine(u1.login);
            Console.WriteLine(u1.senha);
        }
    }
}