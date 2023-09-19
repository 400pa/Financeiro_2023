using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuração
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {

        public ContextBase( DbContextOptions options) : base( options ) 
        {
            
        }


        public DbSet<SistemaFinanceiro> SistemaFinanceiro { get; set; }
        public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Despesa> Despesa { get; set; }

        //VERIFICA SE A URL(CONEXÃO) SE ESTÁ CONFIGIRADA//
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }

        // FAZER A CONEXÃO COM A TABELA ASPNETUSERS COM A APPLICATION //
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }


        public string ObterStringConexao()
        {
            return "Server=localhost\\sqlexpress;Initial Catalog=FINANCEIRO_2023;Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        }






    }
}
