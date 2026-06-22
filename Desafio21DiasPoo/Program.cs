using System;

namespace Desafio21DiasPoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa gabriel = new Pessoa();
            gabriel.Id = 1;
            gabriel.Nome = "Gabriel";
            gabriel.Endereco = "BRASIL SP";

            Pessoa mariaJulia = new Pessoa();
            mariaJulia.Id = 2;
            mariaJulia.Nome = "Maria Julia";
            mariaJulia.Endereco = "BRASIL SP";
            Console.WriteLine("Hello World!");

            Pessoa sofia = new Pessoa();
            sofia.Id = 3;
            sofia.Nome = "Sofia";
            sofia.Endereco = "BRASIL SP";
        }
    }
}