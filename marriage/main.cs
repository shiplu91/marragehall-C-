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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Booking().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Book_List().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
