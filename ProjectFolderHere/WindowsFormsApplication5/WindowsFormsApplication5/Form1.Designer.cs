namespace WindowsFormsApplication5
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
            this.uxFindPrimesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxOutputBox = new System.Windows.Forms.TextBox();
            this.uxInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxFindPrimesBtn
            // 
            this.uxFindPrimesBtn.Location = new System.Drawing.Point(104, 40);
            this.uxFindPrimesBtn.Name = "uxFindPrimesBtn";
            this.uxFindPrimesBtn.Size = new System.Drawing.Size(75, 23);
            this.uxFindPrimesBtn.TabIndex = 0;
            this.uxFindPrimesBtn.Text = "Find Primes";
            this.uxFindPrimesBtn.UseVisualStyleBackColor = true;
            this.uxFindPrimesBtn.Click += new System.EventHandler(this.uxFindPrimesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter positive bound:";
            // 
            // uxOutputBox
            // 
            this.uxOutputBox.Location = new System.Drawing.Point(12, 74);
            this.uxOutputBox.Multiline = true;
            this.uxOutputBox.Name = "uxOutputBox";
            this.uxOutputBox.ReadOnly = true;
            this.uxOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxOutputBox.Size = new System.Drawing.Size(260, 175);
            this.uxOutputBox.TabIndex = 2;
            // 
            // uxInputBox
            // 
            this.uxInputBox.Location = new System.Drawing.Point(125, 10);
            this.uxInputBox.Name = "uxInputBox";
            this.uxInputBox.Size = new System.Drawing.Size(147, 20);
            this.uxInputBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxInputBox);
            this.Controls.Add(this.uxOutputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxFindPrimesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxFindPrimesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxOutputBox;
        private System.Windows.Forms.TextBox uxInputBox;
    }
}

