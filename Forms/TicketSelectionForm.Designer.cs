namespace museum_app.Forms
{
    partial class TicketSelectionForm
    {
        
        private System.ComponentModel.IContainer components = null;
        private Label labelExhibitionTitle;
        private NumericUpDown numericUpDownNormal;
        private NumericUpDown numericUpDownDiscounted;
        private NumericUpDown numericUpDownFamily;
        private Label labelNormal;
        private Label labelDiscounted;
        private Label labelFamily;
        private Label labelNormalPrice;
        private Label labelDiscountedPrice;
        private Label labelFamilyPrice;
        private Button buttonNext;
        private Button buttonCancel;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelExhibitionTitle = new Label();
            labelNormal = new Label();
            labelDiscounted = new Label();
            labelFamily = new Label();
            numericUpDownNormal = new NumericUpDown();
            numericUpDownDiscounted = new NumericUpDown();
            numericUpDownFamily = new NumericUpDown();
            labelNormalPrice = new Label();
            labelDiscountedPrice = new Label();
            labelFamilyPrice = new Label();
            buttonNext = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscounted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFamily).BeginInit();
            SuspendLayout();
            // 
            // labelExhibitionTitle
            // 
            labelExhibitionTitle.AutoSize = true;
            labelExhibitionTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelExhibitionTitle.ForeColor = Color.DimGray;
            labelExhibitionTitle.Location = new Point(301, 31);
            labelExhibitionTitle.Name = "labelExhibitionTitle";
            labelExhibitionTitle.Size = new Size(94, 37);
            labelExhibitionTitle.TabIndex = 0;
            labelExhibitionTitle.Text = "nazwa";
            // 
            // labelNormal
            // 
            labelNormal.Font = new Font("Segoe UI", 12F);
            labelNormal.ForeColor = Color.DimGray;
            labelNormal.Location = new Point(61, 115);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(173, 40);
            labelNormal.TabIndex = 1;
            labelNormal.Text = "Bilety normalne:";
            // 
            // labelDiscounted
            // 
            labelDiscounted.Font = new Font("Segoe UI", 12F);
            labelDiscounted.ForeColor = Color.DimGray;
            labelDiscounted.Location = new Point(61, 155);
            labelDiscounted.Name = "labelDiscounted";
            labelDiscounted.Size = new Size(173, 36);
            labelDiscounted.TabIndex = 3;
            labelDiscounted.Text = "Bilety ulgowe:";
            // 
            // labelFamily
            // 
            labelFamily.Font = new Font("Segoe UI", 12F);
            labelFamily.ForeColor = Color.DimGray;
            labelFamily.Location = new Point(61, 195);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(173, 36);
            labelFamily.TabIndex = 5;
            labelFamily.Text = "Bilety rodzinne:";
            // 
            // numericUpDownNormal
            // 
            numericUpDownNormal.BackColor = Color.White;
            numericUpDownNormal.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownNormal.Font = new Font("Segoe UI", 11F);
            numericUpDownNormal.ForeColor = Color.Black;
            numericUpDownNormal.Location = new Point(341, 115);
            numericUpDownNormal.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownNormal.Name = "numericUpDownNormal";
            numericUpDownNormal.Size = new Size(120, 32);
            numericUpDownNormal.TabIndex = 2;
            // 
            // numericUpDownDiscounted
            // 
            numericUpDownDiscounted.BackColor = Color.White;
            numericUpDownDiscounted.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownDiscounted.Font = new Font("Segoe UI", 11F);
            numericUpDownDiscounted.ForeColor = Color.Black;
            numericUpDownDiscounted.Location = new Point(341, 155);
            numericUpDownDiscounted.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDiscounted.Name = "numericUpDownDiscounted";
            numericUpDownDiscounted.Size = new Size(120, 32);
            numericUpDownDiscounted.TabIndex = 4;
            // 
            // numericUpDownFamily
            // 
            numericUpDownFamily.BackColor = Color.White;
            numericUpDownFamily.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownFamily.Font = new Font("Segoe UI", 11F);
            numericUpDownFamily.ForeColor = Color.Black;
            numericUpDownFamily.Location = new Point(341, 195);
            numericUpDownFamily.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownFamily.Name = "numericUpDownFamily";
            numericUpDownFamily.Size = new Size(120, 32);
            numericUpDownFamily.TabIndex = 6;
            // 
            // labelNormalPrice
            // 
            labelNormalPrice.AutoSize = true;
            labelNormalPrice.Font = new Font("Segoe UI", 10.8F);
            labelNormalPrice.ForeColor = Color.DimGray;
            labelNormalPrice.Location = new Point(240, 118);
            labelNormalPrice.Name = "labelNormalPrice";
            labelNormalPrice.Size = new Size(59, 25);
            labelNormalPrice.TabIndex = 9;
            labelNormalPrice.Text = "label1";
            // 
            // labelDiscountedPrice
            // 
            labelDiscountedPrice.AutoSize = true;
            labelDiscountedPrice.Font = new Font("Segoe UI", 10.8F);
            labelDiscountedPrice.ForeColor = Color.DimGray;
            labelDiscountedPrice.Location = new Point(240, 158);
            labelDiscountedPrice.Name = "labelDiscountedPrice";
            labelDiscountedPrice.Size = new Size(59, 25);
            labelDiscountedPrice.TabIndex = 10;
            labelDiscountedPrice.Text = "label2";
            // 
            // labelFamilyPrice
            // 
            labelFamilyPrice.AutoSize = true;
            labelFamilyPrice.Font = new Font("Segoe UI", 10.8F);
            labelFamilyPrice.ForeColor = Color.DimGray;
            labelFamilyPrice.Location = new Point(240, 198);
            labelFamilyPrice.Name = "labelFamilyPrice";
            labelFamilyPrice.Size = new Size(59, 25);
            labelFamilyPrice.TabIndex = 11;
            labelFamilyPrice.Text = "label3";
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.SteelBlue;
            buttonNext.Cursor = Cursors.Hand;
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonNext.ForeColor = Color.White;
            buttonNext.Location = new Point(310, 287);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(140, 42);
            buttonNext.TabIndex = 7;
            buttonNext.Text = "Dalej";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.OrangeRed;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(119, 287);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 42);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Anuluj";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 12;
            label1.Text = "Wybrana wystawa:";
            // 
            // TicketSelectionForm
            // 
            ClientSize = new Size(582, 403);
            Controls.Add(label1);
            Controls.Add(labelFamilyPrice);
            Controls.Add(labelDiscountedPrice);
            Controls.Add(labelNormalPrice);
            Controls.Add(labelExhibitionTitle);
            Controls.Add(labelNormal);
            Controls.Add(numericUpDownNormal);
            Controls.Add(labelDiscounted);
            Controls.Add(numericUpDownDiscounted);
            Controls.Add(labelFamily);
            Controls.Add(numericUpDownFamily);
            Controls.Add(buttonNext);
            Controls.Add(buttonCancel);
            Name = "TicketSelectionForm";
            Text = "Wybór biletów";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscounted).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFamily).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}