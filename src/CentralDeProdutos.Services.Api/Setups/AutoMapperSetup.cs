namespace CentralDeProdutos.Services.Api.Setups
{
    /// <summary>
    /// Configuração para o AutoMapper
    /// </summary>
    public class AutoMapperSetup
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}