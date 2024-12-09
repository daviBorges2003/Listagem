using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListagemAPi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListagemAPi.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration configurationAppSettings;
        public DbContexto(IConfiguration _configurationAppSettings)
        {
            configurationAppSettings = _configurationAppSettings;
        }
        public DbSet<Administrador> Administradores {get; set;} = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasData(
                new Administrador {
                    Id = 0,
                    Email = "Adm@teste.com",
                    Senha = "123456",
                    Perfil = "Adm"
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var stringConnetion = configurationAppSettings.GetConnectionString("CONNECT")?.ToString();
        
                if(!string.IsNullOrEmpty(stringConnetion))
                {
                    optionsBuilder.UseSqlServer(stringConnetion);
                }
            }
        }
    }
}