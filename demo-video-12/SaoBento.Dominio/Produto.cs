using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaoBento.Dominio
{
    public class Produto
    {
        public Produto(string nome
        , string descricao
        , string categoria
        , string imagem = "")
        {
            Nome = nome;
            Descricao = descricao;
            Categoria = categoria;
            Imagem = imagem;

        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Imagem { get; set; }
        public decimal Preco { get; set; }
        
        
    }
}
