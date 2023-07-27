namespace SMC3.View
{
    partial class UpdateProduit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            descriptionProduitTxt = new RichTextBox();
            stockProduitTxt = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            prixProduitTxt = new Guna.UI2.WinForms.Guna2NumericUpDown();
            categoryProduitTxt = new Guna.UI2.WinForms.Guna2TextBox();
            nomProduitTxt = new Guna.UI2.WinForms.Guna2TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockProduitTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prixProduitTxt).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(descriptionProduitTxt);
            panel2.Controls.Add(stockProduitTxt);
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(prixProduitTxt);
            panel2.Controls.Add(categoryProduitTxt);
            panel2.Controls.Add(nomProduitTxt);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 540);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 63);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 1;
            label1.Text = "MODIFIER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(472, 215);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 8;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 211);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 7;
            label2.Text = "Prix";
            // 
            // descriptionProduitTxt
            // 
            descriptionProduitTxt.BackColor = Color.FromArgb(224, 224, 224);
            descriptionProduitTxt.BorderStyle = BorderStyle.None;
            descriptionProduitTxt.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionProduitTxt.Location = new Point(31, 340);
            descriptionProduitTxt.Name = "descriptionProduitTxt";
            descriptionProduitTxt.Size = new Size(704, 100);
            descriptionProduitTxt.TabIndex = 4;
            descriptionProduitTxt.Text = "Déscription ";
            // 
            // stockProduitTxt
            // 
            stockProduitTxt.BackColor = Color.Transparent;
            stockProduitTxt.BorderColor = Color.Black;
            stockProduitTxt.CustomizableEdges = customizableEdges1;
            stockProduitTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stockProduitTxt.Location = new Point(455, 246);
            stockProduitTxt.Margin = new Padding(4, 4, 4, 4);
            stockProduitTxt.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            stockProduitTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            stockProduitTxt.Name = "stockProduitTxt";
            stockProduitTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            stockProduitTxt.Size = new Size(279, 36);
            stockProduitTxt.TabIndex = 3;
            stockProduitTxt.UpDownButtonFillColor = Color.White;
            stockProduitTxt.UpDownButtonForeColor = Color.Transparent;
            stockProduitTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 64, 0);
            guna2Button1.FocusedColor = Color.FromArgb(0, 0, 64);
            guna2Button1.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.edit1;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(28, 28);
            guna2Button1.Location = new Point(574, 464);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.White;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(160, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Modifier";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // prixProduitTxt
            // 
            prixProduitTxt.BackColor = Color.Transparent;
            prixProduitTxt.BorderColor = Color.Black;
            prixProduitTxt.CustomizableEdges = customizableEdges5;
            prixProduitTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prixProduitTxt.Location = new Point(30, 246);
            prixProduitTxt.Margin = new Padding(4, 4, 4, 4);
            prixProduitTxt.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            prixProduitTxt.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            prixProduitTxt.Name = "prixProduitTxt";
            prixProduitTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            prixProduitTxt.Size = new Size(383, 36);
            prixProduitTxt.TabIndex = 2;
            prixProduitTxt.UpDownButtonFillColor = Color.White;
            prixProduitTxt.UpDownButtonForeColor = Color.Transparent;
            prixProduitTxt.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // categoryProduitTxt
            // 
            categoryProduitTxt.BorderColor = Color.Black;
            categoryProduitTxt.CustomizableEdges = customizableEdges7;
            categoryProduitTxt.DefaultText = "";
            categoryProduitTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            categoryProduitTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            categoryProduitTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            categoryProduitTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            categoryProduitTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            categoryProduitTxt.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryProduitTxt.ForeColor = Color.Black;
            categoryProduitTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            categoryProduitTxt.Location = new Point(471, 133);
            categoryProduitTxt.Margin = new Padding(4, 4, 4, 4);
            categoryProduitTxt.Name = "categoryProduitTxt";
            categoryProduitTxt.PasswordChar = '\0';
            categoryProduitTxt.PlaceholderForeColor = Color.FromArgb(0, 0, 64);
            categoryProduitTxt.PlaceholderText = "Catégorie";
            categoryProduitTxt.SelectedText = "";
            categoryProduitTxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            categoryProduitTxt.Size = new Size(263, 44);
            categoryProduitTxt.TabIndex = 1;
            categoryProduitTxt.TextChanged += categoryProduitTxt_TextChanged;
            // 
            // nomProduitTxt
            // 
            nomProduitTxt.BorderColor = Color.Black;
            nomProduitTxt.CustomizableEdges = customizableEdges9;
            nomProduitTxt.DefaultText = "";
            nomProduitTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nomProduitTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nomProduitTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nomProduitTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nomProduitTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nomProduitTxt.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nomProduitTxt.ForeColor = Color.Black;
            nomProduitTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nomProduitTxt.Location = new Point(30, 133);
            nomProduitTxt.Margin = new Padding(4, 4, 4, 4);
            nomProduitTxt.Name = "nomProduitTxt";
            nomProduitTxt.PasswordChar = '\0';
            nomProduitTxt.PlaceholderForeColor = Color.FromArgb(0, 0, 64);
            nomProduitTxt.PlaceholderText = "Nom du produit";
            nomProduitTxt.SelectedText = "";
            nomProduitTxt.ShadowDecoration.CustomizableEdges = customizableEdges10;
            nomProduitTxt.Size = new Size(383, 44);
            nomProduitTxt.TabIndex = 0;
            // 
            // UpdateProduit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 540);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateProduit";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += UpdateProduit_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockProduitTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)prixProduitTxt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private RichTextBox descriptionProduitTxt;
        private Guna.UI2.WinForms.Guna2NumericUpDown stockProduitTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2NumericUpDown prixProduitTxt;
        private Guna.UI2.WinForms.Guna2TextBox categoryProduitTxt;
        private Guna.UI2.WinForms.Guna2TextBox nomProduitTxt;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}