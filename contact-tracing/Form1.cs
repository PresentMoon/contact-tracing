using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            //Following the format sir showed earlier

            StreamWriter file = new StreamWriter(@"C:\Users\user\Documents\Contacts Traced\contacts.txt",true);
            file.WriteLine("Name: " + NameTxtBox.Text);
            file.WriteLine("Contact#: " + ContactNumTxtBox.Text);
            file.WriteLine("Address: " + AddressTxtBox.Text);
            file.WriteLine("Date: " + DateTxtBox.Text);
            file.WriteLine("Time In: " + TimeInTxtBox.Text);
            file.WriteLine("Time Out: " + TimeOutTxtBox.Text);
            file.WriteLine("Age: " + AgeTxtBox.Text);
            file.Close();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Vaccinated ?");
        }
    }
}
