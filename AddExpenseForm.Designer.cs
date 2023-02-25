namespace UpCount
{
    partial class AddExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spenton_label = new System.Windows.Forms.Label();
            this.subject_cmbbox = new System.Windows.Forms.ComboBox();
            this.amnt_label = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.confirm_exp_btn = new System.Windows.Forms.Button();
            this.curr_label = new System.Windows.Forms.Label();
            this.currency_cmbbox = new System.Windows.Forms.ComboBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.date_select = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // spenton_label
            // 
            this.spenton_label.AutoSize = true;
            this.spenton_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spenton_label.Location = new System.Drawing.Point(28, 29);
            this.spenton_label.Name = "spenton_label";
            this.spenton_label.Size = new System.Drawing.Size(87, 22);
            this.spenton_label.TabIndex = 0;
            this.spenton_label.Text = "Spent on:";
            // 
            // subject_cmbbox
            // 
            this.subject_cmbbox.FormattingEnabled = true;
            this.subject_cmbbox.Location = new System.Drawing.Point(33, 63);
            this.subject_cmbbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subject_cmbbox.Name = "subject_cmbbox";
            this.subject_cmbbox.Size = new System.Drawing.Size(259, 28);
            this.subject_cmbbox.TabIndex = 1;
            // 
            // amnt_label
            // 
            this.amnt_label.AutoSize = true;
            this.amnt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amnt_label.Location = new System.Drawing.Point(28, 107);
            this.amnt_label.Name = "amnt_label";
            this.amnt_label.Size = new System.Drawing.Size(76, 22);
            this.amnt_label.TabIndex = 2;
            this.amnt_label.Text = "Amount:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(33, 140);
            this.amount_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(259, 27);
            this.amount_textbox.TabIndex = 3;
            // 
            // confirm_exp_btn
            // 
            this.confirm_exp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_exp_btn.Location = new System.Drawing.Point(33, 449);
            this.confirm_exp_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_exp_btn.Name = "confirm_exp_btn";
            this.confirm_exp_btn.Size = new System.Drawing.Size(109, 39);
            this.confirm_exp_btn.TabIndex = 4;
            this.confirm_exp_btn.Text = "Confirm";
            this.confirm_exp_btn.UseVisualStyleBackColor = true;
            this.confirm_exp_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // curr_label
            // 
            this.curr_label.AutoSize = true;
            this.curr_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curr_label.Location = new System.Drawing.Point(28, 190);
            this.curr_label.Name = "curr_label";
            this.curr_label.Size = new System.Drawing.Size(88, 22);
            this.curr_label.TabIndex = 5;
            this.curr_label.Text = "Currency:";
            // 
            // currency_cmbbox
            // 
            this.currency_cmbbox.FormattingEnabled = true;
            this.currency_cmbbox.Location = new System.Drawing.Point(33, 229);
            this.currency_cmbbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currency_cmbbox.Name = "currency_cmbbox";
            this.currency_cmbbox.Size = new System.Drawing.Size(259, 28);
            this.currency_cmbbox.TabIndex = 6;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.Location = new System.Drawing.Point(183, 449);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(109, 39);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_label.Location = new System.Drawing.Point(33, 276);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(53, 22);
            this.date_label.TabIndex = 8;
            this.date_label.Text = "Date:";
            // 
            // date_select
            // 
            this.date_select.Location = new System.Drawing.Point(33, 316);
            this.date_select.Name = "date_select";
            this.date_select.Size = new System.Drawing.Size(259, 27);
            this.date_select.TabIndex = 9;
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 562);
            this.Controls.Add(this.date_select);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.currency_cmbbox);
            this.Controls.Add(this.curr_label);
            this.Controls.Add(this.confirm_exp_btn);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.amnt_label);
            this.Controls.Add(this.subject_cmbbox);
            this.Controls.Add(this.spenton_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenseForm";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spenton_label;
        private System.Windows.Forms.ComboBox subject_cmbbox;
        private System.Windows.Forms.Label amnt_label;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Button confirm_exp_btn;
        private System.Windows.Forms.Label curr_label;
        private System.Windows.Forms.ComboBox currency_cmbbox;
        private Button cancel_btn;
        private Label date_label;
        private DateTimePicker date_select;
    }
}