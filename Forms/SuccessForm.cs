namespace museum_app.Forms
{
    public partial class SuccessForm: Form
    {
        public SuccessForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Zakończenie pracy aplikacji
            Application.Exit();
        }
    }
}
