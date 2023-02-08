using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UpCount
{
    public partial class CategoriesForm : Form
    {

        public CategoriesForm()
        {
            InitializeComponent();
            /*RefreshCategories();*/
        }

        /*public void RefreshCategories(){
            cat_listbox.DataSource = MainForm.db_ctrl.GetAllCategories();
        }*/

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cat_btn_Click(object sender, EventArgs e)
        {
            using(NewCategoryForm newcat_form = new NewCategoryForm())
            {
                DialogResult dr = newcat_form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    /*RefreshCategories();*/
                }
            }
        }
    }
}
