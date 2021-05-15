using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace marriage
{
    public partial class Loding : Form
    {
        public Loding()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 99)
            {

                new Form1().Show();
                this.Hide();
                timer1.Stop();




            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void Loding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
