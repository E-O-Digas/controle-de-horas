namespace server.Models{
    public class Empresa{
        public Guid EmpresaId { get; set; }
        public required string Nome { get; set; }

        public Servico? IdServico { get; set; }
        public string? Descricao { get; set; }
    }
}