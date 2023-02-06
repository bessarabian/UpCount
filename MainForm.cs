using MongoDB.Driver;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;


namespace UpCount
{
    public partial class MainForm : Form
    {
        public static DB_Control db_ctrl;
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
            recent_exp.Font = new Font("Arial", 12, FontStyle.Regular);
            recent_exp.AutoResizeColumns();
            recent_exp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GetAllExpenses();
        }

        public void GetAllExpenses()
        {
            var db = db_ctrl.dbClient.GetDatabase("consumptions");
            var coll = db.GetCollection<Expense>("expenses");

            List<Expense> exp = coll.AsQueryable().ToList();

            recent_exp.DataSource = exp;
        }

        public void UpdateTotals()
        {
            total1.Text = db_ctrl.GetAllExpensesByCurrency(Attribute.Currencies.BGN);
            total2.Text = db_ctrl.GetAllExpensesByCurrency(Attribute.Currencies.USD);
            total3.Text = db_ctrl.GetAllExpensesByCurrency(Attribute.Currencies.EUR);
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            using (AddExpenseForm form2 = new AddExpenseForm())
            {
                DialogResult dr = form2.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    switch(form2.Curr_result)
                    {
                        case Attribute.Currencies.BGN:
                            total1.Text = Convert.ToString(Convert.ToInt64(total1.Text) + Convert.ToInt64(form2.Money_spent));
                            break;
                        case Attribute.Currencies.USD:
                            total2.Text = Convert.ToString(Convert.ToInt64(total2.Text) + Convert.ToInt64(form2.Money_spent));
                            break;
                        case Attribute.Currencies.EUR:
                            total3.Text = Convert.ToString(Convert.ToInt64(total3.Text) + Convert.ToInt64(form2.Money_spent));
                            break;
                    }

                    string date = DateTime.Now.ToString("dd/MM/yyyy");
                    db_ctrl.DatabaseInsertExpense(date, form2.Money_spent, form2.Curr_result.ToString(), form2.Selected_category.ToString());
                    GetAllExpenses();
                    UpdateTotals();
                }
            }
        }

        private void category_btn(object sender, EventArgs e)
        {
            using(CategoriesForm cat_form = new CategoriesForm())
            {
                DialogResult dr = cat_form.ShowDialog();
            }
        }
    }
}
