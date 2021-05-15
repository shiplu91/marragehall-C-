using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace marriage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");
        private void log_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || txtpass.Text == "")
            {

                MessageBox.Show("Wrong username and password");





            }


            else
            {

                try
                {

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Staff where Name='" + username.Text + "' and Password='" + txtpass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        new main().Show();
                        this.Hide();





                    }
                    else
                    {
                        MessageBox.Show("Error username and password");

                        username.Text = "";
                        txtpass.Text = "";


                    }


                    con.Close();







                }
                catch (Exception)
                {

                    MessageBox.Show("Ex.message");

                }



            }
          



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new login().Show();
            this.Hide();
        }

       
    }
}
