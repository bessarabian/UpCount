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
    }
}
