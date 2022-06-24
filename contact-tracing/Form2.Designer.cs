
namespace contact_tracing
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
            this.ReadFileBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.RecordsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReadFileBttn
            // 
            this.ReadFileBttn.Location = new System.Drawing.Point(13, 13);
            this.ReadFileBttn.Name = "ReadFileBttn";
            this.ReadFileBttn.Size = new System.Drawing.Size(75, 23);
            this.ReadFileBttn.TabIndex = 0;
            this.ReadFileBttn.Text = "Read File";
            this.ReadFileBttn.UseVisualStyleBackColor = true;
            this.ReadFileBttn.Click += new System.EventHandler(this.ReadFileBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(776, 336);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(75, 23);
            this.ExitBttn.TabIndex = 1;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // RecordsBox
            // 
            this.RecordsBox.FormattingEnabled = true;
            this.RecordsBox.Location = new System.Drawing.Point(13, 43);
            this.RecordsBox.Name = "RecordsBox";
            this.RecordsBox.Size = new System.Drawing.Size(838, 277);
            this.RecordsBox.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 371);
            this.Controls.Add(this.RecordsBox);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.ReadFileBttn);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadFileBttn;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.ListBox RecordsBox;
    }
}