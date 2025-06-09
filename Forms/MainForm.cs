using System.Configuration;
using System.Data;
using Microsoft.EntityFrameworkCore;
using museum_app.Data;
using museum_app.Models;
using museum_app.Forms;

namespace museum_app
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;

        public MainForm(AppDbContext context)
        {
            InitializeComponent();

            // Inicjalizacja kontekstu bazy danych
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            string connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;
            optionsBuilder.UseNpgsql(connectionString);
            _context = new AppDbContext(optionsBuilder.Options);

            LoadExhibitions(); // Za³adowanie wystaw do ComboBox
            _context = context;
        }

        private void LoadExhibitions()
        {
            try
            {
                // Pobranie wystaw z bazy danych i przypisanie ich do ComboBox
                var exhibitions = _context.Exhibitions
                    .OrderBy(e => e.StartDate)
                    .ToList();

                comboBoxExhibitions.DataSource = exhibitions;
                comboBoxExhibitions.DisplayMember = "Title";
                comboBoxExhibitions.ValueMember = "Id";
                comboBoxExhibitions.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas ³adowania wystaw: " + ex.Message);
            }
        }

        private void labelAdminAccess_Click(object sender, EventArgs e)
        {
            // Wejœcie do panelu admina
            var adminForm = new AdminPanelForm(_context);
            this.Hide();
            adminForm.ShowDialog();
            this.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy wybrano wystawê
            if (comboBoxExhibitions.SelectedItem == null)
            {
                MessageBox.Show("Wybierz wystawê, aby kontynuowaæ.", "Nie wybrano wystawy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedExhibition = comboBoxExhibitions.SelectedItem as Exhibition;

            // Przejœcie do formularza wyboru biletów
            using (var ticketForm = new TicketSelectionForm(_context, selectedExhibition)) { 
                this.Hide();
                if (ticketForm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
