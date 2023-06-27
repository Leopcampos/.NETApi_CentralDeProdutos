using CentralDeProdutos.Domain.Ports.Repositories;

namespace CentralDeProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Classe base dos reposit[orios
    /// </summary>
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        public virtual void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}