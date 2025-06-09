namespace museum_app
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxExhibitions;
        private Button btnNext;
        private Label labelSelect;
        private Label labelAdminAccess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBoxExhibitions = new ComboBox();
            btnNext = new Button();
            labelSelect = new Label();
            labelAdminAccess = new Label();
            SuspendLayout();
            // 
            // comboBoxExhibitions
            // 
            comboBoxExhibitions.BackColor = Color.White;
            comboBoxExhibitions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExhibitions.FlatStyle = FlatStyle.Flat;
            comboBoxExhibitions.Font = new Font("Segoe UI", 11F);
            comboBoxExhibitions.ForeColor = Color.Black;
            comboBoxExhibitions.FormattingEnabled = true;
            comboBoxExhibitions.Location = new Point(133, 186);
            comboBoxExhibitions.Name = "comboBoxExhibitions";
            comboBoxExhibitions.Size = new Size(313, 33);
            comboBoxExhibitions.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SteelBlue;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(220, 276);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 42);
            btnNext.TabIndex = 2;
            btnNext.Text = "Dalej";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // labelSelect
            // 
            labelSelect.AutoSize = true;
            labelSelect.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelSelect.ForeColor = Color.DimGray;
            labelSelect.Location = new Point(90, 92);
            labelSelect.Name = "labelSelect";
            labelSelect.Size = new Size(409, 37);
            labelSelect.TabIndex = 0;
            labelSelect.Text = "Wybierz wystawę do zwiedzania";
            labelSelect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAdminAccess
            // 
            labelAdminAccess.AutoSize = true;
            labelAdminAccess.Cursor = Cursors.Hand;
            labelAdminAccess.Location = new Point(1, -1);
            labelAdminAccess.Name = "labelAdminAccess";
            labelAdminAccess.Size = new Size(27, 25);
            labelAdminAccess.TabIndex = 3;
            labelAdminAccess.Text = "   ";
            labelAdminAccess.Click += labelAdminAccess_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(582, 403);
            Controls.Add(labelAdminAccess);
            Controls.Add(labelSelect);
            Controls.Add(comboBoxExhibitions);
            Controls.Add(btnNext);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiosk Muzealny";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}