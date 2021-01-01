using GerenciadorDespesas.Models;
using GerenciadorDespesas.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.ViewComponents
{
    public class EstatisticasViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;

        public EstatisticasViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            EstatisticasViewModel estatisticas = new EstatisticasViewModel();

            estatisticas.MenorDespesa = _contexto.Despesas.Min(x => x.Valor);
            estatisticas.MaiorDespesa = _contexto.Despesas.Max(x => x.Valor);
            estatisticas.QuantidadeDespesas = _contexto.Despesas.Count();

            return View(estatisticas);
        }
    }
}