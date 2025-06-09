namespace museum_app.Forms
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl1;
        private TabPage tabPageExhibitions;
        private TabPage tabPageTicketTypes;
        private TabPage tabPageTicketItems;
        private TabPage tabPageTicketOrders;
        private DataGridView dataGridViewExhibitions;
        private DataGridView dataGridViewTicketTypes;
        private DataGridView dataGridViewTicketItems;
        private DataGridView dataGridViewTicketOrders;
        private Button btnSave;
        private Button btnClose;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageExhibitions = new TabPage();
            dataGridViewExhibitions = new DataGridView();
            tabPageTicketTypes = new TabPage();
            dataGridViewTicketTypes = new DataGridView();
            tabPageTicketItems = new TabPage();
            dataGridViewTicketItems = new DataGridView();
            tabPageTicketOrders = new TabPage();
            dataGridViewTicketOrders = new DataGridView();
            btnSave = new Button();
            btnClose = new Button();
            tabControl1.SuspendLayout();
            tabPageExhibitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExhibitions).BeginInit();
            tabPageTicketTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketTypes).BeginInit();
            tabPageTicketItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketItems).BeginInit();
            tabPageTicketOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketOrders).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageExhibitions);
            tabControl1.Controls.Add(tabPageTicketTypes);
            tabControl1.Controls.Add(tabPageTicketItems);
            tabControl1.Controls.Add(tabPageTicketOrders);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(958, 493);
            tabControl1.TabIndex = 0;
            // 
            // tabPageExhibitions
            // 
            tabPageExhibitions.Controls.Add(dataGridViewExhibitions);
            tabPageExhibitions.Location = new Point(4, 29);
            tabPageExhibitions.Name = "tabPageExhibitions";
            tabPageExhibitions.Size = new Size(950, 460);
            tabPageExhibitions.TabIndex = 0;
            tabPageExhibitions.Text = "Wystawy";
            // 
            // dataGridViewExhibitions
            // 
            dataGridViewExhibitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExhibitions.ColumnHeadersHeight = 29;
            dataGridViewExhibitions.Dock = DockStyle.Fill;
            dataGridViewExhibitions.Location = new Point(0, 0);
            dataGridViewExhibitions.Name = "dataGridViewExhibitions";
            dataGridViewExhibitions.RowHeadersWidth = 51;
            dataGridViewExhibitions.Size = new Size(950, 460);
            dataGridViewExhibitions.TabIndex = 0;
            // 
            // tabPageTickets
            // 
            tabPageTicketTypes.Controls.Add(dataGridViewTicketTypes);
            tabPageTicketTypes.Location = new Point(4, 29);
            tabPageTicketTypes.Name = "tabPageTicketTypes";
            tabPageTicketTypes.Size = new Size(752, 367);
            tabPageTicketTypes.TabIndex = 1;
            tabPageTicketTypes.Text = "Cennik";
            // 
            // dataGridViewTickets
            // 
            dataGridViewTicketTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTicketTypes.ColumnHeadersHeight = 29;
            dataGridViewTicketTypes.Dock = DockStyle.Fill;
            dataGridViewTicketTypes.Location = new Point(0, 0);
            dataGridViewTicketTypes.Name = "dataGridViewTicketTypes";
            dataGridViewTicketTypes.RowHeadersWidth = 51;
            dataGridViewTicketTypes.Size = new Size(752, 367);
            dataGridViewTicketTypes.TabIndex = 0;
            // 
            // tabPageTicketItems
            // 
            tabPageTicketItems.Controls.Add(dataGridViewTicketItems);
            tabPageTicketItems.Location = new Point(4, 29);
            tabPageTicketItems.Name = "tabPageTicketItems";
            tabPageTicketItems.Size = new Size(752, 367);
            tabPageTicketItems.TabIndex = 2;
            tabPageTicketItems.Text = "Rezerwacje";
            // 
            // dataGridViewTicketItems
            // 
            dataGridViewTicketItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTicketItems.ColumnHeadersHeight = 29;
            dataGridViewTicketItems.Dock = DockStyle.Fill;
            dataGridViewTicketItems.Location = new Point(0, 0);
            dataGridViewTicketItems.Name = "dataGridViewTicketItems";
            dataGridViewTicketItems.RowHeadersWidth = 51;
            dataGridViewTicketItems.Size = new Size(752, 367);
            dataGridViewTicketItems.TabIndex = 0;
            // 
            // tabPageTicketOrders
            // 
            tabPageTicketOrders.Controls.Add(dataGridViewTicketOrders);
            tabPageTicketOrders.Location = new Point(4, 29);
            tabPageTicketOrders.Name = "tabPageTicketOrders";
            tabPageTicketOrders.Size = new Size(752, 367);
            tabPageTicketOrders.TabIndex = 3;
            tabPageTicketOrders.Text = "Transakcje";
            // 
            // dataGridViewTicketOrders
            // 
            dataGridViewTicketOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTicketOrders.ColumnHeadersHeight = 29;
            dataGridViewTicketOrders.Dock = DockStyle.Fill;
            dataGridViewTicketOrders.Location = new Point(0, 0);
            dataGridViewTicketOrders.Name = "dataGridViewTicketOrders";
            dataGridViewTicketOrders.RowHeadersWidth = 51;
            dataGridViewTicketOrders.Size = new Size(752, 367);
            dataGridViewTicketOrders.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(796, 511);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Zapisz";
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(886, 511);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "Zamknij";
            btnClose.Click += btnClose_Click;
            // 
            // AdminPanelForm
            // 
            ClientSize = new Size(982, 553);
            Controls.Add(tabControl1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AdminPanelForm";
            Text = "Panel administratora";
            tabControl1.ResumeLayout(false);
            tabPageExhibitions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExhibitions).EndInit();
            tabPageTicketTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketTypes).EndInit();
            tabPageTicketItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketItems).EndInit();
            tabPageTicketOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}