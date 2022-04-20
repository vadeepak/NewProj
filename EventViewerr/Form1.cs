using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventViewerr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                System.Diagnostics.EventLog.CreateEventSource
                    (textBox2.Text, textBox1.Text);
                MessageBox.Show("Event Log and Source Created");
            }
            else
            {
                MessageBox.Show("Event Log and Source are required");
            }
        }
    }
}
