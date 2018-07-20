namespace Enrolment_System
{
    partial class FrmMOEStudent
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
            this.TxtLoanAmount = new System.Windows.Forms.TextBox();
            this.ChkFullTime = new System.Windows.Forms.CheckBox();
            this.LblLoanAmount = new System.Windows.Forms.Label();
            this.LblFullTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtLoanAmount
            // 
            this.TxtLoanAmount.Location = new System.Drawing.Point(104, 141);
            this.TxtLoanAmount.Name = "TxtLoanAmount";
            this.TxtLoanAmount.Size = new System.Drawing.Size(100, 22);
            this.TxtLoanAmount.TabIndex = 12;
            // 
            // ChkFullTime
            // 
            this.ChkFullTime.AutoSize = true;
            this.ChkFullTime.Location = new System.Drawing.Point(104, 169);
            this.ChkFullTime.Name = "ChkFullTime";
            this.ChkFullTime.Size = new System.Drawing.Size(18, 17);
            this.ChkFullTime.TabIndex = 13;
            this.ChkFullTime.UseVisualStyleBackColor = true;
            // 
            // LblLoanAmount
            // 
            this.LblLoanAmount.AutoSize = true;
            this.LblLoanAmount.Location = new System.Drawing.Point(18, 144);
            this.LblLoanAmount.Name = "LblLoanAmount";
            this.LblLoanAmount.Size = new System.Drawing.Size(80, 17);
            this.LblLoanAmount.TabIndex = 14;
            this.LblLoanAmount.Text = "Loan Amt $";
            // 
            // LblFullTime
            // 
            this.LblFullTime.AutoSize = true;
            this.LblFullTime.Location = new System.Drawing.Point(33, 169);
            this.LblFullTime.Name = "LblFullTime";
            this.LblFullTime.Size = new System.Drawing.Size(65, 17);
            this.LblFullTime.TabIndex = 15;
            this.LblFullTime.Text = "Full Time";
            // 
            // FrmMOEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(457, 271);
            this.Controls.Add(this.LblFullTime);
            this.Controls.Add(this.LblLoanAmount);
            this.Controls.Add(this.ChkFullTime);
            this.Controls.Add(this.TxtLoanAmount);
            this.Name = "FrmMOEStudent";
            this.Controls.SetChildIndex(this.TxtLoanAmount, 0);
            this.Controls.SetChildIndex(this.ChkFullTime, 0);
            this.Controls.SetChildIndex(this.LblLoanAmount, 0);
            this.Controls.SetChildIndex(this.LblFullTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLoanAmount;
        private System.Windows.Forms.CheckBox ChkFullTime;
        private System.Windows.Forms.Label LblLoanAmount;
        private System.Windows.Forms.Label LblFullTime;
    }
}
