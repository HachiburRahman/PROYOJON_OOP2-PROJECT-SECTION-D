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
    public partial class FruitsVeg : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;

        public FruitsVeg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 021);
            cmd.Parameters.AddWithValue("@product_name", "BANANA");
            cmd.Parameters.AddWithValue("@price", 12);
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
            cmd.Parameters.AddWithValue("@product_id", 022);
            cmd.Parameters.AddWithValue("@product_name", "APPLE");
            cmd.Parameters.AddWithValue("@price", 120);
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
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 023);
            cmd.Parameters.AddWithValue("@product_name", "ORANGE");
            cmd.Parameters.AddWithValue("@price", 145);
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 024);
            cmd.Parameters.AddWithValue("@product_name", "POTATO");
            cmd.Parameters.AddWithValue("@price", 220);
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
            cmd.Parameters.AddWithValue("@product_id", 025);
            cmd.Parameters.AddWithValue("@product_name", "ONION");
            cmd.Parameters.AddWithValue("@price", 187);
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
            cmd.Parameters.AddWithValue("@product_id", 026);
            cmd.Parameters.AddWithValue("@product_name", "GREEN CHILLI");
            cmd.Parameters.AddWithValue("@price", 20);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            String query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 026);
            cmd.Parameters.AddWithValue("@product_name", "Cucumber");
            cmd.Parameters.AddWithValue("@price", 40);
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
            cmd.Parameters.AddWithValue("@product_id", 027);
            cmd.Parameters.AddWithValue("@product_name", "Cauliflower");
            cmd.Parameters.AddWithValue("@price", 30);
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
            cmd.Parameters.AddWithValue("@product_id", 028);
            cmd.Parameters.AddWithValue("@product_name", "Sweet Pumpkin");
            cmd.Parameters.AddWithValue("@price", 90);
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
            cmd.Parameters.AddWithValue("@product_id", 028);
            cmd.Parameters.AddWithValue("@product_name", "Dragon Fruit/Kg");
            cmd.Parameters.AddWithValue("@price", 450);
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
            cmd.Parameters.AddWithValue("@product_id", 035);
            cmd.Parameters.AddWithValue("@product_name", "Grapes/Kg");
            cmd.Parameters.AddWithValue("@price", 400);
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
            cmd.Parameters.AddWithValue("@product_id", 045);
            cmd.Parameters.AddWithValue("@product_name", "Guava/Kg");
            cmd.Parameters.AddWithValue("@price", 60);
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
