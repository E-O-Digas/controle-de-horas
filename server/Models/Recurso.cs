namespace server.Models{
    public class Recurso{
        public Guid RecursoId { get; set; }
        public required string Nome { get; set; }
        public required string Tipo { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }

        public ICollection<Projeto>? Projetos { get; set; }
        public ICollection<Tarefa>? Tarefas { get; set; }
        public ICollection<SubTarefa>? SubTarefas { get; set; }
        public ICollection<Apontamento>? Apontamentos { get; set; }
        
    }
}