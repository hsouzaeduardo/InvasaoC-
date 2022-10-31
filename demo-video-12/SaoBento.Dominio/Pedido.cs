using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaoBento.Dominio
{
    public class Pedido : EntidadeBase
    {
        public List<ItemPedido>? Items { get; set; }
        public DateTime Data { get; set; }
        public string? Cliente { get; set; }
        public Mesa? Mesa { get; set; }
        public Functionario? Funcionario { get; set; }
        public Guid PagarConta(string formaPagamento) 
            =>  Pagamento.PagarConta(this, formaPagamento);
    }
}
