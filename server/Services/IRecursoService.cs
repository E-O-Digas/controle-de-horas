using server.Models;

namespace server.Services
{
    public interface IRecursoService
    {
        Task CriarRecurso(Recurso recurso);
        Task AtualizarRecurso(Recurso recurso);
        Task DeletarRecurso(Recurso recurso);

        Task<List<Recurso>> ObterTodosRecursos();
        // Task<Recurso> ObterRecursoPorId(Guid id);

        // Task<IEnumerable<Recurso>> ObterRecursoPorNome(string nome);
        // Task<IEnumerable<Recurso>> ObterRecursoPorEmail(string email);
        // Task<IEnumerable<Recurso>> ObterRecursoPorTelefone(string telefone);
        // Task<IEnumerable<Recurso>> ObterRecursoPorTipo(string tipo);
    }
}