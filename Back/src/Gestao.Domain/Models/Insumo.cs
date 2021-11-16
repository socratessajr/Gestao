using Gestao.Domain.Models.Enums;

namespace Gestao.Domain.Models
{
    public class Insumo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public eUnidadeMedida UnidadeMedida { get; set; }
        public eTipoInsumo Tipo { get; set; }
    }
}