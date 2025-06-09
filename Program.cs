using System.Configuration;
using Microsoft.EntityFrameworkCore;
using museum_app.Data;
using museum_app.Seeders;

namespace museum_app
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            // Konfiguracja po³¹czenia z baz¹ danych PostgreSQL
            string connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            using var context = new AppDbContext(optionsBuilder.Options);

            // Wykonanie migracji i seedowanie bazy przy pierwszym uruchomieniu
            context.Database.Migrate();

            if (!context.TicketTypes.Any() && !context.Exhibitions.Any() && !context.TicketOrders.Any())
            {
                DbSeeder.Seed(context);
            }
             
            // Start aplikacji
            RunApplication(context);
        }

        static void RunApplication(AppDbContext context)
        {
            while (true)
            {
                using (var mainForm = new MainForm(context))
                {
                    var result = mainForm.ShowDialog();
                
                    if (result == DialogResult.Cancel || result == DialogResult.Abort)
                    {
                        break; // Zakoñczenie aplikacji, jeœli u¿ytkownik zamknie g³ówne okno
                    }   
                }
            }
        }
    }
}