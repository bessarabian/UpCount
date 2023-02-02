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
    public partial class NewCategoryForm : Form
    {
        public string category_name { get; set; }
        public NewCategoryForm()
        {
            InitializeComponent();
        }

        private void Cat_btn_Click(object sender, EventArgs e)
        {
            MainForm.db_ctrl.DatabaseInsertCategory(new_cat_txtbox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
