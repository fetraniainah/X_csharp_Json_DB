using SMC;
using SMC3.View;

namespace SMC3
{
    public partial class Form1 : Form
    {
        internal Routeur routeur;

        public bool isShow = false;

        public Form1()
        {
            InitializeComponent();
            if (isShow == true)
            {
                Routeur routeur = new Routeur();
                routeur.GetUserControl(new ListProduit(), panel2);
            }
        }

        public Panel InitialisePanel()
        {
            return this.panel2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new ListProduit(), panel2);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new ListProduit(), panel2);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Routeur routeur = new Routeur();
            routeur.GetUserControl(new AddProduit(), panel2);
        }
    }
}