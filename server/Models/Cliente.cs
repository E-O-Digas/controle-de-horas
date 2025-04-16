namespace server.Models{
    public class Cliente{
        public Guid ClienteId { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }

        // public required Guid IdEmpresa { get; set; }
        public Empresa? Empresa { get; set; }
        // public string? NomeEmpresa { get; set; } 
    }
}