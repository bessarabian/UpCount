﻿namespace UpCount
{
    partial class CategoriesForm
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
            this.cat_listbox = new System.Windows.Forms.ListBox();
            this.cat_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cat_listbox
            // 
            this.cat_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cat_listbox.FormattingEnabled = true;
            this.cat_listbox.ItemHeight = 24;
            this.cat_listbox.Location = new System.Drawing.Point(12, 12);
            this.cat_listbox.Name = "cat_listbox";
            this.cat_listbox.Size = new System.Drawing.Size(317, 316);
            this.cat_listbox.TabIndex = 0;
            this.cat_listbox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // cat_btn
            // 
            this.cat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cat_btn.Location = new System.Drawing.Point(12, 371);
            this.cat_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cat_btn.Name = "cat_btn";
            this.cat_btn.Size = new System.Drawing.Size(100, 43);
            this.cat_btn.TabIndex = 19;
            this.cat_btn.Text = "Add";
            this.cat_btn.UseVisualStyleBackColor = true;
            this.cat_btn.Click += new System.EventHandler(this.Cat_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(229, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cat_btn);
            this.Controls.Add(this.cat_listbox);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cat_listbox;
        private System.Windows.Forms.Button cat_btn;
        private System.Windows.Forms.Button button1;
    }
}