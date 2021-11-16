using System;
using System.Collections.Generic;
using Gestao.Domain.Models.Enums;

namespace Gestao.Domain.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public eStatusPedido Status { get; set; } 
        public bool RequerEntrada { get; set; }
        public IEnumerable<Pagamento> Pagamentos { get; set; }
        public IEnumerable<ItemPedido> Itens { get; set; }
    }
}