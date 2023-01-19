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
            general_sum_pnl.BackColor = Color.FromArgb(86, 113, 137);
            recent_exp_pnl.BackColor = Color.FromArgb(86, 113, 137);
            total_lbl.ForeColor = Color.White;
            recent_exp_lbl.ForeColor = Color.White;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            using (AddExpenseForm form2 = new AddExpenseForm())
            {
                DialogResult dr = form2.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    db_ctrl.DatabaseInsert(form2.money_spent);
                    var sum = Convert.ToDouble(total_spent.Text) + form2.money_spent;
                    total_spent.Text = Convert.ToString(sum);

                }
            }
        }
    }
}
