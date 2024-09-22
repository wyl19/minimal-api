using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using minimalApi.Dominio.Entidades;

namespace minimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{
   // private readonly IConfiguration _configuracaoAppSetting;
   public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
            
        }
   public DbSet<Administrador>Administradores{get; set;} = default!;
    public DbSet<Veiculo>Veiculos{get; set;} = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador {
                Id = 1,
                Email= "Administrador@teste.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }


}