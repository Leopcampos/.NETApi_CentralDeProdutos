namespace CentralDeProdutos.Application.Commands
{
    public class UpdateProdutoCommand
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? CategoriaId { get; set; }
    }
}