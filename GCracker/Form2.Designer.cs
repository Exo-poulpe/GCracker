namespace GCracker
{
    partial class Form2
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
            this.lblPasswordFound = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasswordFound
            // 
            this.lblPasswordFound.AutoSize = true;
            this.lblPasswordFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordFound.Location = new System.Drawing.Point(62, 35);
            this.lblPasswordFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordFound.Name = "lblPasswordFound";
            this.lblPasswordFound.Size = new System.Drawing.Size(152, 20);
            this.lblPasswordFound.TabIndex = 0;
            this.lblPasswordFound.Text = "PasswordFound : ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(64, 70);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 13);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Date time of start : ";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(64, 92);
            this.lblDateEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(94, 13);
            this.lblDateEnd.TabIndex = 2;
            this.lblDateEnd.Text = "Date time of end : ";
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(196, 136);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(62, 24);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(294, 137);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 171);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPasswordFound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordFound;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnOpen;
    }
}