namespace Coffee_Managment_System
{
    partial class Form_TestingDB
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
            this.btShow = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 25F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Page Testing with MySql  Database";
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(272, 304);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(202, 56);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "Connection";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(132, 150);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(500, 111);
            this.tbResult.TabIndex = 2;
            // 
            // Form_TestingDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 452);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form_TestingDB";
            this.Text = "Form Connection Database using MySql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.TextBox tbResult;
    }
}

