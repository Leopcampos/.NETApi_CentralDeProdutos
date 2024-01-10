using CentralDeProdutos.Domain.Models;

namespace CentralDeProdutos.Domain.Ports.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto, Guid>
    {
        List<Produto> GetByCategoria(Guid categoriaId);
    }
}