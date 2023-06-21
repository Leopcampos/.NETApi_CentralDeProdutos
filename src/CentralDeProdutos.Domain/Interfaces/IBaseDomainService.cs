﻿namespace CentralDeProdutos.Domain.Interfaces
{
    public interface IBaseDomainService<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(TKey id);
    }
}