using System;
using System.Windows.Forms;


namespace UpCount
{
    public partial class AddExpenseForm : Form
    {
        double default_double = 0.0;
        public double money_spent { get; set; }
        public int curr_result { get; set; }
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            currency_cmbbox.DataSource = Enum.GetValues(typeof(Currency.Currencies));
            Currency.Currencies currency;
            Enum.TryParse(currency_cmbbox.SelectedValue.ToString(), out currency);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(amount_textbox.Text,out default_double))
            {
                money_spent = Convert.ToDouble(amount_textbox.Text);
                DialogResult = DialogResult.OK;

                switch (currency_cmbbox.SelectedItem)
                {
                    case Currency.Currencies.BGN:
                        curr_result = 0;
                        break;
                    case Currency.Currencies.USD:
                        curr_result = 1;
                        break;
                    case Currency.Currencies.EUR:
                        curr_result = 2;
                        break;
                }
                Close();
            }
        }
    }
}
