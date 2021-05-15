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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void beercheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (beercheck.Checked == true)
            {

                beerprice.Enabled = true;
                beerQuant.Enabled = true;





            }
            else
            {

                beerprice.Enabled = false;
                beerQuant.Enabled = false;
                beerprice.Text = "";
                beerQuant.Text = "";

            
            
            
            }
        }

        private void Sodacheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (Sodacheck.Checked == true)
            {
                sodapric.Enabled = true;
                sodaquant.Enabled = true;






            }
            else
            {

                sodapric.Enabled = false;
                sodaquant.Enabled = false;
                sodapric.Text = "";
                sodaquant.Text = "";
            
            
            
            
            
            }
        }

        private void winecheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (winecheck.Checked == true)
            {
                winepric.Enabled = true;
                winequant.Enabled = true;




            }

            else
            {



                winepric.Enabled = false;
                winequant.Enabled = false;
                winepric.Text = "";
                winequant.Text = "";
            
            
            
            
            
            
            
            
            
            }










        }

        private void watercheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (watercheck.Checked == true)
            {



                waterpric.Enabled = true;
                waterquant.Enabled = true;



            }
            else
            {




                waterpric.Enabled = false;
                waterquant.Enabled = false;
                waterpric.Text = "";
                waterquant.Text = "";

            
            
            
            
            
            
            }
        }

        private void jaicecheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (jaicecheck.Checked == true)
            {
                jaiceprice.Enabled = true;

                jaicequant.Enabled = true;






            }


            else
            {



                jaiceprice.Enabled = false;
                jaicequant.Enabled = false;
                jaiceprice.Text = "";
                jaicequant.Text = "";
            
            
            
            
            
            
            
            
            
            }










        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int beer=0, soda=0, wine=0,water=0,juice=0;
            if (beercheck.Checked == true && beerprice.Text == "" && beerQuant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else

            {

                beer = Convert.ToInt32(beerprice.Text) * Convert.ToInt32(beerQuant.Text);
            
            
            
            
            
            
            }

            if (Sodacheck.Checked == true && sodapric.Text == "" && sodaquant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                soda = Convert.ToInt32(sodapric.Text) * Convert.ToInt32(sodaquant.Text);






            }





            if (winecheck.Checked == true && winepric.Text == "" && winequant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                wine = Convert.ToInt32(winepric.Text) * Convert.ToInt32(winequant.Text);






            }



            if (watercheck.Checked == true && waterpric.Text == "" && waterquant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

              water   = Convert.ToInt32(waterpric.Text) * Convert.ToInt32(waterquant.Text);






            }




            if(jaicecheck.Checked == true && jaiceprice.Text == "" && jaicequant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                juice = Convert.ToInt32(jaiceprice.Text) * Convert.ToInt32(jaicequant.Text);






            }


            int bevcost = beer + soda + wine + water + juice;
            DrinkcostTbl.Text =""+ bevcost;





        }

        private void Mottoncheck_CheckStateChanged(object sender, EventArgs e)
        {



            if (Mottoncheck.Checked == true)
            {



               motpric.Enabled = true;
               motoquant.Enabled = true;



            }
            else
            {




                motpric.Enabled = false;
                motoquant.Enabled = false;
                motpric.Text = "";
                motoquant.Text = "";







            }












        }

        private void chiekencheck_CheckStateChanged(object sender, EventArgs e)
        {

            if (chiekencheck.Checked == true)
            {



               chienkenpric.Enabled = true;
               chienkenquant.Enabled = true;



            }
            else
            {




                chienkenpric.Enabled = false;
                chienkenquant.Enabled = false;
                chienkenpric.Text = "";
                chienkenquant.Text = "";







            }




        }

        private void fishcheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (fishcheck.Checked == true)
            {



               fishpric.Enabled = true;
               fishquant.Enabled = true;



            }
            else
            {




                fishpric.Enabled = false;
                fishquant.Enabled = false;
                fishpric.Text = "";
                fishquant.Text = "";







            }
        }

        private void suacugecheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (suacugecheck.Checked == true)
            {



               suacugeprice.Enabled = true;
               suacugequant.Enabled = true;



            }
            else
            {




                suacugeprice.Enabled = false;
                suacugequant.Enabled = false;
                suacugeprice.Text = "";
                suacugequant.Text = "";







            }
        }

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {



               biyapric.Enabled = true;
               biyaquant.Enabled = true;



            }
            else
            {




                biyapric.Enabled = false;
                biyaquant.Enabled = false;
                biyapric.Text = "";
                biyaquant.Text = "";







            }
        }

        private void motoquant_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int motton = 0, chieken = 0, fish = 0, saucage = 0, biyani = 0;
            if (Mottoncheck.Checked == true && motpric.Text == "" && motoquant.Text == "")
            {


                MessageBox.Show("Enter motton qantity");



            }
            else
            {

                motton = Convert.ToInt32(motpric.Text) * Convert.ToInt32(motoquant.Text);






            }

            if (chiekencheck.Checked == true && chienkenpric.Text == "" && chienkenquant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                chieken = Convert.ToInt32(chienkenpric.Text) * Convert.ToInt32(chienkenquant.Text);






            }





            if (fishcheck.Checked == true && fishpric.Text == "" && fishquant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                fish = Convert.ToInt32(fishpric.Text) * Convert.ToInt32(fishquant.Text);






            }



            if (suacugecheck.Checked == true && suacugeprice.Text == "" && suacugequant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                saucage = Convert.ToInt32(suacugeprice.Text) * Convert.ToInt32(suacugequant.Text);






            }




            if (checkBox5.Checked == true && biyapric.Text == "" && biyaquant.Text == "")
            {


                MessageBox.Show("Enter Q");



            }
            else
            {

                biyani = Convert.ToInt32(biyapric.Text) * Convert.ToInt32(biyaquant.Text);






            }


            int Dish = motton + chieken+ fish+saucage+ biyani;
            Foodcost.Text = "" + Dish;


        }

















        private void shiplu()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select Customerid from    customer", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("Customerid", typeof(string));

            dt.Load(rdr);

            CustomerTB.ValueMember = "Customerid";
            CustomerTB.DataSource = dt;


            con.Close();
        
        
        
        
        
        
        }





        private void Booking_Load(object sender, EventArgs e)
        {
            shiplu();
        }



        private void hasan()
        {


            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True");

            con.Open();
            string mysql = "select * from customer where Customerid=" + CustomerTB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                CustomerName.Text = "" + dr["Name"].ToString();
            
            
            
            
            
            
            }


            con.Close();
        
        
        
        
        
        
        }












        private void CustomerTB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hasan();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

          



           









            try
            {






                int id = Convert.ToInt32(bid.Text);
                string Date = bdate.Text;
                string time = btime.Text;


                string Personal = bpersonal.Text;
                string Name = CustomerName.Text;
              
                string Drink = DrinkcostTbl.Text;
                string food = Foodcost.Text;
                string iteams = cmb_items.Text;
                string Prices = roomprice.Text;
                String Total = txttotal.Text;
                string Discount = discount.Text;
                string Paid=txtpaid.Text;
                string Balance = txtbalance.Text;

                SqlConnection con = new SqlConnection();



                con.ConnectionString = "Data Source=LAPTOP-O86D32ES;Initial Catalog=booking;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into  marriage values ('" + id + "','" + Date + "','" + time + "','" + Personal + "','" + Name + "','" + Drink + "','" + food + "','"+iteams+"','"+Prices+"','"+Total+"','"+Discount+"','"+Paid+"','"+Balance+"')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);











            }

            catch (Exception)
            {




                MessageBox.Show("Booking Save");
            
            
            
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void CustomerTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txthigh_CheckedChanged(object sender, EventArgs e)
        {
            txthigh.ForeColor = System.Drawing.Color.Green;
            txtmedium.ForeColor = System.Drawing.Color.Red;
            txtlow.ForeColor = System.Drawing.Color.Red;
            cmb_items.Items.Clear();
            cmb_items.Items.Add("Select High Room Number 1");
            cmb_items.Items.Add("Select High Room Number 2");
            cmb_items.Items.Add("Select High Room Number 3");
            cmb_items.Items.Add("Select High Room Number 4");
            cmb_items.Items.Add("Select High Room Number 5");
            cmb_items.Items.Add("Select High Room Number 6");
            cmb_items.Items.Add("Select High Room Number 7");
        }

        private void txtmedium_CheckedChanged(object sender, EventArgs e)
        {
            txthigh.ForeColor = System.Drawing.Color.Red;
            txtmedium.ForeColor = System.Drawing.Color.Blue;
            txtlow.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Select Medium Room Number 1");
            cmb_items.Items.Add("Select Medium Room Number 2");
            cmb_items.Items.Add("Select Medium Room Number 3");
            cmb_items.Items.Add("Select Medium Room Number 4");
            cmb_items.Items.Add("Select Medium Room Number 5");
            cmb_items.Items.Add("Select Medium Room Number 6");
            cmb_items.Items.Add("Select Medium Room Number 7");





        }

        private void txtlow_CheckedChanged(object sender, EventArgs e)
        {
            txthigh.ForeColor = System.Drawing.Color.Red;
            txtmedium.ForeColor = System.Drawing.Color.Red;
            txtlow.ForeColor = System.Drawing.Color.Green;


            cmb_items.Items.Clear();
            cmb_items.Items.Add("Select Low Room Number 1");
            cmb_items.Items.Add("Select Low Room Number 2");
            cmb_items.Items.Add("Select Low Room Number 3");
            cmb_items.Items.Add("Select Low Room Number 4");
            cmb_items.Items.Add("Select Low Room Number 5");
            cmb_items.Items.Add("Select Low Room Number 6");
            cmb_items.Items.Add("Select Low Room Number 7");


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Select High Room Number 1")
            {


                roomprice.Text = "3200";
            
            
            }

          else  if (cmb_items.SelectedItem.ToString() == "Select High Room Number 2")
            {


                roomprice.Text = "3420";


            }





          else  if (cmb_items.SelectedItem.ToString() == "Select High Room Number 3")
            {


                roomprice.Text = "3800";


            }






            else if (cmb_items.SelectedItem.ToString() == "Select High Room Number 4")
            {


                roomprice.Text = "3900";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select High Room Number 5")
            {


                roomprice.Text = "4000";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select High Room Number 6")
            {


                roomprice.Text = "4800";


            }




            else if (cmb_items.SelectedItem.ToString() == "Select High Room Number 7")
            {


                roomprice.Text = "5000";


            }




            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 1")
            {


                roomprice.Text = "2000";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 2")
            {


                roomprice.Text = "2200";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 3")
            {


                roomprice.Text = "2300";


            }




            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 4")
            {


                roomprice.Text = "2400";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 5")
            {


                roomprice.Text = "2500";


            }




            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 6")
            {


                roomprice.Text = "2600";


            }




            else if (cmb_items.SelectedItem.ToString() == "Select Medium Room Number 7")
            {


                roomprice.Text = "2800";


            }









            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 1")
            {


                roomprice.Text = "1200";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 2")
            {


                roomprice.Text = "1400";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 3")
            {


                roomprice.Text = "1500";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 4")
            {


                roomprice.Text = "1600";


            }



            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 5")
            {


                roomprice.Text = "1700";


            }






            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 6")
            {


                roomprice.Text = "1800";


            }





            else if (cmb_items.SelectedItem.ToString() == "Select Low Room Number 7")
            {


                roomprice.Text = "1900";


            }


            //else
            //{
            //    roomprice.Text = "0";


            //}









        }

        private void roomQty_TextChanged(object sender, EventArgs e)
        {
            if (roomQty.Text.Length > 0)
            {
                txttotal.Text = (Convert.ToInt16(roomprice.Text) * Convert.ToInt16(roomQty.Text)).ToString();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {





































        }

        private void subtotal_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {


          


            subtotal.Text = (Convert.ToInt16(subtotal.Text) + Convert.ToInt16(txttotal.Text)).ToString();
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            if (discount.Text.Length > 0)
            {

                txtnet.Text = (Convert.ToInt16(subtotal.Text) - Convert.ToInt16(discount.Text)).ToString();
            
            
            
            
            }
        }

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
            if (txtpaid.Text.Length > 0)
            {


                txtbalance.Text = (Convert.ToInt16(txtnet.Text) - Convert.ToInt16(txtpaid.Text)).ToString();
            
            
            
            
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===Employee==", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(100));

            e.Graphics.DrawString("Employee ID:" + bid.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Employee Date:" + bdate.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.GreenYellow, new Point(10, 180));
            e.Graphics.DrawString("Employee Time:" + btime.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Gold, new Point(10, 210));

          /////////

            e.Graphics.DrawString("No-personal:" + bpersonal.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Blue, new Point(10, 260));

            e.Graphics.DrawString("Customer Name:" + CustomerName.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 310));


            e.Graphics.DrawString("Drink cost :" + DrinkcostTbl.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Gold, new Point(10, 370));

            e.Graphics.DrawString("Food cost:" +Foodcost.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 400));

            //////////

            e.Graphics.DrawString("Room Iteams:" + cmb_items.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Pink, new Point(10, 430));

            e.Graphics.DrawString("Room Prices:" + roomprice.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.SpringGreen, new Point(10, 460));


            e.Graphics.DrawString("Total :" + txttotal.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 490));

            e.Graphics.DrawString("Discount:" + discount.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.SlateBlue, new Point(10, 530));

            e.Graphics.DrawString("Paid:" + txtpaid.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(10, 560));


            e.Graphics.DrawString("Balance:" + txtbalance.Text, new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Indigo, new Point(10, 590));



        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

                printDocument1.Print();

            }
        }


       

    }
}
