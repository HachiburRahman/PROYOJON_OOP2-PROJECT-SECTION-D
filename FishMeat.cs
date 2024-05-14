using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GROCERIO_PROJECT_OOP2
{
    public partial class FishMeat : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;

        public FishMeat()
        {
            InitializeComponent();

        }
      




            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id",100 );
            cmd.Parameters.AddWithValue("@product_name", "HILSHA") ;
            cmd.Parameters.AddWithValue("@price", 1700 );
            cmd.Parameters.AddWithValue("@quantity", numericUpDown1.Value);

            

            con.Open();
             int  a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }

            

        }
      


        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 002);
            cmd.Parameters.AddWithValue("@product_name", "DESHI KOI");
            cmd.Parameters.AddWithValue("@price", 800);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown6.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 003);
            cmd.Parameters.AddWithValue("@product_name", "RUI");
            cmd.Parameters.AddWithValue("@price", 450);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown5.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id",004 );
            cmd.Parameters.AddWithValue("@product_name", "BEEF/KG");
            cmd.Parameters.AddWithValue("@price", 600);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown3.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 005);
            cmd.Parameters.AddWithValue("@product_name", "MUTTON");
            cmd.Parameters.AddWithValue("@price", 800);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown4.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 006);
            cmd.Parameters.AddWithValue("@product_name", "CHICKEN");
            cmd.Parameters.AddWithValue("@price", 260);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown2.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }
        

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FishMeat_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 007);
            cmd.Parameters.AddWithValue("@product_name", "Golda Chingri/Kg");
            cmd.Parameters.AddWithValue("@price", 1000);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown7.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 008);
            cmd.Parameters.AddWithValue("@product_name", "Buffalo/Kg");
            cmd.Parameters.AddWithValue("@price", 600);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown8.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 009);
            cmd.Parameters.AddWithValue("@product_name", "Pabda/Kg");
            cmd.Parameters.AddWithValue("@price", 650);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown9.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 067);
            cmd.Parameters.AddWithValue("@product_name", "Tangra.Kg");
            cmd.Parameters.AddWithValue("@price", 500);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown10.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 065);
            cmd.Parameters.AddWithValue("@product_name", "Rupchanda/Kg");
            cmd.Parameters.AddWithValue("@price", 1100);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown11.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 021);
            cmd.Parameters.AddWithValue("@product_name", "Boal/Kg");
            cmd.Parameters.AddWithValue("@price", 400);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown12.Value);


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Product has been added to your list ");


            }
            else
            {
                MessageBox.Show("Product has not been added");

            }
        }
    }
}
