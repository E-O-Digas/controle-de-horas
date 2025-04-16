using Microsoft.EntityFrameworkCore;

namespace server.Models{
    [PrimaryKey(nameof(TarefaId))]
    public class Tarefa{
        public Guid TarefaId { get; set; }
        public required string DescricaoTarefa { get; set; }

        public Projeto? Projeto { get; set; }

        public ICollection<SubTarefa>? SubTarefas { get; set; }

        public Recurso? Coordenador { get; set; }

        public required DateTime DataInicio { get; set; }     
        public DateTime? DataFim { get; set; }        
   }
}