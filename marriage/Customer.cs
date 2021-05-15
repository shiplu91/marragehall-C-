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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {




                int id = Convert.ToInt32(custid.Text);
                string Name = custname.Text;
                string Address = btnadress.Text;


                string Phone = custphone.Text;


                SqlConnection con = new SqlConnection();



                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
               
                cmd.CommandText = "insert into  customer values ('" + id + "','" + Name + "','" + Address + "','" + Phone + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                
            
            
            
            
            
            
            
            
            
            
            
            
            }



            catch (Exception)
            {

                MessageBox.Show("Save");





            }










        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Sourch = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
            SqlConnection con = new SqlConnection(Sourch);
            con.Open();
            MessageBox.Show("seach");
            string sqlSelectQuery = "select * from  customer where Customerid=" + int.Parse(textBox1.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {




                custid.Text = (dr["Customerid"].ToString());
                custname.Text = (dr["Name"].ToString());
                btnadress.Text = (dr["CustomerAddress"].ToString());
                custphone.Text = (dr["Customerphone"].ToString());















            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");



            SqlCommand cmd = new SqlCommand(@"UPDATE [booking].[dbo].[customer]
   SET [Customerid] = '" + custid.Text + "',[Name] = '" + custname.Text + "',[CustomerAddress] = '" + btnadress.Text + "',[Customerphone] = '" + custphone.Text + "'WHERE [Customerid] = '" + custid.Text + "'", con);


            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update");
            con.Close();





        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"DELETE FROM [booking].[dbo].[customer]
      WHERE [Customerid] = '" + custid.Text + "'", con);







            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();



        }
        private void populate()
        {


            SqlConnection con = new SqlConnection();



            con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
            con.Open();
            string query = "select * from customer";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            shiplu.DataSource = ds.Tables[0];
            con.Close();




        }

        private void button6_Click(object sender, EventArgs e)
        {
            custid.Text = "";
            custname.Text = "";

            btnadress.Text = "";
            custphone.Text = "";

        }

        //public void invoiceno()
        //{

        //    SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

        //    SqlCommand cmd;
        //    SqlDataAdapter da;
        //    SqlDataReader dr;
        //    string sql;
        //    try
        //    {


        //        sql = "select MAX( Customerid )from customer";
        //        cmd = new SqlCommand(sql, con);
        //        con.Open();
        //        var maxid = cmd.ExecuteScalar() as string;

        //        if (maxid == null)
        //        {


        //            custid.Text = "E-00001";



        //        }

        //        else
        //        {
        //            int intval = int.Parse(maxid.Substring(2, 6));
        //            intval++;
        //            custid.Text = string.Format("{E-0000}", intval);

        //        }
        //        con.Close();


        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("ex.message");



        //    }





        //}




        //public void gercustomer()
        //{

        //    SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

        //    string proid;
        //    string quary = "select Customerid from customer ";
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(quary, con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read()) 
        //    {

        //        int id = int.Parse(dr[0].ToString()) + 1;
        //        proid = id.ToString("000");

            
            
            
            
        //    }

        //    else if (Convert.IsDBNull(dr))
        //    {


        //        proid = ("506");



        //    }

        //    else
        //    {
        //        proid = ("506");
            
            
            
        //    }
        //    con.Close();
        //    custid.Text = proid.ToString();

        //}

        private void Customer_Load(object sender, EventArgs e)
        {
            //invoiceno();
            populate();
            //gercustomer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
