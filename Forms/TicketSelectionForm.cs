using Microsoft.EntityFrameworkCore;
using museum_app.Data;
using museum_app.Models;

namespace museum_app.Forms
{
    public partial class TicketSelectionForm: Form
    {
        private readonly AppDbContext _context;
        private readonly Exhibition _selectedExhibition;
        private Dictionary<string, decimal> _ticketPrices;

        public TicketSelectionForm(AppDbContext context, Exhibition selectedExhibition) 
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            _context = context;
            _selectedExhibition = selectedExhibition;

            // Ustawienie tytułu wystawy w etykiecie
            labelExhibitionTitle.Text = _selectedExhibition.Title;

            // Załadowanie cen biletów asynchronicznie
            LoadPricesAsync().Wait();

            // Odświeżenie etykiet z cenami biletów
            UpdatePriceLabels();

            // Podłączenie zdarzeń zmiany wartości NumericUpDown
            numericUpDownNormal.ValueChanged += (s, e) => UpdatePriceLabels();
            numericUpDownDiscounted.ValueChanged += (s, e) => UpdatePriceLabels();
            numericUpDownFamily.ValueChanged += (s, e) => UpdatePriceLabels();
        }

        private async Task LoadPricesAsync()
        {
            // Pobierz ceny biletów z bazy danych i przypisz do słownika
            _ticketPrices = await _context.TicketTypes
                .ToDictionaryAsync(t => t.Name, t => t.Price);
        }

        private void UpdatePriceLabels()
        {
            // Obliczenie cen biletów na podstawie wartości NumericUpDown i cen z bazy danych
            decimal normalPrice = (decimal)numericUpDownNormal.Value * _ticketPrices["Normalny"];
            decimal discountedPrice = (decimal)numericUpDownDiscounted.Value * _ticketPrices["Ulgowy"];
            decimal familyPrice = (decimal)numericUpDownFamily.Value * _ticketPrices["Rodzinny"];

            // Aktualizacja etykiet z cenami biletów
            labelNormalPrice.Text = $"{normalPrice:N2} zł";
            labelDiscountedPrice.Text = $"{discountedPrice:N2} zł";
            labelFamilyPrice.Text = $"{familyPrice:N2} zł";
        }

        private void buttonNext_click(object sender, EventArgs e)
        {
            int normalCount = (int)numericUpDownNormal.Value;
            int discountedCount = (int)numericUpDownDiscounted.Value;
            int familyCount = (int)numericUpDownFamily.Value;

            int total = normalCount + discountedCount + familyCount;

            // Sprawdzenie, czy wybrano przynajmniej jeden bilet
            if (total == 0)
            {
                MessageBox.Show("Wybierz przynajmniej jeden bilet, aby kontynuować.", "Nie wybrano biletów", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Przejście do formularza podsumowania
            this.Hide();
            var summaryForm = new SummaryForm(_context, _selectedExhibition, normalCount, discountedCount, familyCount);
            if (summaryForm.ShowDialog() == DialogResult.Cancel)
            {
                // Powrót do wyboru biletów, jeśli użytkownik anulował
                this.DialogResult = DialogResult.Cancel;
                this.Close(); // Powrót do mainForm
            }
            else
            {
                // Kontynuacja procesu, jeśli użytkownik potwierdził zamówienie
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Anulowanie wyboru biletów i powrót do głównego formularza
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
