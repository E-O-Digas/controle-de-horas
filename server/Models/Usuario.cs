namespace server.Models{
    public class Usuario{
        public Guid UsuarioId { get; set; }
        public Guid IdResponsavel { get; set; }
        public required string Nome { get; set; }
        public char Tipo { get; set; }
    }
}