using CentralDeProdutos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CentralDeProdutos.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contexto do projeto EF
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Define o banco de dados do projeto
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BDCentralDeProdutos");
        }

        /// <summary>
        /// Unidade de trabalho para categoria
        /// </summary>
        public DbSet<Categoria>? Categorias { get; set; }

        /// <summary>
        /// Unidade de trabalho para produto
        /// </summary>
        public DbSet<Produto>? Produtos { get; set; }
    }
}