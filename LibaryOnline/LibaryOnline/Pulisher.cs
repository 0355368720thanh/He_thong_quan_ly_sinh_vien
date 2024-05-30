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
    public partial class Pulisher : Form
    {
        public Pulisher()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btbak_Click(object sender, EventArgs e)
        {
            string message = " Are you sure?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
        }

        private void Pulisher_Load(object sender, EventArgs e)
        {
            listViewPulisher.View = View.Details;
            listViewPulisher.GridLines = true;
            listViewPulisher.FullRowSelect = true;
        }
    }

}
