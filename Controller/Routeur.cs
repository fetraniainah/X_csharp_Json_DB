using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC
{
    internal class Routeur
    {

       

        private UserControl childForm = null;
        public  void GetUserControl(UserControl childForm, Panel childPanel)
        {
            if (this.childForm != null)
                if (this.childForm != null)
                {
                    this.childForm.Visible = false;
                }

            this.childForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Visible = true;
        }
    }
}
