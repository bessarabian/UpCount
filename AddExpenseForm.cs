using System;
using System.Windows.Forms;

namespace UpCount
{
    public partial class AddExpenseForm : Form
    {
        double default_double = 0.0;
        public double money_spent { get; set; }
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            currency_cmbbox.Items.Add("Dollar(s) $");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(amount_textbox.Text,out default_double))
            {
                money_spent = Convert.ToDouble(amount_textbox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
