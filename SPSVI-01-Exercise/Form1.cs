using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPSVI_01_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Has press 'Message button'");
            if (MessageBox.Show("SPDVI first exercise with winforms", "Message Box", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){
                Console.WriteLine("Has press 'OK button'");
            } else
            {
                Console.WriteLine("Has press 'Cancel button'");
            }
        }
    }
}
