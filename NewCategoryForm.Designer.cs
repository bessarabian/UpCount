namespace UpCount
{
    partial class NewCategoryForm
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
            this.new_cat_txtbox = new System.Windows.Forms.TextBox();
            this.cat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_cat_txtbox
            // 
            this.new_cat_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_cat_txtbox.Location = new System.Drawing.Point(12, 37);
            this.new_cat_txtbox.Name = "new_cat_txtbox";
            this.new_cat_txtbox.Size = new System.Drawing.Size(280, 29);
            this.new_cat_txtbox.TabIndex = 0;
            // 
            // cat_btn
            // 
            this.cat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cat_btn.Location = new System.Drawing.Point(102, 88);
            this.cat_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cat_btn.Name = "cat_btn";
            this.cat_btn.Size = new System.Drawing.Size(100, 43);
            this.cat_btn.TabIndex = 20;
            this.cat_btn.Text = "Add";
            this.cat_btn.UseVisualStyleBackColor = true;
            this.cat_btn.Click += new System.EventHandler(this.Cat_btn_Click);
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 155);
            this.Controls.Add(this.new_cat_txtbox);
            this.Controls.Add(this.cat_btn);
            this.Name = "NewCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_cat_txtbox;
        private System.Windows.Forms.Button cat_btn;
    }
}