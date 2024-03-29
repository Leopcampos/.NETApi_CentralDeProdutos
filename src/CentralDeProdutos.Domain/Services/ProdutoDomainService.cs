﻿using CentralDeProdutos.Domain.Interfaces;
using CentralDeProdutos.Domain.Models;
using CentralDeProdutos.Domain.Ports.Repositories;

namespace CentralDeProdutos.Domain.Services
{
    public class ProdutoDomainService 
        : BaseDomainService<Produto, Guid>, IProdutoDomainService
    {
        private readonly IUnitOfWork? _unitOfWork;

        public ProdutoDomainService(IUnitOfWork? unitOfWork)
            : base(unitOfWork.ProdutoRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Produto> GetByCategoria(Guid categoriaId)
        {
            return _unitOfWork.ProdutoRepository.GetByCategoria(categoriaId);
        }
    }
}