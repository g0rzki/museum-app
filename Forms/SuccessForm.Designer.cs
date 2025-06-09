namespace museum_app.Forms
{
    partial class SuccessForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMessage;
        private Button btnReturn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblMessage = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMessage.ForeColor = Color.DimGray;
            lblMessage.Location = new Point(71, 106);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(439, 81);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Dziękujemy za zakup!";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SteelBlue;
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(217, 240);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(140, 42);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Wyjdź";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // SuccessForm
            // 
            ClientSize = new Size(582, 403);
            Controls.Add(lblMessage);
            Controls.Add(btnReturn);
            Name = "SuccessForm";
            Text = "Sukces";
            ResumeLayout(false);
        }

        #endregion
    }
}