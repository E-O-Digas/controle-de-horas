namespace server.Models{
    public class SubTarefa{
        public Guid IdSubTarefa { get; set; }
        public string? DescricaoSubTarefa { get; set; }

        public required Tarefa IdTarefa { get; set; }
        public string? DescricaoTarefa { get; set; }

        public required Recurso IdAnalista { get; set; }
        public string? NomeAnalista { get; set; }

        public required DateTime DataIni { get; set; }
        public DateTime? DataFim { get; set; }

    }
}