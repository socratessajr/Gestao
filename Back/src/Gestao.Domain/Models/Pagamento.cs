using System;
using Gestao.Domain.Models.Enums;

namespace Gestao.Domain.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public eMetodoPagamento Metodo { get; set; }
        public DateTime Data { get; set; }
        public bool Entrada { get; set; }
        public Pedido Pedido { get; set; }
    }
}