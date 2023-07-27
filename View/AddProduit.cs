using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AddProduit : UserControl
    {
        public AddProduit()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        public void AddProduct(string name, double prix, int stock, string categorie, string note)
        {
            string json = File.ReadAllText("Data/Produit.json");
            List<Produit> produits = JsonConvert.DeserializeObject<List<Produit>>(json);
            int idProd = 0;
            try
            {
                int maxId = produits.Max(x => x.id);
                idProd = maxId + 1;

            }
            catch (Exception ex)
            {
                idProd = 1;
            }


            Produit produit = new Produit
            {
                id = idProd,
                name = name,
                prix = prix,
                stock = stock,
                categories = categorie,
                note = note
            };


            produits.Add(produit);
            string updatedJson = JsonConvert.SerializeObject(produits, Formatting.Indented);
            File.WriteAllText("Data/Produit.json", updatedJson);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nomProduitTxt.Text))
            {
                if (!string.IsNullOrWhiteSpace(guna2ComboBox1.Text))
                {
                    if (prixProduitTxt.Value > 100)
                    {
                        if (stockProduitTxt.Value > 0)
                        {
                            AddProduct(nomProduitTxt.Text, (double)prixProduitTxt.Value, (int)stockProduitTxt.Value, guna2ComboBox1.Text, descriptionProduitTxt.Text);
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

        private void ajouterCategorie_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                string categori = File.ReadAllText("Data/Categorie.json");
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(categori);

                int idCategorie = 0;
                try
                {
                    int maxid = categories.Max(x => x.Id);
                    idCategorie = maxid + 1;
                }
                catch (Exception ex)
                {
                    idCategorie = 1;
                }

                Category category = new Category
                {
                    Id = idCategorie,
                    Categorie = guna2TextBox1.Text
                };

                categories.Add(category);
                string updatedJson = JsonConvert.SerializeObject(categories, Formatting.Indented);
                File.WriteAllText("Data/Categorie.json", updatedJson);
                MessageBox.Show("Catégorie " + guna2TextBox1.Text + " Ajouté !", "Traitement effectué !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2TextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Veillez remplir le champ catégorie ", "Erreur de paramètre d'entré!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            guna2ComboBox1.Items.Clear();
            ChargerCategories(guna2ComboBox1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduit_Load(object sender, EventArgs e)
        {
            ChargerCategories(guna2ComboBox1);
        }

        public void ChargerCategories(ComboBox guna2ComboBox1)
        {
            string json = File.ReadAllText("Data/Categorie.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            foreach (Category category in categories)
            {
                guna2ComboBox1.Items.Add(category.Categorie);
            }
        }
    }
}
