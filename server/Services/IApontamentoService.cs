using server.Models;

namespace server.Services
{
    public interface IApontamentoService
    {
        Task CriarApontamento(Apontamento Apontamento);
        Task AtualizarApontamento(Apontamento Apontamento);
        Task DeletarApontamento(Apontamento Apontamento);

        Task<IEnumerable<Apontamento>> ObterTodosApontamentos();
        Task<IEnumerable<Apontamento>> ObterApontamentoPorNome(string nome);
        Task<IEnumerable<Apontamento>> ObterApontamentoPorOS(string OS);
        
        Task<IEnumerable<Apontamento>> ObterApontamentosPorDataInicio(DateTime dataIni, DateTime dataFim);
    }
}