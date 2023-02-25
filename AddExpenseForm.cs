using System.Windows.Forms;

namespace UpCount
{
    public partial class AddExpenseForm : Form
    {
        public double Money_spent { get; set; }
        public string Selected_category { get; set; }
        public Attribute.Currencies Curr_result { get; set; }
        public string Date { get; set; }
        public AddExpenseForm()
        {
            
            InitializeComponent();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            try
            {
                var cat = MainForm.db.Categories.ToList();
                List<string> res = new();
                foreach (var c in cat)
                {
                    res.Add(c.Name.ToString());
                }
                subject_cmbbox.DataSource = res;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You do not have any Categories! Add them by clicking \"Categories\" > \"Add\" ", "No Categories", MessageBoxButtons.OK);
            }
            currency_cmbbox.DataSource = Enum.GetValues(typeof(Attribute.Currencies));
            _ = Enum.TryParse(currency_cmbbox.SelectedValue.ToString(), result: out Attribute.Currencies _);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(amount_textbox.Text,out _))
            {
                Money_spent = Convert.ToDouble(amount_textbox.Text);
                Selected_category = subject_cmbbox.Text;
                string theDate = date_select.Value.ToShortDateString();
                Date = theDate;
                DialogResult = DialogResult.OK;

                switch (currency_cmbbox.SelectedItem)
                {
                    case Attribute.Currencies.BGN:
                        Curr_result = Attribute.Currencies.BGN;
                        break;
                    case Attribute.Currencies.USD:
                        Curr_result = Attribute.Currencies.USD;
                        break;
                    case Attribute.Currencies.EUR:
                        Curr_result = Attribute.Currencies.EUR;
                        break;
                }
                Close();
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}