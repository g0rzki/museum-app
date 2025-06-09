using Microsoft.EntityFrameworkCore;
using museum_app.Models;

namespace museum_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        // Tabele w bazie
        public DbSet<TicketOrder> TicketOrders { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<TicketItem> TicketItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sprawdzenie, czy opcje zostały już skonfigurowane
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = System.Configuration.ConfigurationManager
                    .ConnectionStrings["PostgresConnection"]
                    .ConnectionString;

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ustawienie typu daty bez strefy czasowej
            modelBuilder.Entity<Exhibition>(entity =>
            {
                entity.Property(e => e.StartDate)
                .HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndDate)
                .HasColumnType("timestamp without time zone");
            });

            // Wymuszenie lowercase dla nazw tabel, kolumn, kluczy, itd.
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToLower());

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToLower());
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToLower());
                }

                foreach (var fk in entity.GetForeignKeys())
                {
                    fk.SetConstraintName(fk.GetConstraintName().ToLower());
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.GetDatabaseName().ToLower());
                }
            }
        }
    }
}
