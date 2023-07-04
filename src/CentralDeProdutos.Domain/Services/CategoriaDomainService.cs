using CentralDeProdutos.Domain.Interfaces;
using CentralDeProdutos.Domain.Models;
using CentralDeProdutos.Domain.Ports.Repositories;

namespace CentralDeProdutos.Domain.Services
{
    public class CategoriaDomainService : BaseDomainService<Categoria, Guid>, ICategoriaDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriaDomainService(IUnitOfWork unitOfWork) : base(unitOfWork.CategoriaRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}