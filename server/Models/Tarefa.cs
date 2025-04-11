using Microsoft.EntityFrameworkCore;

namespace server.Models{
    [PrimaryKey(nameof(TarefaId), nameof(IdSubTarefa))]
    public class Tarefa{
        public Guid TarefaId { get; set; }
        public required string DescricaoTarefa { get; set; }

        public required SubTarefa IdSubTarefa { get; set; }
        public string? DescricaoSubTarefa { get; set;}

        public required Recurso IdCoordenador { get; set; }
        public string? NomeCoordenador { get; set;}

        public required DateTime DataInicio { get; set; }     
        public DateTime? DataFim { get; set; }        
   }
}