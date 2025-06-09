using Microsoft.EntityFrameworkCore;
using museum_app.Data;
using museum_app.Models;

namespace museum_app.Forms
{
    public partial class AdminPanelForm: Form
    {
        private readonly AppDbContext _context;

        public AdminPanelForm(AppDbContext context)
        {
            StartPosition = FormStartPosition.CenterParent;
            _context = context;

            InitializeComponent();
            LoadData();          // Załadowanie danych do DataGridView
            SetupGridEvents();   // Obsługa usuwania wierszy w DataGridView
        }

        private void LoadData()
        {
            // Ładowanie lokalnych dane z bazy i przypisanie ich do DataGridView
            _context.Exhibitions.Load();
            dataGridViewExhibitions.DataSource = _context.Exhibitions.Local.ToBindingList();

            _context.TicketTypes.Load();
            dataGridViewTicketTypes.DataSource = _context.TicketTypes.Local.ToBindingList();

            _context.TicketItems.Load();
            dataGridViewTicketItems.DataSource = _context.TicketItems.Local.ToBindingList();

            _context.TicketOrders.Load();
            dataGridViewTicketOrders.DataSource = _context.TicketOrders.Local.ToBindingList();
        }

        private void SetupGridEvents()
        {
            // Obsługa usuwania rekordów z widoków
            dataGridViewExhibitions.UserDeletingRow += (s, e) =>
            {
                var entity = e.Row.DataBoundItem as Exhibition;
                if (entity != null)
                {
                    _context.Exhibitions.Remove(entity);
                }
            };

            dataGridViewTicketTypes.UserDeletingRow += (s, e) =>
            {
                var entity = e.Row.DataBoundItem as TicketType;
                if (entity != null)
                {
                    _context.TicketTypes.Remove(entity);
                }
            };

            dataGridViewTicketItems.UserDeletingRow += (s, e) =>
            {
                var entity = e.Row.DataBoundItem as TicketItem;
                if (entity != null)
                {
                    _context.TicketItems.Remove(entity);
                }
            };

            dataGridViewTicketOrders.UserDeletingRow += (s, e) =>
            {
                var entity = e.Row.DataBoundItem as TicketOrder;
                if (entity != null)
                {
                    _context.TicketOrders.Remove(entity);
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Zapisanie zmian w bazie danych
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Zapisano zmiany");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Restart aplikacji
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit(); // Zamknięcie bieżącej instancji
        }
    }
}
