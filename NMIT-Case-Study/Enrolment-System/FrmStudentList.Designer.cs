namespace Enrolment_System
{
    partial class FrmStudentList
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
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LstStudents = new System.Windows.Forms.ListBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CboStudentType = new System.Windows.Forms.ComboBox();
            this.BtnModifyStudent = new System.Windows.Forms.Button();
            this.BtnCreateStudent = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(9, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(21, 17);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(119, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 17);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(291, 9);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(40, 17);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type";
            // 
            // LstStudents
            // 
            this.LstStudents.FormattingEnabled = true;
            this.LstStudents.ItemHeight = 16;
            this.LstStudents.Location = new System.Drawing.Point(12, 29);
            this.LstStudents.Name = "LstStudents";
            this.LstStudents.Size = new System.Drawing.Size(357, 116);
            this.LstStudents.TabIndex = 3;
            this.LstStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstStudents_MouseDoubleClick);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(294, 185);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 28);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CboStudentType
            // 
            this.CboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStudentType.FormattingEnabled = true;
            this.CboStudentType.Location = new System.Drawing.Point(182, 151);
            this.CboStudentType.Name = "CboStudentType";
            this.CboStudentType.Size = new System.Drawing.Size(187, 24);
            this.CboStudentType.TabIndex = 7;
            // 
            // BtnModifyStudent
            // 
            this.BtnModifyStudent.Location = new System.Drawing.Point(12, 185);
            this.BtnModifyStudent.Name = "BtnModifyStudent";
            this.BtnModifyStudent.Size = new System.Drawing.Size(119, 28);
            this.BtnModifyStudent.TabIndex = 6;
            this.BtnModifyStudent.Text = "Modify Student";
            this.BtnModifyStudent.UseVisualStyleBackColor = true;
            this.BtnModifyStudent.Click += new System.EventHandler(this.BtnModifyStudent_Click);
            // 
            // BtnCreateStudent
            // 
            this.BtnCreateStudent.Location = new System.Drawing.Point(12, 151);
            this.BtnCreateStudent.Name = "BtnCreateStudent";
            this.BtnCreateStudent.Size = new System.Drawing.Size(119, 28);
            this.BtnCreateStudent.TabIndex = 5;
            this.BtnCreateStudent.Text = "Create Student";
            this.BtnCreateStudent.UseVisualStyleBackColor = true;
            this.BtnCreateStudent.Click += new System.EventHandler(this.BtnCreateStudent_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(137, 185);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 28);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 227);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CboStudentType);
            this.Controls.Add(this.BtnModifyStudent);
            this.Controls.Add(this.BtnCreateStudent);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LstStudents);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Name = "FrmStudentList";
            this.Text = "Student List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.ListBox LstStudents;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CboStudentType;
        private System.Windows.Forms.Button BtnModifyStudent;
        private System.Windows.Forms.Button BtnCreateStudent;
        private System.Windows.Forms.Button BtnDelete;
    }
}