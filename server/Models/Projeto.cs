using Microsoft.EntityFrameworkCore;

namespace server.Models{
    [PrimaryKey(nameof(ProjetoId))]
    public class Projeto{
        public Guid ProjetoId { get; set; }
        public string? Descricao { get; set; }
        public required string Nome { get; set; }

        public ICollection<Tarefa>? Tarefas { get; set; }

        // public required Guid IdGerente { get; set; }
        public Recurso? Gerente { get; set; }
        // public string? NomeGerente { get; set; }
        
        // public required Guid IdCliente { get; set; }        
        public Cliente? Cliente { get; set; }
        // public string? EmailCliente { get; set; }

        public required DateTime DataIni { get; set; }
        public DateTime? DataFim { get; set; }

    }
}