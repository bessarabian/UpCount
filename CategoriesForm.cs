using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpCount
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            /*cat_listbox.DataSource = */
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cat_btn_Click(object sender, EventArgs e)
        {
            using(NewCategoryForm newcat_form = new NewCategoryForm())
            {
                DialogResult dr = newcat_form.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    Console.WriteLine("Cat name: " + newcat_form.category_name);
                }
            }
        }
    }
}
