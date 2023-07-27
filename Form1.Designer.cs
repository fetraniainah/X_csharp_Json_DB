namespace SMC3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 34);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(guna2Button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 568);
            panel1.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.user__1_;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(61, 21);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(94, 94);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 6;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = Color.Transparent;
            guna2Button2.CustomizableEdges = customizableEdges2;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Teal;
            guna2Button2.FocusedColor = Color.FromArgb(0, 0, 64);
            guna2Button2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(12, 213);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedColor = Color.White;
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button2.Size = new Size(196, 45);
            guna2Button2.TabIndex = 5;
            guna2Button2.Text = "Ajouter un produit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges4;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 64, 0);
            guna2Button1.FocusedColor = Color.FromArgb(0, 0, 64);
            guna2Button1.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 137);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.White;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Button1.Size = new Size(196, 45);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "Liste des produits";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(214, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 568);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 568);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1153, 607);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}