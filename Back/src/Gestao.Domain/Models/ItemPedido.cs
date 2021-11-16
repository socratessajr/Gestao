namespace Gestao.Domain.Models
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public double ValorItem { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}