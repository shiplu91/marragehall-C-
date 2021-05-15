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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }















        private void populatesh()
        {


            SqlConnection con = new SqlConnection();



            con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
            con.Open();
            string query = "select * from Staff";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            staffDG.DataSource = ds.Tables[0];
            con.Close();




        }

















        private void button1_Click(object sender, EventArgs e)
        {
            try {


                int id = Convert.ToInt32(Staffid.Text);

                string Name = staffName.Text;

                string Phone = txtPhone.Text;

                string Gender = txtGender.Text;
                string password = txtpass.Text;
                SqlConnection con = new SqlConnection();



                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into  Staff values ('" + id + "','" + Name + "','" + Phone + "','" + Gender + "','" + password + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                

            
            
            
            
            }



            catch (Exception)
            {




                MessageBox.Show("Save");







            }










        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populatesh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Sourch = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
            SqlConnection con = new SqlConnection(Sourch);
            con.Open();
            MessageBox.Show("Search");
            string sqlSelectQuery = "select * from Staff where [Staff id]=" + int.Parse(textBox2.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                Staffid.Text = (dr["Staff id"].ToString());
                staffName.Text = (dr["Name"].ToString());
                txtPhone.Text = (dr["Phone"].ToString());
                txtGender.Text = (dr["Gender"].ToString());

                txtpass.Text = (dr["Password"].ToString());









            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"UPDATE [booking].[dbo].[Staff]
   SET [Staff id] = '" + Staffid.Text + "',[Name] = '" + staffName.Text + "',[Phone] = '" + txtPhone.Text + "',[Gender] = '" + txtGender.Text + "',[Password] = '" + txtpass.Text + "'WHERE [Staff id] = '" + Staffid.Text + "'", con);



            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update");
            con.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"DELETE FROM [booking].[dbo].[Staff]
      WHERE [Staff id] = '" + Staffid.Text + "'", con);



            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staffid.Text = "";
            staffName.Text = "";
            txtPhone.Text = "";

            txtGender.Text = "";

            txtpass.Text = "";



        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
