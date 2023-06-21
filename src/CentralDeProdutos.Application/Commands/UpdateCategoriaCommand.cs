namespace CentralDeProdutos.Application.Commands
{
    public class UpdateCategoriaCommand
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
    }
}