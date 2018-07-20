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
            this.BtnCreateStudent = new System.Windows.Forms.Button();
            this.BtnModifyStudent = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblStudentDetails = new System.Windows.Forms.Label();
            this.CboStudentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreateStudent
            // 
            this.BtnCreateStudent.Location = new System.Drawing.Point(12, 12);
            this.BtnCreateStudent.Name = "BtnCreateStudent";
            this.BtnCreateStudent.Size = new System.Drawing.Size(119, 28);
            this.BtnCreateStudent.TabIndex = 0;
            this.BtnCreateStudent.Text = "Create Student";
            this.BtnCreateStudent.UseVisualStyleBackColor = true;
            this.BtnCreateStudent.Click += new System.EventHandler(this.BtnCreateStudent_Click);
            // 
            // BtnModifyStudent
            // 
            this.BtnModifyStudent.Location = new System.Drawing.Point(12, 46);
            this.BtnModifyStudent.Name = "BtnModifyStudent";
            this.BtnModifyStudent.Size = new System.Drawing.Size(119, 28);
            this.BtnModifyStudent.TabIndex = 1;
            this.BtnModifyStudent.Text = "Modify Student";
            this.BtnModifyStudent.UseVisualStyleBackColor = true;
            this.BtnModifyStudent.Click += new System.EventHandler(this.BtnModifyStudent_Click);
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
            // CboStudentType
            // 
            this.CboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStudentType.FormattingEnabled = true;
            this.CboStudentType.Location = new System.Drawing.Point(137, 12);
            this.CboStudentType.Name = "CboStudentType";
            this.CboStudentType.Size = new System.Drawing.Size(187, 24);
            this.CboStudentType.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 168);
            this.Controls.Add(this.CboStudentType);
            this.Controls.Add(this.LblStudentDetails);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnModifyStudent);
            this.Controls.Add(this.BtnCreateStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateStudent;
        private System.Windows.Forms.Button BtnModifyStudent;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblStudentDetails;
        private System.Windows.Forms.ComboBox CboStudentType;
    }
}

