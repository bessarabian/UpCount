using System;
using System.Drawing;
using System.Windows.Forms;

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
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            using (AddExpenseForm form2 = new AddExpenseForm())
            {
                DialogResult dr = form2.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    switch(form2.curr_result)
                    {
                        case 0:
                            total1.Text = Convert.ToString(Convert.ToInt64(total1.Text) + Convert.ToInt64(form2.money_spent));
                            break;
                        case 1:
                            total2.Text = Convert.ToString(Convert.ToInt64(total2.Text) + Convert.ToInt64(form2.money_spent));
                            break;
                        case 2:
                            total3.Text = Convert.ToString(Convert.ToInt64(total3.Text) + Convert.ToInt64(form2.money_spent));
                            break;
                    }
                }
            }
        }

        private void Rem_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
