using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace UpCount
{
    public partial class MainForm : Form
    {
        DB_Control db_ctrl = new DB_Control("mongodb://localhost:27017"); // replace with smth decent in the end
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // proper colors for panels
            general_sum_pnl.BackColor = Color.FromArgb(86, 113, 137);
            recent_exp_pnl.BackColor = Color.FromArgb(86, 113, 137);
            total_lbl.ForeColor = Color.White;
            recent_exp_lbl.ForeColor = Color.White;

            // rigth currency simbols
            bgn_lbl.Text = Currency.Currencies.BGN.ToString();
            usd_lbl.Text = Currency.Currencies.USD.ToString();
            eur_lbl.Text = Currency.Currencies.EUR.ToString();

            // filling datagridview
            var coll = db_ctrl.GetCollect("consumptions", "expenses").Find(new BsonDocument()).ToList();

            List<Expense> exp = new List<Expense>();

            foreach(var i in coll)
            {
                exp.Add(BsonSerializer.Deserialize<Expense>(i));
            }

            foreach(var i in exp)
            {
                Console.WriteLine(i);
            }
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
                        case Currency.Currencies.BGN:
                            total1.Text = Convert.ToString(Convert.ToInt64(total1.Text) + Convert.ToInt64(form2.money_spent));
                            break;
                        case Currency.Currencies.USD:
                            total2.Text = Convert.ToString(Convert.ToInt64(total2.Text) + Convert.ToInt64(form2.money_spent));
                            break;
                        case Currency.Currencies.EUR:
                            total3.Text = Convert.ToString(Convert.ToInt64(total3.Text) + Convert.ToInt64(form2.money_spent));
                            break;
                    }
                    db_ctrl.DatabaseInsertExpense(form2.money_spent, "mock", form2.Curr_result);
                }
            }
        }

        private void Rem_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
