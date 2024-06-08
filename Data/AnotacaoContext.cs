using anot_ai.Models;
using Microsoft.EntityFrameworkCore;

namespace anot_ai.Data
{
    public class AnotacaoContext : DbContext
    {
        public DbSet<Anotacao> Anotacoes { get; set; }
        public string DbPath { get; }

        public AnotacaoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "anotacoes.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
