using Microsoft.EntityFrameworkCore;

namespace server.Models{
    [PrimaryKey(nameof(IdSubTarefa))]
    public class SubTarefa{
        public Guid IdSubTarefa { get; set; }
        public string? DescricaoSubTarefa { get; set; }

        // public required Guid IdTarefa { get; set; }
        public Tarefa? Tarefa { get; set; }
        // public string? DescricaoTarefa { get; set; }

        // public required Guid IdAnalista { get; set; }
        public Recurso? Analista { get; set; }
        // public string? NomeAnalista { get; set; }

        public required DateTime DataIni { get; set; }
        public DateTime? DataFim { get; set; }

    }
}