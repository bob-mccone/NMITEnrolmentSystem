namespace Enrolment_System
{
    partial class FrmInternationalStudent
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
            this.LblCountry = new System.Windows.Forms.Label();
            this.LblIELTS = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.TxtIELTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(41, 144);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(57, 17);
            this.LblCountry.TabIndex = 12;
            this.LblCountry.Text = "Country";
            // 
            // LblIELTS
            // 
            this.LblIELTS.AutoSize = true;
            this.LblIELTS.Location = new System.Drawing.Point(52, 172);
            this.LblIELTS.Name = "LblIELTS";
            this.LblIELTS.Size = new System.Drawing.Size(46, 17);
            this.LblIELTS.TabIndex = 13;
            this.LblIELTS.Text = "IELTS";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(104, 141);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(100, 22);
            this.TxtCountry.TabIndex = 14;
            // 
            // TxtIELTS
            // 
            this.TxtIELTS.Location = new System.Drawing.Point(104, 169);
            this.TxtIELTS.Name = "TxtIELTS";
            this.TxtIELTS.Size = new System.Drawing.Size(100, 22);
            this.TxtIELTS.TabIndex = 15;
            // 
            // FrmInternationalStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(457, 271);
            this.Controls.Add(this.TxtIELTS);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.LblIELTS);
            this.Controls.Add(this.LblCountry);
            this.Name = "FrmInternationalStudent";
            this.Controls.SetChildIndex(this.LblCountry, 0);
            this.Controls.SetChildIndex(this.LblIELTS, 0);
            this.Controls.SetChildIndex(this.TxtCountry, 0);
            this.Controls.SetChildIndex(this.TxtIELTS, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Label LblIELTS;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.TextBox TxtIELTS;
    }
}
