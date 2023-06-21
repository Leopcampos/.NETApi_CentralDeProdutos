using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Queries;

namespace CentralDeProdutos.Application.Ports
{
    public interface ICategoriaAppService : IDisposable
    {
        CategoriasQuery Add(CreateCategoriaCommand command);
        CategoriasQuery Update(UpdateCategoriaCommand command);
        CategoriasQuery Delete(DeleteCategoriaCommand command);

        List<CategoriasQuery> GetAll();
        CategoriasQuery GetById(Guid? id);
    }
}