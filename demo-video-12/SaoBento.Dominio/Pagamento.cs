namespace SaoBento.Dominio
{
    public class Pagamento : EntidadeBase
    {
        public Pagamento(decimal valor, string formaPagamento, bool contaPaga)
        {
            Valor = Valor;
            FormaPagamento = formaPagamento;
            ContaPaga = contaPaga;
        }

        public decimal Valor { get; set; }
        public string? Forma { get; set; }
        public bool ContaPaga { get; set; }
        public Pedido? Pedido { get; set; }
        public decimal V1 { get; }
        public string FormaPagamento { get; }
        public bool V2 { get; }

        public static Guid PagarConta(Pedido pedido, string formaPagamento)
        {
             var pagamento = new Pagamento(pedido.Items.Sum(i => i.ValorTotal), formaPagamento, true);
            return pagamento.Id;
        }
    }
}