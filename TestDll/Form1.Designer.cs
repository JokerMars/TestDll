namespace TestDll
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_one = new System.Windows.Forms.TextBox();
            this.txtbox_two = new System.Windows.Forms.TextBox();
            this.txtbox_product = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_one
            // 
            this.txtbox_one.Location = new System.Drawing.Point(64, 68);
            this.txtbox_one.Name = "txtbox_one";
            this.txtbox_one.Size = new System.Drawing.Size(76, 21);
            this.txtbox_one.TabIndex = 1;
            // 
            // txtbox_two
            // 
            this.txtbox_two.Location = new System.Drawing.Point(183, 68);
            this.txtbox_two.Name = "txtbox_two";
            this.txtbox_two.Size = new System.Drawing.Size(76, 21);
            this.txtbox_two.TabIndex = 2;
            // 
            // txtbox_product
            // 
            this.txtbox_product.Location = new System.Drawing.Point(64, 121);
            this.txtbox_product.Name = "txtbox_product";
            this.txtbox_product.ReadOnly = true;
            this.txtbox_product.Size = new System.Drawing.Size(76, 21);
            this.txtbox_product.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 294);
            this.Controls.Add(this.txtbox_product);
            this.Controls.Add(this.txtbox_two);
            this.Controls.Add(this.txtbox_one);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbox_one;
        private System.Windows.Forms.TextBox txtbox_two;
        private System.Windows.Forms.TextBox txtbox_product;
    }
}

