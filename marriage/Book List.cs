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
    public partial class Book_List : Form
    {
        public Book_List()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();



            con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True"; 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from  marriage";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

             SqlCommand cmd = new SqlCommand(@"DELETE FROM [booking].[dbo].[marriage]
      WHERE [Bid]='"+textBox1.Text+"'", con);


              con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Booking Delete Susscfull");
            con.Close();


        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
