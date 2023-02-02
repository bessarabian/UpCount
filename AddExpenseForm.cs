using System;
using System.Windows.Forms;


namespace UpCount
{
    public partial class AddExpenseForm : Form
    {
        double default_double = 0.0;
        public double Money_spent { get; set; }
        public Attribute.Currencies Curr_result { get; set; }
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            subject_cmbbox.DataSource = 
            currency_cmbbox.DataSource = Enum.GetValues(typeof(Attribute.Currencies));
            Attribute.Currencies currency;
            Enum.TryParse(currency_cmbbox.SelectedValue.ToString(), result: out currency);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(amount_textbox.Text,out default_double))
            {
                Money_spent = Convert.ToDouble(amount_textbox.Text);
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
    }
}