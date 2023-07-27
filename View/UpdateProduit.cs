using Newtonsoft.Json;
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

namespace SMC3.View
{
    public partial class UpdateProduit : Form
    {

        public int id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public int stock { get; set; }
        public double prix { get; set; }
        public string categorie { get; set; }


        public UpdateProduit(int id, string name, double prix, int stock, string categorie, string note)
        {
            this.id = id;
            this.name = name;
            this.note = note;
            this.stock = stock;
            this.prix = prix;
            this.categorie = categorie;
            InitializeComponent();
        }

        private void categoryProduitTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProduit_Load(object sender, EventArgs e)
        {
            nomProduitTxt.Text = name;
            categoryProduitTxt.Text = categorie;
            descriptionProduitTxt.Text = note;
            prixProduitTxt.Value = (decimal)prix;
            stockProduitTxt.Value = stock;
            categoryProduitTxt.Text = categorie;
        }

        public void UpdateProduits(string name, double prix, int stock, string categorie, string note)
        {
            string json = File.ReadAllText("Data/Produit.json");
            List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(json);

            Produit productToUpdate = produits.FirstOrDefault(p => p.id == this.id);
            if (productToUpdate != null)
            {
                productToUpdate.name = name;
                productToUpdate.prix = prix;
                productToUpdate.categories = categorie;
                productToUpdate.stock = stock;
                productToUpdate.note = note;

                // Sauvegarder les modifications dans le fichier JSON
                string updatedJson = JsonConvert.SerializeObject(produits);
                File.WriteAllText("Data/Produit.json", updatedJson);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nomProduitTxt.Text))
            {
                if (!string.IsNullOrWhiteSpace(categoryProduitTxt.Text))
                {
                    if (prixProduitTxt.Value > 100)
                    {
                        if (stockProduitTxt.Value > 0)
                        {
                            UpdateProduits(nomProduitTxt.Text, (double)prixProduitTxt.Value, (int)stockProduitTxt.Value, categoryProduitTxt.Text, descriptionProduitTxt.Text);
                            MessageBox.Show("Vous avez ajouté " + nomProduitTxt.Text, "Traitement effectué avec succés !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Le stock de produit doit superieur à 0 ", "Erreur de paramètre d'entré!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le prix du produit est trop faible ", "Erreur de paramètre d'entré!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Veillez choisir un categorie ", "Erreur de paramètre d'entré!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Veillez remplir le champ nom du produit ", "Erreur de paramètre d'entré!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
