using Microsoft.EntityFrameworkCore;

namespace server.Models{
    [PrimaryKey(nameof(ApontamentoId), nameof(IdAnalista), nameof(OS))]
    public class Apontamento{
        public Guid ApontamentoId { get; set; }
        public required string OS { get; set; }
        public required string Descricao { get; set; }

        public required Recurso IdAnalista { get; set; }
        public string? NomeRecusro { get; set; }

        public required string HorasApontadas { get; set; }
        public string? HorasFinalizadas { get; set; }

        public required DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
    
}