namespace Enrolment_System
{
    partial class FrmMain
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblStudentDetails = new System.Windows.Forms.Label();
            this.BtnManageStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(249, 128);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 28);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblStudentDetails
            // 
            this.LblStudentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStudentDetails.Location = new System.Drawing.Point(12, 77);
            this.LblStudentDetails.Name = "LblStudentDetails";
            this.LblStudentDetails.Size = new System.Drawing.Size(231, 79);
            this.LblStudentDetails.TabIndex = 3;
            this.LblStudentDetails.Text = "-";
            // 
            // BtnManageStudents
            // 
            this.BtnManageStudents.Location = new System.Drawing.Point(12, 12);
            this.BtnManageStudents.Name = "BtnManageStudents";
            this.BtnManageStudents.Size = new System.Drawing.Size(139, 28);
            this.BtnManageStudents.TabIndex = 4;
            this.BtnManageStudents.Text = "Manage Students";
            this.BtnManageStudents.UseVisualStyleBackColor = true;
            this.BtnManageStudents.Click += new System.EventHandler(this.BtnManageStudents_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 168);
            this.Controls.Add(this.BtnManageStudents);
            this.Controls.Add(this.LblStudentDetails);
            this.Controls.Add(this.BtnClose);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblStudentDetails;
        private System.Windows.Forms.Button BtnManageStudents;
    }
}

