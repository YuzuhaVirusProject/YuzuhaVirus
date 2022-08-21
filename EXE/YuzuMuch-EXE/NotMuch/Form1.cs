using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotMuch
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("柚葉絶対に許さない", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }
    }
}
