using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Queries;

namespace CentralDeProdutos.Application.Ports
{
    public interface IProdutoAppService : IDisposable
    {
        ProdutosQuery Add(CreateProdutoCommand command);
        ProdutosQuery Update(UpdateProdutoCommand command);
        ProdutosQuery Delete(DeleteProdutoCommand command);

        List<ProdutosQuery> GetByCategoria(Guid? idCategoria);
        ProdutosQuery GetById(Guid? id);
    }
}