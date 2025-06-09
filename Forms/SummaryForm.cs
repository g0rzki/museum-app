using museum_app.Data;
using museum_app.Models;

namespace museum_app.Forms
{
    public partial class SummaryForm: Form
    {
        private readonly AppDbContext _context;
        private readonly Exhibition _selectedExhibition;
        private readonly int _normalCount;
        private readonly int _discountedCount;
        private readonly int _familyCount;
        private Dictionary<string, decimal> _ticketPrices;

        public SummaryForm(AppDbContext context, Exhibition selectedExhibition, int normal, int discounted, int family)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            _context = context;
            _selectedExhibition = selectedExhibition;

            // Pobranie cen biletów z bazy danych
            _normalCount = normal;
            _discountedCount = discounted;
            _familyCount = family;

            LoadPrices();  // Załadowanie cen biletów
            ShowSummary(); // Wyświetlenie podsumowania zamówienia
        }

        // Metoda do załadowania cen biletów z bazy danych
        private void LoadPrices()
        {
            _ticketPrices = _context.TicketTypes.ToDictionary(t => t.Name, t => t.Price);
        }

        // Metoda do wyświetlenia podsumowania zamówienia
        private void ShowSummary()
        {
            lblExhibitionTitle.Text = _selectedExhibition.Title;

            // Wyświetlenie ilości biletów
            lblTickets.Text = $"Normalne: {_normalCount}\nUlgowe: {_discountedCount}\nRodzinne: {_familyCount}";

            // Pobranie cen z słownika i obliczenie całkowitej ceny
            decimal normalPrice = _ticketPrices.GetValueOrDefault("Normalny", 0);
            decimal discountedPrice = _ticketPrices.GetValueOrDefault("Ulgowy", 0);
            decimal familyPrice = _ticketPrices.GetValueOrDefault("Rodzinny", 0);

            decimal totalPrice =
                _normalCount * normalPrice +
                _discountedCount * discountedPrice +
                _familyCount * familyPrice;

            // Wyświetlenie całkowitej ceny w etykiecie
            lblTotal.Text = $"Suma do zapłaty: {totalPrice:N2} zł";
        }

        // Potwierdzenie zamówienia i zapis do bazy danych
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy wybrano przynajmniej jeden bilet
            var order = new TicketOrder
            {
                PurchaseDate = DateTime.UtcNow,
                TicketItems = new List<TicketItem>()
            };

            // Pobranie typów biletów z bazy danych
            var ticketTypes = _context.TicketTypes.ToList();

            // Dodanie biletów do zamówienia na podstawie ilości
            if (_normalCount > 0)
            {
                var normalType = ticketTypes.FirstOrDefault(t => t.Name == "Normalny");
                if (normalType != null)
                {
                    order.TicketItems.Add(new TicketItem
                    {
                        ExhibitionId = _selectedExhibition.Id,
                        TicketTypeId = normalType.Id,
                        Quantity = _normalCount
                    });
                }
            }

            // Dodanie biletów ulgowych i rodzinnych do zamówienia
            if (_discountedCount > 0)
            {
                var discountedType = ticketTypes.FirstOrDefault(t => t.Name == "Ulgowy");
                if (discountedType != null)
                {
                    order.TicketItems.Add(new TicketItem
                    {
                        ExhibitionId = _selectedExhibition.Id,
                        TicketTypeId = discountedType.Id,
                        Quantity = _discountedCount
                    });
                }
            }

            if (_familyCount > 0)
            {
                var familyType = ticketTypes.FirstOrDefault(t => t.Name == "Rodzinny");
                if (familyType != null)
                {
                    order.TicketItems.Add(new TicketItem
                    {
                        ExhibitionId = _selectedExhibition.Id,
                        TicketTypeId = familyType.Id,
                        Quantity = _familyCount
                    });
                }
            }

            // Dodanie całego zamówienia
            _context.TicketOrders.Add(order);

            // Zapis zmian w bazie danych
            _context.SaveChanges();

            // Ukrycie formularza i wyświetlenie komunikatu o sukcesie
            var successForm = new SuccessForm();
            this.Hide();
            successForm.ShowDialog();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Anulowanie wyboru biletów
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
