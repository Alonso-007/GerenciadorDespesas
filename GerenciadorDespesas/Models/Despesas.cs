using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Models
{
    public class Despesas
    {
        public int DespesaId { get; set; }
        public int MesId { get; set; }
        public Meses Meses { get; set; }
        public int TipoDespesaId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor invalido")]
        public double Valors{ get; set; }
    }
}
