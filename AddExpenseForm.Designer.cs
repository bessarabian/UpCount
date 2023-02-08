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
            this.label1 = new System.Windows.Forms.Label();
            this.subject_cmbbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.confirm_exp_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currency_cmbbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spent on:";
            // 
            // subject_cmbbox
            // 
            this.subject_cmbbox.FormattingEnabled = true;
            this.subject_cmbbox.Location = new System.Drawing.Point(33, 65);
            this.subject_cmbbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subject_cmbbox.Name = "subject_cmbbox";
            this.subject_cmbbox.Size = new System.Drawing.Size(259, 24);
            this.subject_cmbbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(33, 160);
            this.amount_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(259, 22);
            this.amount_textbox.TabIndex = 3;
            // 
            // confirm_exp_btn
            // 
            this.confirm_exp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_exp_btn.Location = new System.Drawing.Point(92, 353);
            this.confirm_exp_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_exp_btn.Name = "confirm_exp_btn";
            this.confirm_exp_btn.Size = new System.Drawing.Size(157, 57);
            this.confirm_exp_btn.TabIndex = 4;
            this.confirm_exp_btn.Text = "Confirm";
            this.confirm_exp_btn.UseVisualStyleBackColor = true;
            this.confirm_exp_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currency";
            // 
            // currency_cmbbox
            // 
            this.currency_cmbbox.FormattingEnabled = true;
            this.currency_cmbbox.Location = new System.Drawing.Point(33, 266);
            this.currency_cmbbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currency_cmbbox.Name = "currency_cmbbox";
            this.currency_cmbbox.Size = new System.Drawing.Size(259, 24);
            this.currency_cmbbox.TabIndex = 6;
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.currency_cmbbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm_exp_btn);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subject_cmbbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenseForm";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subject_cmbbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Button confirm_exp_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox currency_cmbbox;
    }
}