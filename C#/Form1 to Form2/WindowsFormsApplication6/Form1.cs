using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "123")
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
            }
            else if (textBox1.Text == "ilker")
            {
                if (textBox2.Text == "kaya")
                {
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
            else if (textBox1.Text =="melih")
            {
                if (textBox2.Text =="şirin")
                {
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
            }

        }
    }
}
