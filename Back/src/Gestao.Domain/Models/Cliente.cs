using System;
using System.Collections.Generic;

namespace Gestao.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }
    }
}