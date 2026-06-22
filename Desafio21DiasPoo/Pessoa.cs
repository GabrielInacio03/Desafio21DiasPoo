using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio21DiasPoo
{
    public class Pessoa
    {
        public Pessoa()
        {
        }
        public int Id { get; set; } //Isso é um atributo, colocando um get e set vc transforma isso em uma propriedade
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
