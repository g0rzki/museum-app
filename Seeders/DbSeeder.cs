using Bogus;
using museum_app.Data;
using museum_app.Models;

namespace museum_app.Seeders
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Dodanie typów biletów
            var ticketTypes = new List<TicketType>
            {
                new TicketType { Name = "Normalny", Price = 20.00m },
                new TicketType { Name = "Ulgowy", Price = 15.00m },
                new TicketType { Name = "Rodzinny", Price = 45.00m }
            };
            context.TicketTypes.AddRange(ticketTypes);

            // Dodanie wystaw
            var exhibitions = new List<Exhibition>
            {
                new Exhibition {
                    Title = "Dinozaury",
                    Description = "Wystawa prehistorycznych gadów.",
                    StartDate = new DateTime(2025, 03, 01),
                    EndDate = new DateTime(2025, 09, 30)
                },
                new Exhibition {
                    Title = "Kosmos",
                    Description = "Poznaj historię podboju kosmosu.",
                    StartDate = new DateTime(2025, 04, 01),
                    EndDate = new DateTime(2025, 10, 31)
                },
                new Exhibition {
                    Title = "Mumia",
                    Description = "Starożytny Egipt pod mikroskopem.",
                    StartDate = new DateTime(2025, 05, 01),
                    EndDate = new DateTime(2025, 11, 30)
                }
            };
            context.Exhibitions.AddRange(exhibitions);

            context.SaveChanges();

            // Pobranie ID do powiązań w TicketItems
            var ticketTypeIds = context.TicketTypes.Select(tt => tt.Id).ToList();
            var exhibitionIds = context.Exhibitions.Select(ex => ex.Id).ToList();

            // Generowanie losowych zamówień i biletów (Bogus)
            var orderFaker = new Faker<TicketOrder>()
                .RuleFor(o => o.PurchaseDate, f => f.Date.Past(1).ToUniversalTime());

            var itemFaker = new Faker<TicketItem>()
                .RuleFor(i => i.TicketTypeId, f => f.PickRandom(ticketTypeIds))
                .RuleFor(i => i.ExhibitionId, f => f.PickRandom(exhibitionIds))
                .RuleFor(i => i.Quantity, f => f.Random.Int(1, 5));

            var random = new Random();

            for (int i = 0; i < 50; i++)
            {
                var order = orderFaker.Generate();
                var itemCount = random.Next(1, 4);

                order.TicketItems = itemFaker.Generate(itemCount);

                context.TicketOrders.Add(order);
            }

            context.SaveChanges();
        }
    }
}
