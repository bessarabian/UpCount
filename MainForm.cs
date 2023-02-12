using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace UpCount
{
    public partial class MainForm : Form
    {
        UpContext db = new();
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
            /*UpdateTotals();*/

            // datagridview setup
            recent_exp.DataSource = db.Expenses.ToList();
            recent_exp.Font = new Font("Arial", 12, FontStyle.Regular);
            recent_exp.AutoResizeColumns();
            recent_exp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void GetAllExpenses()
        {
            /*var db = db_ctrl.dbClient.GetDatabase("consumptions");
            var coll = db.GetCollection<Expense>("expenses");

            List<Expense> exp = coll.AsQueryable().ToList();

            recent_exp.DataSource = exp;*/
        }

        public void UpdateTotals()
        {
            /*total1.Text = db_ctrl.GetAllExpensesByCurrency(Attribute.Currencies.BGN);
            total2.Text = db_ctrl.GetAllExpensesByCurrency(Attribute.Currencies.USD);
            total3.Text = db_ctrl.GetAllExpensesByCurrency(Attribute.Currencies.EUR);*/
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            using (AddExpenseForm form2 = new())
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

                  
                    Expense expense = new(form2.Money_spent, date, form2.Curr_result.ToString(), form2.Selected_category);
                    db.Expenses.Add(expense);
                    db.SaveChanges();
                    Console.WriteLine("Objects are saved successfully!");

                    GetAllExpenses();
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

        private void Recent_exp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
