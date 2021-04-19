using System;
using System.Windows.Forms;

namespace IF4101_Lab1_Winform
{
    public partial class ManagerWindow : Form
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_managerTittle_Click(object sender, EventArgs e)
        {

        }

        private void chbx_managerAdd_Click(object sender, EventArgs e)
        {
            if (this.chbx_managerDelete.Checked)
            {
                this.setInvisibleDeleteComponets();
            }
            this.setVisibleAddComponents();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chbx_managerDelete_Click(object sender, EventArgs e)
        {
            if (this.chbx_managerAdd.Checked)
            {
                this.setInvisibleAddComponents();
            }
            this.setVisibleDeleteComponents();
        }

        private void setVisibleDeleteComponents()
        {
            this.lb_managerNameCountry.Visible = true;
            this.cmbx_managerCountries.Visible = true;
            this.btn_managerAdd.Text = "Delete";
            this.btn_managerAdd.Visible = true;
        }

        private void setVisibleAddComponents()
        {
            this.lb_managerNameCountry.Visible = true;
            this.lb_managerCurrency.Visible = true;
            this.txb_managerNameContry.Visible = true;
            this.cmbx_managerCurrency.Visible = true;
            this.btn_managerAdd.Text = "Add";
            this.btn_managerAdd.Visible = true;
        }

        private void setInvisibleDeleteComponets()
        {
            this.cmbx_managerCountries.Visible = false;
            this.chbx_managerDelete.Checked = false;
        }

        private void setInvisibleAddComponents()
        {
            this.lb_managerCurrency.Visible = false;
            this.txb_managerNameContry.Visible = false;
            this.cmbx_managerCurrency.Visible = false;
            this.chbx_managerAdd.Checked = false;
        }
    }
}
