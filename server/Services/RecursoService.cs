using Microsoft.EntityFrameworkCore;
using server.Db;
using server.Models;

namespace server.Services
{
    public class RecursoService : IRecursoService
    {
        private readonly AppDbContext dbContext;

        public RecursoService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        public async Task CriarRecurso(Recurso recurso)
        {
            dbContext.Recursos.Add(recurso);
            await dbContext.SaveChangesAsync();
        }
        public async Task AtualizarRecurso(Recurso recurso)
        {
            dbContext.Entry(recurso).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }
        public async Task DeletarRecurso(Recurso recurso)
        {
            dbContext.Recursos.Remove(recurso);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Recurso>> ObterTodosRecursos()
        {
            return await dbContext.Recursos.ToListAsync();

        }

        // public async Task<Recurso> ObterRecursoPorId(Guid Id)
        // {
        //     return await dbContext.Recursos.FindAsync(Id);
        // }

        // public async Task<IEnumerable<Recurso>> ObterRecursoPorEmail(string Email)
        // {
        //     IEnumerable<Recurso> recursos;

        //     if (!string.IsNullOrWhiteSpace(Email))
        //     {
        //         recursos = await dbContext.Recursos.Where(r => r.Email.Contains(Email)).ToListAsync();

        //     }
        //     else
        //     {
        //         recursos = await ObterTodosRecursos();
        //     }

        //     return recursos;
        // }

    
        // public async Task<IEnumerable<Recurso>> ObterRecursoPorNome(string Nome)
        // {
        //     IEnumerable<Recurso> recursos;

        //     if (!string.IsNullOrWhiteSpace(Nome))
        //     {
        //         recursos = await dbContext.Recursos.Where(r => r.Nome.Contains(Nome)).ToListAsync();

        //     }
        //     else
        //     {
        //         recursos = await ObterTodosRecursos();
        //     }

        //     return recursos;
        // }

        // public async Task<IEnumerable<Recurso>> ObterRecursoPorTelefone(string Telefone)
        // {
        //     IEnumerable<Recurso> recursos;

        //     if (!string.IsNullOrWhiteSpace(Telefone))
        //     {
        //         recursos = await dbContext.Recursos.Where(r => r.Telefone.Contains(Telefone)).ToListAsync();

        //     }
        //     else
        //     {
        //         recursos = await ObterTodosRecursos();
        //     }

        //     return recursos;
        // }

        // public async Task<IEnumerable<Recurso>> ObterRecursoPorTipo(string Tipo)
        // {
        //     IEnumerable<Recurso> recursos;

        //     if (!string.IsNullOrWhiteSpace(Tipo))
        //     {
        //         recursos = await dbContext.Recursos.Where(r => r.Tipo.Contains(Tipo)).ToListAsync();

        //     }
        //     else
        //     {
        //         recursos = await ObterTodosRecursos();
        //     }

        //     return recursos;
        // }

        
    }

}