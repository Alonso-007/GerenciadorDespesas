using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Models
{
    public class TipoDespesas
    {
        public int TipoDespesaId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [StringLength(50,ErrorMessage = "Use menos caracteres.")]
        public string Nome { get; set; }
        public ICollection<Despesas> Despesas { get; set; }
    }
}
