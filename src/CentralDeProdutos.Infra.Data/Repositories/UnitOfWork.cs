using CentralDeProdutos.Domain.Ports.Repositories;
using CentralDeProdutos.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace CentralDeProdutos.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext? _dataContext;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(DataContext? dataContext, IDbContextTransaction? transaction)
        {
            _dataContext = dataContext;
            _transaction = transaction;
        }

        public void BeginTransaction()
        {
           _transaction = _dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public ICategoriaRepository CategoriaRepository 
            => new CategoriaRepository(_dataContext);

        public IProdutoRepository ProdutoRepository 
            => new ProdutoRepository(_dataContext);

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}