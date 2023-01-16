using System;
using System.Windows.Forms;
using Bankier;

namespace UpCount
{
    public partial class UpCount : Form
    {
        public UpCount()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bankier.Bankier.abob();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(amount_exp.Value);
            total_label.Text = (int.Parse(total_label.Text) + num).ToString();
        }
    }
}
