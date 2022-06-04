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
        private void buttonClick(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\user\Documents\Contacts Traced\contacts.txt",true);
            file.WriteLine
        }
    }
}
