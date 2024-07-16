using anot_ai.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace anot_ai.Data
{
    public class AnotacaoContext : DbContext
    {
        public DbSet<Anotacao> Anotacoes { get; set; }
        public DbSet<Smart> Smarts { get; set; }
        public DbSet<Monitoramento> Monitoramentos { get; set; }
        public DbSet<Etapa> Etapas { get; set; }
        public DbSet<PlanoAcao> PlanosAcao { get; set; }
        public string DbPath { get; set; }

        public AnotacaoContext(DbContextOptions<AnotacaoContext> options ): base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "anotacoes.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           



            modelBuilder.Entity<Smart>()
                .HasOne(smart => smart.Anotacao)
                .WithOne(anotacao => anotacao.Smart)
                .HasForeignKey<Smart>(s=>s.AnotacaoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Monitoramento>()
                .HasOne(monitoramento => monitoramento.Anotacao)
                .WithOne(anotacao => anotacao.Monitoramento)
                .HasForeignKey<Monitoramento>(m => m.AnotacaoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanoAcao>()
               .HasOne(planoAcao => planoAcao.Anotacao)
               .WithOne(anotacao => anotacao.PlanoAcao)
               .HasForeignKey<PlanoAcao>(pa => pa.AnotacaoId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Etapa>()
               .HasOne(etapa => etapa.PlanoAcao)
               .WithMany(planoAcao => planoAcao.Etapas)
               .HasForeignKey(etapa=> etapa.PlanoAcaoId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }

    
}
