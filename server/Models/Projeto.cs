using Microsoft.EntityFrameworkCore;

namespace server.Models{
    [PrimaryKey(nameof(ProjetoId), nameof(IdCliente))]
    public class Projeto{
        public Guid ProjetoId { get; set; }
        public string? Descricao { get; set; }
        public required string Nome { get; set; }

        public required Tarefa IdTarefa { get; set; }
        public string? DescricaoTarefa { get; set; }

        public required Recurso IdGerente { get; set; }
        public string? NomeGerente { get; set; }
        
        public required Cliente IdCliente { get; set; }
        public string? EmailCliente { get; set; }

        public required DateTime DataIni { get; set; }
        public DateTime? DataFim { get; set; }

    }
}