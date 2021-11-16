namespace Gestao.Domain.Models
{
    public class ItemInsumo
    {
        public int ItemInsumoId { get; set; }
        public Insumo Insumo { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Custo { get; set; }
    }
}