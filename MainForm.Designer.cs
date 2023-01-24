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
            this.eur_lbl = new System.Windows.Forms.Label();
            this.eur_pan = new System.Windows.Forms.Panel();
            this.bgn_pan = new System.Windows.Forms.Panel();
            this.bgn_lbl = new System.Windows.Forms.Label();
            this.total3 = new System.Windows.Forms.Label();
            this.total2 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.bgn_total = new System.Windows.Forms.Panel();
            this.rem_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recent_exp_pnl = new System.Windows.Forms.Panel();
            this.recent_exp_lbl = new System.Windows.Forms.Label();
            this.general_sum_pnl = new System.Windows.Forms.Panel();
            this.total_lbl = new System.Windows.Forms.Label();
            this.usd_total = new System.Windows.Forms.Panel();
            this.eur_total = new System.Windows.Forms.Panel();
            this.usd_pan = new System.Windows.Forms.Panel();
            this.usd_lbl = new System.Windows.Forms.Label();
            this.detail_tab = new System.Windows.Forms.TabPage();
            this.charts_tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.bgn_pan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.recent_exp_pnl.SuspendLayout();
            this.general_sum_pnl.SuspendLayout();
            this.usd_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main_tab);
            this.tabControl1.Controls.Add(this.detail_tab);
            this.tabControl1.Controls.Add(this.charts_tab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1291, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // main_tab
            // 
            this.main_tab.BackColor = System.Drawing.Color.Transparent;
            this.main_tab.Controls.Add(this.button1);
            this.main_tab.Controls.Add(this.eur_lbl);
            this.main_tab.Controls.Add(this.eur_pan);
            this.main_tab.Controls.Add(this.bgn_pan);
            this.main_tab.Controls.Add(this.total3);
            this.main_tab.Controls.Add(this.total2);
            this.main_tab.Controls.Add(this.total1);
            this.main_tab.Controls.Add(this.bgn_total);
            this.main_tab.Controls.Add(this.rem_btn);
            this.main_tab.Controls.Add(this.add_btn);
            this.main_tab.Controls.Add(this.panel2);
            this.main_tab.Controls.Add(this.general_sum_pnl);
            this.main_tab.Controls.Add(this.usd_total);
            this.main_tab.Controls.Add(this.eur_total);
            this.main_tab.Controls.Add(this.usd_pan);
            this.main_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_tab.Location = new System.Drawing.Point(4, 31);
            this.main_tab.Margin = new System.Windows.Forms.Padding(4);
            this.main_tab.Name = "main_tab";
            this.main_tab.Padding = new System.Windows.Forms.Padding(4);
            this.main_tab.Size = new System.Drawing.Size(1283, 641);
            this.main_tab.TabIndex = 0;
            this.main_tab.Text = "Main";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adjust Categories";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eur_lbl
            // 
            this.eur_lbl.AutoSize = true;
            this.eur_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eur_lbl.Location = new System.Drawing.Point(1118, 306);
            this.eur_lbl.Name = "eur_lbl";
            this.eur_lbl.Size = new System.Drawing.Size(64, 25);
            this.eur_lbl.TabIndex = 2;
            this.eur_lbl.Text = "label3";
            // 
            // eur_pan
            // 
            this.eur_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eur_pan.Location = new System.Drawing.Point(1115, 289);
            this.eur_pan.Name = "eur_pan";
            this.eur_pan.Size = new System.Drawing.Size(75, 59);
            this.eur_pan.TabIndex = 17;
            // 
            // bgn_pan
            // 
            this.bgn_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bgn_pan.Controls.Add(this.bgn_lbl);
            this.bgn_pan.Location = new System.Drawing.Point(1115, 134);
            this.bgn_pan.Name = "bgn_pan";
            this.bgn_pan.Size = new System.Drawing.Size(75, 59);
            this.bgn_pan.TabIndex = 15;
            // 
            // bgn_lbl
            // 
            this.bgn_lbl.AutoSize = true;
            this.bgn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bgn_lbl.Location = new System.Drawing.Point(3, 15);
            this.bgn_lbl.Name = "bgn_lbl";
            this.bgn_lbl.Size = new System.Drawing.Size(64, 25);
            this.bgn_lbl.TabIndex = 0;
            this.bgn_lbl.Text = "label1";
            // 
            // total3
            // 
            this.total3.AutoSize = true;
            this.total3.Location = new System.Drawing.Point(742, 303);
            this.total3.Name = "total3";
            this.total3.Size = new System.Drawing.Size(29, 31);
            this.total3.TabIndex = 11;
            this.total3.Text = "0";
            // 
            // total2
            // 
            this.total2.AutoSize = true;
            this.total2.Location = new System.Drawing.Point(742, 226);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(29, 31);
            this.total2.TabIndex = 10;
            this.total2.Text = "0";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Location = new System.Drawing.Point(742, 149);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(29, 31);
            this.total1.TabIndex = 9;
            this.total1.Text = "0";
            // 
            // bgn_total
            // 
            this.bgn_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bgn_total.Location = new System.Drawing.Point(739, 134);
            this.bgn_total.Name = "bgn_total";
            this.bgn_total.Size = new System.Drawing.Size(361, 59);
            this.bgn_total.TabIndex = 12;
            // 
            // rem_btn
            // 
            this.rem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rem_btn.Location = new System.Drawing.Point(1056, 466);
            this.rem_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(133, 53);
            this.rem_btn.TabIndex = 8;
            this.rem_btn.Text = "Undo";
            this.rem_btn.UseVisualStyleBackColor = true;
            this.rem_btn.Click += new System.EventHandler(this.Rem_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(739, 466);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 53);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.recent_exp_pnl);
            this.panel2.Location = new System.Drawing.Point(23, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 330);
            this.panel2.TabIndex = 6;
            // 
            // recent_exp_pnl
            // 
            this.recent_exp_pnl.BackColor = System.Drawing.Color.Transparent;
            this.recent_exp_pnl.Controls.Add(this.recent_exp_lbl);
            this.recent_exp_pnl.Location = new System.Drawing.Point(0, 0);
            this.recent_exp_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recent_exp_pnl.Name = "recent_exp_pnl";
            this.recent_exp_pnl.Size = new System.Drawing.Size(597, 57);
            this.recent_exp_pnl.TabIndex = 5;
            // 
            // recent_exp_lbl
            // 
            this.recent_exp_lbl.AutoSize = true;
            this.recent_exp_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recent_exp_lbl.Location = new System.Drawing.Point(3, 9);
            this.recent_exp_lbl.Name = "recent_exp_lbl";
            this.recent_exp_lbl.Size = new System.Drawing.Size(244, 36);
            this.recent_exp_lbl.TabIndex = 1;
            this.recent_exp_lbl.Text = "Recent expenses";
            // 
            // general_sum_pnl
            // 
            this.general_sum_pnl.BackColor = System.Drawing.Color.Transparent;
            this.general_sum_pnl.Controls.Add(this.total_lbl);
            this.general_sum_pnl.Location = new System.Drawing.Point(739, 46);
            this.general_sum_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.general_sum_pnl.Name = "general_sum_pnl";
            this.general_sum_pnl.Size = new System.Drawing.Size(451, 57);
            this.general_sum_pnl.TabIndex = 4;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_lbl.Location = new System.Drawing.Point(3, 9);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(121, 36);
            this.total_lbl.TabIndex = 1;
            this.total_lbl.Text = "Total in:";
            // 
            // usd_total
            // 
            this.usd_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usd_total.Location = new System.Drawing.Point(739, 212);
            this.usd_total.Name = "usd_total";
            this.usd_total.Size = new System.Drawing.Size(361, 59);
            this.usd_total.TabIndex = 13;
            // 
            // eur_total
            // 
            this.eur_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eur_total.Location = new System.Drawing.Point(739, 289);
            this.eur_total.Name = "eur_total";
            this.eur_total.Size = new System.Drawing.Size(361, 59);
            this.eur_total.TabIndex = 14;
            // 
            // usd_pan
            // 
            this.usd_pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usd_pan.Controls.Add(this.usd_lbl);
            this.usd_pan.Location = new System.Drawing.Point(1115, 212);
            this.usd_pan.Name = "usd_pan";
            this.usd_pan.Size = new System.Drawing.Size(75, 59);
            this.usd_pan.TabIndex = 16;
            // 
            // usd_lbl
            // 
            this.usd_lbl.AutoSize = true;
            this.usd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usd_lbl.Location = new System.Drawing.Point(3, 14);
            this.usd_lbl.Name = "usd_lbl";
            this.usd_lbl.Size = new System.Drawing.Size(64, 25);
            this.usd_lbl.TabIndex = 1;
            this.usd_lbl.Text = "label2";
            // 
            // detail_tab
            // 
            this.detail_tab.Location = new System.Drawing.Point(4, 31);
            this.detail_tab.Margin = new System.Windows.Forms.Padding(4);
            this.detail_tab.Name = "detail_tab";
            this.detail_tab.Padding = new System.Windows.Forms.Padding(4);
            this.detail_tab.Size = new System.Drawing.Size(1283, 641);
            this.detail_tab.TabIndex = 1;
            this.detail_tab.Text = "Details";
            this.detail_tab.UseVisualStyleBackColor = true;
            // 
            // charts_tab
            // 
            this.charts_tab.Location = new System.Drawing.Point(4, 31);
            this.charts_tab.Margin = new System.Windows.Forms.Padding(4);
            this.charts_tab.Name = "charts_tab";
            this.charts_tab.Padding = new System.Windows.Forms.Padding(4);
            this.charts_tab.Size = new System.Drawing.Size(1283, 641);
            this.charts_tab.TabIndex = 3;
            this.charts_tab.Text = "Charts";
            this.charts_tab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 671);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpCount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.main_tab.ResumeLayout(false);
            this.main_tab.PerformLayout();
            this.bgn_pan.ResumeLayout(false);
            this.bgn_pan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.recent_exp_pnl.ResumeLayout(false);
            this.recent_exp_pnl.PerformLayout();
            this.general_sum_pnl.ResumeLayout(false);
            this.general_sum_pnl.PerformLayout();
            this.usd_pan.ResumeLayout(false);
            this.usd_pan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main_tab;
        private System.Windows.Forms.TabPage detail_tab;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Panel general_sum_pnl;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel recent_exp_pnl;
        private System.Windows.Forms.Label recent_exp_lbl;
        private System.Windows.Forms.TabPage charts_tab;
        private System.Windows.Forms.Panel eur_pan;
        private System.Windows.Forms.Panel usd_pan;
        private System.Windows.Forms.Panel bgn_pan;
        private System.Windows.Forms.Label total3;
        private System.Windows.Forms.Label total2;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.Panel bgn_total;
        private System.Windows.Forms.Panel usd_total;
        private System.Windows.Forms.Panel eur_total;
        private System.Windows.Forms.Label eur_lbl;
        private System.Windows.Forms.Label usd_lbl;
        private System.Windows.Forms.Label bgn_lbl;
        private System.Windows.Forms.Button button1;
    }
}

