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
    public partial class Household : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;
        public Household()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 007);
            cmd.Parameters.AddWithValue("@product_name", "LAMP");
            cmd.Parameters.AddWithValue("@price", 1035);
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

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 008);
            cmd.Parameters.AddWithValue("@product_name", "BEDSHEET");
            cmd.Parameters.AddWithValue("@price", 2000);
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

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price,@quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 009);
            cmd.Parameters.AddWithValue("@product_name", "CUSHION");
            cmd.Parameters.AddWithValue("@price", 500);
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 010);
            cmd.Parameters.AddWithValue("@product_name", "WALL-CLOCK");
            cmd.Parameters.AddWithValue("@price", 900);
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

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 011);
            cmd.Parameters.AddWithValue("@product_name", "BLANKET");
            cmd.Parameters.AddWithValue("@price", 2500);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 012);
            cmd.Parameters.AddWithValue("@product_name", "VASE");
            cmd.Parameters.AddWithValue("@price", 960);
            cmd.Parameters.AddWithValue("@quantity", numericUpDown1.Value);


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

        private void Household_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 013);
            cmd.Parameters.AddWithValue("@product_name", "SIDE TABLE");
            cmd.Parameters.AddWithValue("@price", 2500);
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
            cmd.Parameters.AddWithValue("@product_id", 014);
            cmd.Parameters.AddWithValue("@product_name", "EASY CHAIR");
            cmd.Parameters.AddWithValue("@price", 3000);
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
            cmd.Parameters.AddWithValue("@product_id", 016);
            cmd.Parameters.AddWithValue("@product_name", "CEILING FAN");
            cmd.Parameters.AddWithValue("@price", 2000);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
    }
    
