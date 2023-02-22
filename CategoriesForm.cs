using System.Windows.Forms;

namespace UpCount
{
    public partial class CategoriesForm : Form
    {

        public CategoriesForm()
        {
            InitializeComponent();
            RefreshCategories();
        }

        public void RefreshCategories()
        {
            var all_categories = MainForm.db.Categories.ToList();
            List<string> names = new List<string>();
            foreach (var category in all_categories)
            {
                names.Add(category.Name);
            }

            cat_listbox.DataSource = names;
        }

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
                    RefreshCategories();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(cat_listbox.SelectedItems.Count > 0)
            {
                foreach (var item in cat_listbox.SelectedItems)
                {
                    var res = MainForm.db.Categories.SingleOrDefault(x => x.Name == item.ToString());

                    MainForm.db.Remove(res);
                    MainForm.db.SaveChanges();
                }

                RefreshCategories();
            }
            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
