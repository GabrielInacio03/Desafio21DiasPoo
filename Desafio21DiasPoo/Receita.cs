using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio21DiasPoo
{
    public class Receita
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set; }
        public float Peso { get; set; }
        public float Preco { get; set; }

        public Receita() { }
        public Receita(string nome, string descricao, string tamanho, float peso, float preco)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Tamanho = tamanho ?? throw new ArgumentNullException(nameof(tamanho));
            Peso = peso;
            Preco = preco;
        }

        //funções
        public void Salvar()
        {
            //Salvando receit
        }
        
        public override string ToString()
        {
            string exibir = string.Empty;
            exibir = $"Receita {this.Nome}, sendo {this.Descricao} no tamanho {this.Tamanho} e seu peso {this.Peso}Kg";
            return exibir;
        }
    }
}
