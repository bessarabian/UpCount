namespace UpCount
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.main_tab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cat_btn = new System.Windows.Forms.Button();
            this.recent_exp_pnl = new System.Windows.Forms.Panel();
            this.recent_exp_lbl = new System.Windows.Forms.Label();
            this.bgn_pan = new System.Windows.Forms.Panel();
            this.bgn_lbl = new System.Windows.Forms.Label();
            this.usd_pan = new System.Windows.Forms.Panel();
            this.usd_lbl = new System.Windows.Forms.Label();
            this.eur_lbl = new System.Windows.Forms.Label();
            this.eur_pan = new System.Windows.Forms.Panel();
            this.total3 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.bgn_total = new System.Windows.Forms.Panel();
            this.rem_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recent_exp = new System.Windows.Forms.DataGridView();
            this.usd_total = new System.Windows.Forms.Panel();
            this.total2 = new System.Windows.Forms.Label();
            this.eur_total = new System.Windows.Forms.Panel();
            this.six = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.five = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.four = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.one = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.recent_exp_pnl.SuspendLayout();
            this.bgn_pan.SuspendLayout();
            this.usd_pan.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recent_exp)).BeginInit();
            this.usd_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main_tab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // main_tab
            // 
            this.main_tab.BackColor = System.Drawing.Color.Transparent;
            this.main_tab.Controls.Add(this.button1);
            this.main_tab.Controls.Add(this.cat_btn);
            this.main_tab.Controls.Add(this.recent_exp_pnl);
            this.main_tab.Controls.Add(this.bgn_pan);
            this.main_tab.Controls.Add(this.usd_pan);
            this.main_tab.Controls.Add(this.eur_lbl);
            this.main_tab.Controls.Add(this.eur_pan);
            this.main_tab.Controls.Add(this.total3);
            this.main_tab.Controls.Add(this.total1);
            this.main_tab.Controls.Add(this.bgn_total);
            this.main_tab.Controls.Add(this.rem_btn);
            this.main_tab.Controls.Add(this.add_btn);
            this.main_tab.Controls.Add(this.panel2);
            this.main_tab.Controls.Add(this.usd_total);
            this.main_tab.Controls.Add(this.eur_total);
            this.main_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_tab.Location = new System.Drawing.Point(4, 33);
            this.main_tab.Name = "main_tab";
            this.main_tab.Padding = new System.Windows.Forms.Padding(3);
            this.main_tab.Size = new System.Drawing.Size(1171, 563);
            this.main_tab.TabIndex = 0;
            this.main_tab.Text = "Main";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(995, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cat_btn
            // 
            this.cat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cat_btn.Location = new System.Drawing.Point(79, 486);
            this.cat_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cat_btn.Name = "cat_btn";
            this.cat_btn.Size = new System.Drawing.Size(100, 43);
            this.cat_btn.TabIndex = 18;
            this.cat_btn.Text = "Categories";
            this.cat_btn.UseVisualStyleBackColor = true;
            this.cat_btn.Click += new System.EventHandler(this.category_btn);
            // 
            // recent_exp_pnl
            // 
            this.recent_exp_pnl.BackColor = System.Drawing.Color.Transparent;
            this.recent_exp_pnl.Controls.Add(this.recent_exp_lbl);
            this.recent_exp_pnl.Location = new System.Drawing.Point(17, 37);
            this.recent_exp_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.recent_exp_pnl.Name = "recent_exp_pnl";
            this.recent_exp_pnl.Size = new System.Drawing.Size(1145, 46);
            this.recent_exp_pnl.TabIndex = 5;
            // 
            // recent_exp_lbl
            // 
            this.recent_exp_lbl.AutoSize = true;
            this.recent_exp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recent_exp_lbl.Location = new System.Drawing.Point(473, 7);
            this.recent_exp_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recent_exp_lbl.Name = "recent_exp_lbl";
            this.recent_exp_lbl.Size = new System.Drawing.Size(199, 29);
            this.recent_exp_lbl.TabIndex = 1;
            this.recent_exp_lbl.Text = "Recent expenses";
            // 
            // bgn_pan
            // 
            this.bgn_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bgn_pan.Controls.Add(this.bgn_lbl);
            this.bgn_pan.Location = new System.Drawing.Point(286, 391);
            this.bgn_pan.Margin = new System.Windows.Forms.Padding(2);
            this.bgn_pan.Name = "bgn_pan";
            this.bgn_pan.Size = new System.Drawing.Size(57, 49);
            this.bgn_pan.TabIndex = 15;
            // 
            // bgn_lbl
            // 
            this.bgn_lbl.AutoSize = true;
            this.bgn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bgn_lbl.Location = new System.Drawing.Point(3, 13);
            this.bgn_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bgn_lbl.Name = "bgn_lbl";
            this.bgn_lbl.Size = new System.Drawing.Size(51, 20);
            this.bgn_lbl.TabIndex = 0;
            this.bgn_lbl.Text = "label1";
            // 
            // usd_pan
            // 
            this.usd_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usd_pan.Controls.Add(this.usd_lbl);
            this.usd_pan.Location = new System.Drawing.Point(672, 391);
            this.usd_pan.Margin = new System.Windows.Forms.Padding(2);
            this.usd_pan.Name = "usd_pan";
            this.usd_pan.Size = new System.Drawing.Size(57, 49);
            this.usd_pan.TabIndex = 16;
            // 
            // usd_lbl
            // 
            this.usd_lbl.AutoSize = true;
            this.usd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usd_lbl.Location = new System.Drawing.Point(2, 13);
            this.usd_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usd_lbl.Name = "usd_lbl";
            this.usd_lbl.Size = new System.Drawing.Size(51, 20);
            this.usd_lbl.TabIndex = 1;
            this.usd_lbl.Text = "label2";
            // 
            // eur_lbl
            // 
            this.eur_lbl.AutoSize = true;
            this.eur_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eur_lbl.Location = new System.Drawing.Point(1044, 406);
            this.eur_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eur_lbl.Name = "eur_lbl";
            this.eur_lbl.Size = new System.Drawing.Size(51, 20);
            this.eur_lbl.TabIndex = 2;
            this.eur_lbl.Text = "label3";
            // 
            // eur_pan
            // 
            this.eur_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eur_pan.Location = new System.Drawing.Point(1041, 391);
            this.eur_pan.Margin = new System.Windows.Forms.Padding(2);
            this.eur_pan.Name = "eur_pan";
            this.eur_pan.Size = new System.Drawing.Size(57, 49);
            this.eur_pan.TabIndex = 17;
            // 
            // total3
            // 
            this.total3.AutoSize = true;
            this.total3.Location = new System.Drawing.Point(829, 402);
            this.total3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total3.Name = "total3";
            this.total3.Size = new System.Drawing.Size(26, 29);
            this.total3.TabIndex = 11;
            this.total3.Text = "0";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Location = new System.Drawing.Point(74, 403);
            this.total1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(26, 29);
            this.total1.TabIndex = 9;
            this.total1.Text = "0";
            // 
            // bgn_total
            // 
            this.bgn_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bgn_total.Location = new System.Drawing.Point(72, 391);
            this.bgn_total.Margin = new System.Windows.Forms.Padding(2);
            this.bgn_total.Name = "bgn_total";
            this.bgn_total.Size = new System.Drawing.Size(272, 49);
            this.bgn_total.TabIndex = 12;
            // 
            // rem_btn
            // 
            this.rem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rem_btn.Location = new System.Drawing.Point(680, 486);
            this.rem_btn.Margin = new System.Windows.Forms.Padding(2);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(100, 43);
            this.rem_btn.TabIndex = 8;
            this.rem_btn.Text = "Undo Last";
            this.rem_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(385, 486);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 43);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.recent_exp);
            this.panel2.Location = new System.Drawing.Point(17, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 328);
            this.panel2.TabIndex = 6;
            // 
            // recent_exp
            // 
            this.recent_exp.AllowUserToAddRows = false;
            this.recent_exp.AllowUserToDeleteRows = false;
            this.recent_exp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recent_exp.Location = new System.Drawing.Point(1, 39);
            this.recent_exp.Name = "recent_exp";
            this.recent_exp.ReadOnly = true;
            this.recent_exp.Size = new System.Drawing.Size(1144, 290);
            this.recent_exp.TabIndex = 0;
            // 
            // usd_total
            // 
            this.usd_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usd_total.Controls.Add(this.total2);
            this.usd_total.Location = new System.Drawing.Point(457, 391);
            this.usd_total.Margin = new System.Windows.Forms.Padding(2);
            this.usd_total.Name = "usd_total";
            this.usd_total.Size = new System.Drawing.Size(272, 49);
            this.usd_total.TabIndex = 13;
            // 
            // total2
            // 
            this.total2.AutoSize = true;
            this.total2.Location = new System.Drawing.Point(2, 10);
            this.total2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(26, 29);
            this.total2.TabIndex = 10;
            this.total2.Text = "0";
            // 
            // eur_total
            // 
            this.eur_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eur_total.Location = new System.Drawing.Point(827, 391);
            this.eur_total.Margin = new System.Windows.Forms.Padding(2);
            this.eur_total.Name = "eur_total";
            this.eur_total.Size = new System.Drawing.Size(272, 49);
            this.eur_total.TabIndex = 14;
            // 
            // six
            // 
            this.six.HeaderText = "six_column";
            this.six.Name = "six";
            this.six.ReadOnly = true;
            // 
            // five
            // 
            this.five.HeaderText = "five_column";
            this.five.Name = "five";
            this.five.ReadOnly = true;
            // 
            // four
            // 
            this.four.HeaderText = "four_column";
            this.four.Name = "four";
            this.four.ReadOnly = true;
            // 
            // tree
            // 
            this.tree.HeaderText = "tree_column";
            this.tree.Name = "tree";
            this.tree.ReadOnly = true;
            // 
            // two
            // 
            this.two.HeaderText = "two_column";
            this.two.Name = "two";
            this.two.ReadOnly = true;
            // 
            // one
            // 
            this.one.HeaderText = "one_column";
            this.one.Name = "one";
            this.one.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 602);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpCount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.main_tab.ResumeLayout(false);
            this.main_tab.PerformLayout();
            this.recent_exp_pnl.ResumeLayout(false);
            this.recent_exp_pnl.PerformLayout();
            this.bgn_pan.ResumeLayout(false);
            this.bgn_pan.PerformLayout();
            this.usd_pan.ResumeLayout(false);
            this.usd_pan.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recent_exp)).EndInit();
            this.usd_total.ResumeLayout(false);
            this.usd_total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main_tab;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel recent_exp_pnl;
        private System.Windows.Forms.Label recent_exp_lbl;
        private System.Windows.Forms.Panel eur_pan;
        private System.Windows.Forms.Panel bgn_pan;
        private System.Windows.Forms.Label total3;
        private System.Windows.Forms.Label total2;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.Panel bgn_total;
        private System.Windows.Forms.Panel usd_total;
        private System.Windows.Forms.Panel eur_total;
        private System.Windows.Forms.Label eur_lbl;
        private System.Windows.Forms.Label bgn_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn six;
        private System.Windows.Forms.DataGridViewTextBoxColumn five;
        private System.Windows.Forms.DataGridViewTextBoxColumn four;
        private System.Windows.Forms.DataGridViewTextBoxColumn tree;
        private System.Windows.Forms.DataGridViewTextBoxColumn two;
        private System.Windows.Forms.DataGridViewTextBoxColumn one;
        private System.Windows.Forms.DataGridView recent_exp;
        private System.Windows.Forms.Panel usd_pan;
        private System.Windows.Forms.Label usd_lbl;
        private System.Windows.Forms.Button cat_btn;
        private System.Windows.Forms.Button button1;
    }
}

