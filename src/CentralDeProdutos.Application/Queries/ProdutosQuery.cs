namespace CentralDeProdutos.Application.Queries
{
    public class ProdutosQuery
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }

        public CategoriasQuery? Categoria { get; set; }
    }
}