using System;
using System.Collections.Generic;
using Gestao.Domain.Models.Enums;

namespace Gestao.Domain.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public eTipoProduto Tipo { get; set; }
        //public IEnumerable<ItemInsumo> Insumos { get; set; }
        public double Valor { get; set; }
        public double Custo { get; set; }
        public double ValorPromocional { get; set; }
        public double QuantidadePromocional { get; set; }
        public DateTime DataReferencia { get; set; }
        public bool Ativo { get; set; }
        public virtual List<ItemPedido> ItensPedidos { get; set; }
    }
}