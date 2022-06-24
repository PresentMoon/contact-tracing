using System;
using System.Collections;
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
        ArrayList arlist = new ArrayList();
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
            //this.Close();

            arlist.Add(NameTxtBox.Text);
            arlist.Add(ContactNumTxtBox.Text);
            arlist.Add(AddressTxtBox.Text);
            arlist.Add(DateTxtBox.Text);
            arlist.Add(TimeInTxtBox.Text);
            arlist.Add(TimeOutTxtBox.Text);
            arlist.Add(AgeTxtBox.Text);
            DataGrid.Columns.Add("Name", "Name");
            DataGrid.Columns.Add("Contact#", "Contact#");
            DataGrid.Columns.Add("Address", "Address");
            DataGrid.Columns.Add("Date", "Date");
            DataGrid.Columns.Add("TimeIn", "TimeIn");
            DataGrid.Columns.Add("TimeOut", "TimeOut");
            DataGrid.Columns.Add("Age", "Age");
            DataGrid.Rows.Add(arlist.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Vaccinated ?");
        }

        private void viewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
