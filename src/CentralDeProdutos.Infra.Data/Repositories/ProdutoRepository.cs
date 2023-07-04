using CentralDeProdutos.Domain.Models;
using CentralDeProdutos.Domain.Ports.Repositories;
using CentralDeProdutos.Infra.Data.Contexts;

namespace CentralDeProdutos.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto, Guid>, IProdutoRepository
    {
        private readonly DataContext? _dataContext;

        public ProdutoRepository(DataContext? dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Produto> GetByCategoria(Guid categoriaId)
        {
            return _dataContext.Produtos.Where(p => p.CategoriaId == categoriaId).ToList();
        }
    }
}