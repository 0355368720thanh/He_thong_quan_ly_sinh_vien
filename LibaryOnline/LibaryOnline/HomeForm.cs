using LibaryOnline.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryOnline
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            string message = " Are you sure?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            labusername.Text = logininfo.nameuser;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

            categoriesform categoriesform = new categoriesform();
            categoriesform.Show();
            this.Hide();

        }

        private void btnPulisher_Click(object sender, EventArgs e)
        {
            Pulisher publisher = new Pulisher();
            publisher.Show();
            this.Hide();
        }
    }
}
