using CentralDeProdutos.Domain.Interfaces;
using CentralDeProdutos.Domain.Ports.Repositories;

namespace CentralDeProdutos.Domain.Services
{
    public abstract class BaseDomainService<TEntity, Tkey> : IBaseDomainService<TEntity, Tkey>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity, Tkey>? _baseRepository;

        protected BaseDomainService(IBaseRepository<TEntity, Tkey>? baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual void Add(TEntity entity)
        {
            _baseRepository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _baseRepository.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _baseRepository.Delete(entity);
        }

        public virtual List<TEntity> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public virtual TEntity GetById(Tkey id)
        {
            return _baseRepository.GetById(id);
        }

        public virtual void Dispose()
        {
            _baseRepository.Dispose();
        }
    }
}