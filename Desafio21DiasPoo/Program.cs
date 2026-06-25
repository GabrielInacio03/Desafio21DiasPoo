using System;

namespace Desafio21DiasPoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RECEITA de BOLO
            Receita boloDeChocolate = new Receita();
            boloDeChocolate.Nome = "BOLO DE CHOCOLATE";
            boloDeChocolate.Descricao = "Bolo pequeno de chocolate";
            boloDeChocolate.Tamanho = "P";
            boloDeChocolate.Peso = 0.25f;
            boloDeChocolate.Preco = 8.99f;

            Receita temaki = new Receita();
            temaki.Nome = "TEMAKI FRITO";
            temaki.Descricao = "temaki frito com cream";
            temaki.Tamanho = "M";
            temaki.Peso = 0.5f;
            temaki.Preco = 29.99f;


            Receita frangoFrito = new Receita();
            frangoFrito.Nome = "FRANGO FRITO";
            frangoFrito.Descricao = "frango frito com acompanhamento de batata";
            frangoFrito.Tamanho = "G";
            frangoFrito.Peso = 0.25f;
            frangoFrito.Preco = 8.99f;

            Console.WriteLine(boloDeChocolate.ToString());
            Console.WriteLine(temaki.ToString());
            Console.WriteLine(frangoFrito.ToString());
        }
    }
}