using System;
using System.Windows.Forms;

namespace UpCount
{
    public partial class NewCategoryForm : Form
    {
        public NewCategoryForm()
        {
            InitializeComponent();
        }

        private void Cat_btn_Click(object sender, EventArgs e)
        {
            Category cat = new(new_cat_txtbox.Text);
            MainForm.db.Categories.Add(cat);
            MainForm.db.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
