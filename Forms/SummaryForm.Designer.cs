using System.Linq.Expressions;

namespace museum_app.Forms
{
    partial class SummaryForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblExhibitionTitle;
        private Label lblTickets;
        private Label lblTotal;
        private Button btnConfirm;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblExhibitionTitle = new Label();
            lblTickets = new Label();
            lblTotal = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DimGray;
            lblTitle.Location = new Point(189, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Podsumowanie";
            // 
            // lblExhibitionTitle
            // 
            lblExhibitionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblExhibitionTitle.ForeColor = Color.DimGray;
            lblExhibitionTitle.Location = new Point(347, 80);
            lblExhibitionTitle.Name = "lblExhibitionTitle";
            lblExhibitionTitle.Size = new Size(105, 30);
            lblExhibitionTitle.TabIndex = 1;
            lblExhibitionTitle.Text = "nazwa";
            // 
            // lblTickets
            // 
            lblTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTickets.ForeColor = Color.DimGray;
            lblTickets.Location = new Point(223, 130);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(180, 80);
            lblTickets.TabIndex = 2;
            lblTickets.Text = "bilety";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTotal.ForeColor = Color.DimGray;
            lblTotal.Location = new Point(167, 230);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(285, 40);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Kwota do zapłaty";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SteelBlue;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(327, 291);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 42);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Kupuję!";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.OrangeRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(124, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(151, 80);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 6;
            label1.Text = "Wybrana wystawa:";
            // 
            // SummaryForm
            // 
            ClientSize = new Size(582, 403);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblExhibitionTitle);
            Controls.Add(lblTickets);
            Controls.Add(lblTotal);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Name = "SummaryForm";
            Text = "Podsumowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}