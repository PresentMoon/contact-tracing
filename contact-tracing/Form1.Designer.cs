
namespace contact_tracing
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ContactNumLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeInLabel = new System.Windows.Forms.Label();
            this.TimeOutLabel = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.ContactNumTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DateTxtBox = new System.Windows.Forms.TextBox();
            this.TimeInTxtBox = new System.Windows.Forms.TextBox();
            this.TimeOutTxtBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // ContactNumLabel
            // 
            this.ContactNumLabel.AutoSize = true;
            this.ContactNumLabel.Location = new System.Drawing.Point(11, 69);
            this.ContactNumLabel.Name = "ContactNumLabel";
            this.ContactNumLabel.Size = new System.Drawing.Size(57, 13);
            this.ContactNumLabel.TabIndex = 1;
            this.ContactNumLabel.Text = "Contact#:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(11, 171);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(50, 13);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(296, 21);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(34, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date:";
            // 
            // TimeInLabel
            // 
            this.TimeInLabel.AutoSize = true;
            this.TimeInLabel.Location = new System.Drawing.Point(296, 69);
            this.TimeInLabel.Name = "TimeInLabel";
            this.TimeInLabel.Size = new System.Drawing.Size(46, 13);
            this.TimeInLabel.TabIndex = 4;
            this.TimeInLabel.Text = "Time In:";
            // 
            // TimeOutLabel
            // 
            this.TimeOutLabel.AutoSize = true;
            this.TimeOutLabel.Location = new System.Drawing.Point(296, 119);
            this.TimeOutLabel.Name = "TimeOutLabel";
            this.TimeOutLabel.Size = new System.Drawing.Size(54, 13);
            this.TimeOutLabel.TabIndex = 5;
            this.TimeOutLabel.Text = "Time Out:";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(12, 37);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(254, 21);
            this.NameTxtBox.TabIndex = 6;
            // 
            // ContactNumTxtBox
            // 
            this.ContactNumTxtBox.Location = new System.Drawing.Point(12, 85);
            this.ContactNumTxtBox.Name = "ContactNumTxtBox";
            this.ContactNumTxtBox.Size = new System.Drawing.Size(254, 21);
            this.ContactNumTxtBox.TabIndex = 7;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(11, 187);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(470, 21);
            this.AddressTxtBox.TabIndex = 8;
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.Location = new System.Drawing.Point(296, 37);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.Size = new System.Drawing.Size(185, 21);
            this.DateTxtBox.TabIndex = 9;
            // 
            // TimeInTxtBox
            // 
            this.TimeInTxtBox.Location = new System.Drawing.Point(296, 85);
            this.TimeInTxtBox.Name = "TimeInTxtBox";
            this.TimeInTxtBox.Size = new System.Drawing.Size(185, 21);
            this.TimeInTxtBox.TabIndex = 10;
            // 
            // TimeOutTxtBox
            // 
            this.TimeOutTxtBox.Location = new System.Drawing.Point(296, 135);
            this.TimeOutTxtBox.Name = "TimeOutTxtBox";
            this.TimeOutTxtBox.Size = new System.Drawing.Size(185, 21);
            this.TimeOutTxtBox.TabIndex = 11;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(12, 228);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(469, 52);
            this.EnterButton.TabIndex = 12;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(11, 119);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(30, 13);
            this.AgeLabel.TabIndex = 13;
            this.AgeLabel.Text = "Age:";
            // 
            // AgeTxtBox
            // 
            this.AgeTxtBox.Location = new System.Drawing.Point(11, 135);
            this.AgeTxtBox.Name = "AgeTxtBox";
            this.AgeTxtBox.Size = new System.Drawing.Size(125, 21);
            this.AgeTxtBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 292);
            this.Controls.Add(this.AgeTxtBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.TimeOutTxtBox);
            this.Controls.Add(this.TimeInTxtBox);
            this.Controls.Add(this.DateTxtBox);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.ContactNumTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.TimeOutLabel);
            this.Controls.Add(this.TimeInLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ContactNumLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ContactNumLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeInLabel;
        private System.Windows.Forms.Label TimeOutLabel;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox ContactNumTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.TextBox DateTxtBox;
        private System.Windows.Forms.TextBox TimeInTxtBox;
        private System.Windows.Forms.TextBox TimeOutTxtBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTxtBox;
    }
}