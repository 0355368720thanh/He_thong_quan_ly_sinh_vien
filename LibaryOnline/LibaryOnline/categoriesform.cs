using LibaryOnline.queries;
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
    public partial class categoriesform : Form
    {
        public categoriesform()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void categoriesform_Load(object sender, EventArgs e)
        {
            // hien thi giao dien
            listViewcategories.View = View.Details;
            listViewcategories.GridLines = true;
            listViewcategories.FullRowSelect = true;

            // tao cot hien thi 
            listViewcategories.Columns.Add("ID", 50);
            listViewcategories.Columns.Add("Name", 150);
            listViewcategories.Columns.Add("Description", 250);
            listViewcategories.Columns.Add("Status", 50);
            listViewcategories.Columns.Add("Created At", 150);
            listViewcategories.Columns.Add("Updated At", 150);
            CategoriesQuery queryData = new CategoriesQuery();
            queryData.GetAllDataCategories(listViewcategories);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click_1(object sender, EventArgs e)
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

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            string nameCategory = txtname.Text.Trim();
            string descriptionCategory = txtdes.Text.Trim();
            string statusCategory = cboStatus.Text.Trim();
            if (string.IsNullOrEmpty(nameCategory))
            {
                MessageBox.Show("Name is not empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(statusCategory))
            {
                MessageBox.Show("Status is not empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //insert du lieu vao database
            CategoriesQuery query = new CategoriesQuery();
            int IdCate = query.InsertItemCategory(nameCategory, descriptionCategory, statusCategory);
            // do du lieu vao listview
            ListViewItem newItems = new ListViewItem(IdCate.ToString());
            //test insert id 
            newItems.SubItems.Add(nameCategory);
            newItems.SubItems.Add(descriptionCategory);
            newItems.SubItems.Add(statusCategory);
            newItems.SubItems.Add(DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss"));
            listViewcategories.Items.Add(newItems);
            //xoa het du lieu da nhap 
            txtname.Clear();
            txtdes.Clear();
            cboStatus.SelectedItem = null;
        }
    }
}
