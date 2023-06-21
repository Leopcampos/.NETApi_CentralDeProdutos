using CentralDeProdutos.Domain.Models;

namespace CentralDeProdutos.Domain.Interfaces
{
    public interface IProdutoDomainService : IBaseDomainService<Produto, Guid>
    {
        List<Produto> GetByCategoria(Guid categoriaId);
    }
}