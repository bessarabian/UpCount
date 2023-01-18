using System;
using System.Drawing;
using System.Windows.Forms;
using Bankier;

namespace UpCount
{
    public partial class UpCount : Form
    {
        AddExpenseForm add_exp_from = new AddExpenseForm();

        public UpCount()
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
            add_exp_from.Show();
        }
    }
}
