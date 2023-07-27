using SMC3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using SMC;
using System.Linq;
using Guna.UI2.WinForms;

namespace SMC3.View
{
    public partial class ListProduit : UserControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public double Prix { get; set; }
        public int Stock { get; set; }
        public string Categorie { get; set; }

        string jsonFilePath = "Data/Produit.json";

        public ListProduit()
        {
            InitializeComponent();
        }

        private void ListProduit_Load(object sender, EventArgs e)
        {
            GetProduit();
            selectedProduit.Text = "Aucun produit sélectionné !";
        }

        public void GetProduit()
        {
            string json = File.ReadAllText(jsonFilePath);

            List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(json);

            foreach (Produit produit in produits)
            {
                guna2DataGridView1.Rows.Add(produit.id, produit.name, produit.prix, produit.stock, produit.categories, produit.note);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateProduit update = new(this.Id, this.Name, this.Prix, this.Stock, this.Categorie, this.Note);
            if (this.Id != 0)
            {
                update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veillez sélectionné un produit ", "Erreur de paramètre d'entré ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    guna2DataGridView1.CurrentCell.Selected = true;
                    string nameProduit = guna2DataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                    int idProduit = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
                    double prixPro = double.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["prix"].FormattedValue.ToString());
                    string noteProduit = guna2DataGridView1.Rows[e.RowIndex].Cells["note"].FormattedValue.ToString();
                    string categoryProduit = guna2DataGridView1.Rows[e.RowIndex].Cells["category"].FormattedValue.ToString();
                    int stockProduit = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["stock"].FormattedValue.ToString());

                    this.Id = idProduit;
                    this.Name = nameProduit;
                    this.Prix = prixPro;
                    this.Note = noteProduit;
                    this.Categorie = categoryProduit;
                    this.Stock = stockProduit;
                    selectedProduit.Text = this.Name;
                }
                else
                {
                    MessageBox.Show("Aucun produit sélectionné ! ", "Choisissez un produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Aucun produit sélectionné ! ", "Choisissez un produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // function pour la Suppression de produit dans la listes
        public void SupprimerProduit(int id)
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(json);
            Produit produitASupprimer = produits.FirstOrDefault(p => p.id == id);

            if (produitASupprimer != null)
            {
                produits.Remove(produitASupprimer);
                string updatedJson = JsonConvert.SerializeObject(produits);
                File.WriteAllText("Data/Produit.json", updatedJson);
                selectedProduit.Text = "Aucun produit sélectionné !";
            }
        }

        //Event pour la suppression de produit
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (this.Id != 0)
            {
                SupprimerProduit(this.Id);
                guna2DataGridView1.Rows.Clear();
                GetProduit();
                this.Id = 0;
            }
            else
            {
                MessageBox.Show("Aucun produit a été sélectionné ! ", "Erreur de paramètre d'entré !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTxt.Text))
            {
                guna2DataGridView1.Rows.Clear();
                string json = File.ReadAllText("Data/Produit.json");
                List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(json);

                var resultats = produits.Where(p => p.name.Contains(searchTxt.Text)
                                                    || p.categories.Contains(searchTxt.Text)
                                                    || p.note.Contains(searchTxt.Text))
                                        .ToList();

                foreach (Produit produit in resultats)
                {

                    guna2DataGridView1.Rows.Add(produit.id, produit.name, produit.prix, produit.stock, produit.categories, produit.note);
                }

            }
            else
            {
                guna2DataGridView1.Rows.Clear();
                GetProduit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
