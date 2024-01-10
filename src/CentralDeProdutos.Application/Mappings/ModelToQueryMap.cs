using AutoMapper;
using CentralDeProdutos.Application.Queries;
using CentralDeProdutos.Domain.Models;

namespace CentralDeProdutos.Application.Mappings
{
    public class ModelToQueryMap : Profile
    {
        public ModelToQueryMap()
        {
            CreateMap<Categoria, CategoriasQuery>();
            CreateMap<Produto, ProdutosQuery>();
        }
    }
}