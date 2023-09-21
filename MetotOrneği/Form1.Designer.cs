namespace MetotOrneği
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnincrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(345, 78);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(10, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = " ";
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(49, 163);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(181, 54);
            this.btnDecrement.TabIndex = 2;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // btnincrement
            // 
            this.btnincrement.Location = new System.Drawing.Point(557, 163);
            this.btnincrement.Name = "btnincrement";
            this.btnincrement.Size = new System.Drawing.Size(181, 54);
            this.btnincrement.TabIndex = 3;
            this.btnincrement.Text = "+";
            this.btnincrement.UseVisualStyleBackColor = true;
            this.btnincrement.Click += new System.EventHandler(this.btnincrement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnincrement);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnincrement;
    }
}

