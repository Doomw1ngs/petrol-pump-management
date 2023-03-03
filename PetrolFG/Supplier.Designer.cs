namespace PetrolFG
{
    partial class Supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            SuppliersList = new DataGridView();
            panel4 = new Panel();
            SaveBtn = new Button();
            AddressTb = new TextBox();
            label5 = new Label();
            PhoneTb = new TextBox();
            SupNameTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            EditBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SuppliersList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SuppliersList
            // 
            SuppliersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuppliersList.Location = new Point(439, 382);
            SuppliersList.Name = "SuppliersList";
            SuppliersList.RowHeadersWidth = 62;
            SuppliersList.RowTemplate.Height = 33;
            SuppliersList.Size = new Size(1198, 703);
            SuppliersList.TabIndex = 43;
            SuppliersList.CellContentClick += SuppliersList_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(417, 382);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 703);
            panel4.TabIndex = 42;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.DarkBlue;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(74, 791);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(109, 49);
            SaveBtn.TabIndex = 41;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTb.Location = new Point(101, 591);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(272, 121);
            AddressTb.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(101, 557);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 33;
            label5.Text = "Address";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.Location = new Point(101, 503);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(272, 35);
            PhoneTb.TabIndex = 32;
            // 
            // SupNameTb
            // 
            SupNameTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SupNameTb.Location = new Point(101, 416);
            SupNameTb.Name = "SupNameTb";
            SupNameTb.Size = new Size(272, 35);
            SupNameTb.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(101, 382);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semilight", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(672, 38);
            label1.Name = "label1";
            label1.Size = new Size(218, 65);
            label1.TabIndex = 0;
            label1.Text = "Suppliers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(101, 469);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 31;
            label4.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1659, 150);
            panel1.TabIndex = 26;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.DarkBlue;
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(264, 791);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(109, 49);
            EditBtn.TabIndex = 44;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 1261);
            Controls.Add(EditBtn);
            Controls.Add(SuppliersList);
            Controls.Add(panel4);
            Controls.Add(SaveBtn);
            Controls.Add(AddressTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(SupNameTb);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Supplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)SuppliersList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SuppliersList;
        private Panel panel4;
        private Button SaveBtn;
        private TextBox AddressTb;
        private Label label5;
        private TextBox PhoneTb;
        private TextBox SupNameTb;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Button EditBtn;
    }
}