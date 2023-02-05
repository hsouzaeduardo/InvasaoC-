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

        public decimal Valor { get; private set; }
        public string? Forma { get; private set; }
        public bool ContaPaga { get; private set; }
        public Pedido? Pedido { get; private set; }
        public string FormaPagamento { get; }
        public static Guid PagarConta(Pedido pedido, string formaPagamento)
        {
             var pagamento = new Pagamento(pedido.Items.Sum(i => i.ValorTotal), formaPagamento, true);
            return pagamento.Id;
        }
    }
}