namespace Enrolment_System
{
    partial class FrmStudent
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.LblProgrammes = new System.Windows.Forms.Label();
            this.LstProgrammes = new System.Windows.Forms.ListBox();
            this.DtpDOB = new System.Windows.Forms.DateTimePicker();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(370, 12);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 28);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(370, 46);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 28);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(77, 32);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(21, 17);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(53, 60);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 17);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Name";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(12, 90);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(86, 17);
            this.LblDOB.TabIndex = 4;
            this.LblDOB.Text = "Date of birth";
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Location = new System.Drawing.Point(27, 116);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(71, 17);
            this.LblBalance.TabIndex = 5;
            this.LblBalance.Text = "Balance $";
            // 
            // LblProgrammes
            // 
            this.LblProgrammes.AutoSize = true;
            this.LblProgrammes.Location = new System.Drawing.Point(310, 118);
            this.LblProgrammes.Name = "LblProgrammes";
            this.LblProgrammes.Size = new System.Drawing.Size(88, 17);
            this.LblProgrammes.TabIndex = 6;
            this.LblProgrammes.Text = "Programmes";
            // 
            // LstProgrammes
            // 
            this.LstProgrammes.FormattingEnabled = true;
            this.LstProgrammes.ItemHeight = 16;
            this.LstProgrammes.Location = new System.Drawing.Point(313, 143);
            this.LstProgrammes.Name = "LstProgrammes";
            this.LstProgrammes.Size = new System.Drawing.Size(132, 116);
            this.LstProgrammes.TabIndex = 7;
            // 
            // DtpDOB
            // 
            this.DtpDOB.Location = new System.Drawing.Point(104, 85);
            this.DtpDOB.Name = "DtpDOB";
            this.DtpDOB.Size = new System.Drawing.Size(229, 22);
            this.DtpDOB.TabIndex = 8;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(104, 29);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(104, 57);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 10;
            // 
            // TxtBalance
            // 
            this.TxtBalance.Location = new System.Drawing.Point(104, 113);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(100, 22);
            this.TxtBalance.TabIndex = 11;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 271);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DtpDOB);
            this.Controls.Add(this.LstProgrammes);
            this.Controls.Add(this.LblProgrammes);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Name = "FrmStudent";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Label LblProgrammes;
        private System.Windows.Forms.ListBox LstProgrammes;
        private System.Windows.Forms.DateTimePicker DtpDOB;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtBalance;
    }
}