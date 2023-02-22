using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;

namespace UpCount
{
    public partial class MainForm : Form
    {
        public static UpContext db = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // proper colors for panels
            recent_exp_pnl.BackColor = Color.FromArgb(86, 113, 137);
            recent_exp_lbl.ForeColor = Color.White;

            // rigth currency simbols
            bgn_lbl.Text = Attribute.Currencies.BGN.ToString();
            usd_lbl.Text = Attribute.Currencies.USD.ToString();
            eur_lbl.Text = Attribute.Currencies.EUR.ToString();

            // total spents
            UpdateTotals();

            // datagridview setup
            GetAllExpenses();
            recent_exp.Font = new Font("Arial", 12, FontStyle.Regular);
            recent_exp.AutoResizeColumns();
            recent_exp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recent_exp.Columns["ID"].Visible = false;


        }

        public void GetAllExpenses()
        {
            var list = db.Expenses.ToList();
            recent_exp.DataSource = list;
        }

        public string GetTotalByCurerency(string currency)
        {
            var all = db.Expenses.ToList();
            List<Expense> sorted = all.Where(x => x.Currency == currency).ToList();
            double sum = 0;

            foreach (var i in sorted)
            {
                sum += i.Amount;
            }

            return sum.ToString();
        }


        public void UpdateTotals()
        {
            total1.Text = GetTotalByCurerency("BGN").ToString();
            total2.Text = GetTotalByCurerency("USD").ToString();
            total3.Text = GetTotalByCurerency("EUR").ToString();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

            using (AddExpenseForm form2 = new())
            {
                DialogResult dr = form2.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    switch (form2.Curr_result)
                    {
                        case Attribute.Currencies.BGN:
                            total1.Text = Convert.ToString(Convert.ToDouble(total1.Text) + Convert.ToDouble(form2.Money_spent));
                            break;
                        case Attribute.Currencies.USD:
                            total2.Text = Convert.ToString(Convert.ToDouble(total2.Text) + Convert.ToDouble(form2.Money_spent));
                            break;
                        case Attribute.Currencies.EUR:
                            total3.Text = Convert.ToString(Convert.ToDouble(total3.Text) + Convert.ToDouble(form2.Money_spent));
                            break;
                    }
                    string date = DateTime.Now.ToString("dd/MM/yyyy");
                    Expense expense = new(form2.Money_spent, date, form2.Curr_result.ToString(), form2.Selected_category);
                    db.Expenses.Add(expense);
                    db.SaveChanges();
                    GetAllExpenses();
                }
            }
        }

        private void category_btn(object sender, EventArgs e)
        {
            using CategoriesForm cat_form = new();
            {
                DialogResult dr = cat_form.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int selectedRowCount =
                recent_exp.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    var val = recent_exp[0, recent_exp.SelectedRows[i].Index].Value.ToString();

                    var res = db.Expenses.SingleOrDefault(x => x.Id == int.Parse(val));

                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(res))
                    {
                        string name = descriptor.Name;
                        object value = descriptor.GetValue(res);
                        Console.WriteLine("{0}={1}", name, value);
                    }

                    db.Remove(res);
                    db.SaveChanges();
                }
            }

            GetAllExpenses();
        }
    }
}
