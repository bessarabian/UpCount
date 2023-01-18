namespace UpCount
{
    partial class UpCount
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
            this.rem_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recent_exp_pnl = new System.Windows.Forms.Panel();
            this.recent_exp_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.general_sum_pnl = new System.Windows.Forms.Panel();
            this.total_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vert_line = new System.Windows.Forms.Label();
            this.detail_tab = new System.Windows.Forms.TabPage();
            this.category_tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.recent_exp_pnl.SuspendLayout();
            this.general_sum_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main_tab);
            this.tabControl1.Controls.Add(this.detail_tab);
            this.tabControl1.Controls.Add(this.category_tab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // main_tab
            // 
            this.main_tab.BackColor = System.Drawing.Color.Transparent;
            this.main_tab.Controls.Add(this.rem_btn);
            this.main_tab.Controls.Add(this.add_btn);
            this.main_tab.Controls.Add(this.panel2);
            this.main_tab.Controls.Add(this.panel1);
            this.main_tab.Controls.Add(this.general_sum_pnl);
            this.main_tab.Controls.Add(this.label2);
            this.main_tab.Controls.Add(this.vert_line);
            this.main_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_tab.Location = new System.Drawing.Point(4, 31);
            this.main_tab.Margin = new System.Windows.Forms.Padding(4);
            this.main_tab.Name = "main_tab";
            this.main_tab.Padding = new System.Windows.Forms.Padding(4);
            this.main_tab.Size = new System.Drawing.Size(1282, 641);
            this.main_tab.TabIndex = 0;
            this.main_tab.Text = "Main";
            // 
            // rem_btn
            // 
            this.rem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rem_btn.Location = new System.Drawing.Point(489, 467);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(134, 53);
            this.rem_btn.TabIndex = 8;
            this.rem_btn.Text = "Remove";
            this.rem_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(77, 467);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(134, 53);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.recent_exp_pnl);
            this.panel2.Location = new System.Drawing.Point(23, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 330);
            this.panel2.TabIndex = 6;
            // 
            // recent_exp_pnl
            // 
            this.recent_exp_pnl.BackColor = System.Drawing.Color.Transparent;
            this.recent_exp_pnl.Controls.Add(this.recent_exp_lbl);
            this.recent_exp_pnl.Location = new System.Drawing.Point(0, 0);
            this.recent_exp_pnl.Name = "recent_exp_pnl";
            this.recent_exp_pnl.Size = new System.Drawing.Size(423, 57);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(453, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 273);
            this.panel1.TabIndex = 5;
            // 
            // general_sum_pnl
            // 
            this.general_sum_pnl.BackColor = System.Drawing.Color.Transparent;
            this.general_sum_pnl.Controls.Add(this.total_lbl);
            this.general_sum_pnl.Location = new System.Drawing.Point(453, 45);
            this.general_sum_pnl.Name = "general_sum_pnl";
            this.general_sum_pnl.Size = new System.Drawing.Size(246, 57);
            this.general_sum_pnl.TabIndex = 4;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_lbl.Location = new System.Drawing.Point(3, 9);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(81, 36);
            this.total_lbl.TabIndex = 1;
            this.total_lbl.Text = "Total";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(-14, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(741, 3);
            this.label2.TabIndex = 3;
            // 
            // vert_line
            // 
            this.vert_line.BackColor = System.Drawing.Color.DarkGray;
            this.vert_line.Location = new System.Drawing.Point(725, -13);
            this.vert_line.Name = "vert_line";
            this.vert_line.Size = new System.Drawing.Size(2, 651);
            this.vert_line.TabIndex = 2;
            // 
            // detail_tab
            // 
            this.detail_tab.Location = new System.Drawing.Point(4, 31);
            this.detail_tab.Margin = new System.Windows.Forms.Padding(4);
            this.detail_tab.Name = "detail_tab";
            this.detail_tab.Padding = new System.Windows.Forms.Padding(4);
            this.detail_tab.Size = new System.Drawing.Size(1664, 700);
            this.detail_tab.TabIndex = 1;
            this.detail_tab.Text = "Details";
            this.detail_tab.UseVisualStyleBackColor = true;
            // 
            // category_tab
            // 
            this.category_tab.Location = new System.Drawing.Point(4, 31);
            this.category_tab.Margin = new System.Windows.Forms.Padding(4);
            this.category_tab.Name = "category_tab";
            this.category_tab.Padding = new System.Windows.Forms.Padding(4);
            this.category_tab.Size = new System.Drawing.Size(1664, 700);
            this.category_tab.TabIndex = 2;
            this.category_tab.Text = "Categories";
            this.category_tab.UseVisualStyleBackColor = true;
            // 
            // UpCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 671);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpCount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.main_tab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.recent_exp_pnl.ResumeLayout(false);
            this.recent_exp_pnl.PerformLayout();
            this.general_sum_pnl.ResumeLayout(false);
            this.general_sum_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage main_tab;
        private System.Windows.Forms.TabPage detail_tab;
        private System.Windows.Forms.TabPage category_tab;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label vert_line;
        private System.Windows.Forms.Panel general_sum_pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel recent_exp_pnl;
        private System.Windows.Forms.Label recent_exp_lbl;
    }
}

