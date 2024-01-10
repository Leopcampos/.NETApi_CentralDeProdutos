namespace CentralDeProdutos.Application.Commands
{
    public class CreateProdutoCommand
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? CategoriaId { get; set; }
    }
}