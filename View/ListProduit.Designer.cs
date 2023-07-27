namespace SMC3.View
{
    partial class ListProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            prix = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            selectedProduit = new Label();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 34);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 75);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(385, 32);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "LISTE DES PRODUITS";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.AllowUserToResizeColumns = false;
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 45;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, prix, stock, category, note });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(25, 170);
            guna2DataGridView1.MultiSelect = false;
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64);
            guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 64);
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.Size = new Size(922, 363);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 45;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // name
            // 
            name.HeaderText = "Nom du produit";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // prix
            // 
            prix.HeaderText = "Prix";
            prix.Name = "prix";
            prix.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "Categorie";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // note
            // 
            note.HeaderText = "Déscription";
            note.Name = "note";
            note.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(selectedProduit);
            panel2.Controls.Add(guna2Button3);
            panel2.Controls.Add(guna2Button2);
            panel2.Controls.Add(searchTxt);
            panel2.Location = new Point(25, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 83);
            panel2.TabIndex = 2;
            // 
            // selectedProduit
            // 
            selectedProduit.AutoSize = true;
            selectedProduit.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            selectedProduit.Location = new Point(11, 63);
            selectedProduit.Name = "selectedProduit";
            selectedProduit.Size = new Size(0, 18);
            selectedProduit.TabIndex = 7;
            // 
            // guna2Button3
            // 
            guna2Button3.BorderColor = Color.Transparent;
            guna2Button3.CustomizableEdges = customizableEdges3;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(64, 0, 0);
            guna2Button3.FocusedColor = Color.FromArgb(0, 0, 64);
            guna2Button3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Image = Properties.Resources.delete;
            guna2Button3.Location = new Point(323, 4);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.PressedColor = Color.White;
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button3.Size = new Size(129, 44);
            guna2Button3.TabIndex = 6;
            guna2Button3.Text = "Supprimer";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = Color.Transparent;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(64, 0, 64);
            guna2Button2.FocusedColor = Color.FromArgb(0, 0, 64);
            guna2Button2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = Properties.Resources.edit;
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.Location = new Point(3, 3);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedColor = Color.White;
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(145, 44);
            guna2Button2.TabIndex = 5;
            guna2Button2.Text = "Modifier";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // searchTxt
            // 
            searchTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTxt.BorderColor = Color.Black;
            searchTxt.CustomizableEdges = customizableEdges7;
            searchTxt.DefaultText = "";
            searchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTxt.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.ForeColor = Color.Black;
            searchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchTxt.IconRight = Properties.Resources.magnifying_glass;
            searchTxt.IconRightSize = new Size(25, 25);
            searchTxt.Location = new Point(515, 4);
            searchTxt.Margin = new Padding(4, 4, 4, 4);
            searchTxt.Name = "searchTxt";
            searchTxt.PasswordChar = '\0';
            searchTxt.PlaceholderForeColor = Color.FromArgb(0, 0, 64);
            searchTxt.PlaceholderText = "Rechercher ........";
            searchTxt.SelectedText = "";
            searchTxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            searchTxt.Size = new Size(403, 44);
            searchTxt.TabIndex = 1;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Purple;
            guna2Button1.FocusedColor = Color.FromArgb(0, 0, 64);
            guna2Button1.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.updated1;
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.ImageSize = new Size(25, 25);
            guna2Button1.Location = new Point(170, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.White;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(129, 44);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Achat";
            // 
            // ListProduit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel1);
            Name = "ListProduit";
            Size = new Size(971, 545);
            Load += ListProduit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn prix;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn note;
        private Label selectedProduit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
