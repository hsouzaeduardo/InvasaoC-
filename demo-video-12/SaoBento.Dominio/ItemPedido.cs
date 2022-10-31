using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaoBento.Dominio
{
    public class ItemPedido : EntidadeBase
    {
        public ItemPedido(Pedido pedido,Produto produto, int quantidade, string descricao, decimal valorUnitario)
        {
            Pedido = pedido;
            Quantidade = quantidade;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            Produto = produto;
        }
        public Produto Produto { get; set; }
        
        public Pedido Pedido { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }

        public decimal ValorTotal
        {
            get => Quantidade * ValorUnitario;
        }
    }
}
