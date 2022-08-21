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
    public partial class Form2 : Form
    {
        private int ranx;
        private int rany;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            this.ranx = random.Next(0, 1500);
            this.rany = random.Next(0, 1500);
            base.Location = new Point(this.ranx, this.rany);
        }
    } 
}
