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
    public partial class Wellbeing : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;
        public Wellbeing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 013);
            cmd.Parameters.AddWithValue("@product_name", "HAND SANITIZER");
            cmd.Parameters.AddWithValue("@price", 75);
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
            cmd.Parameters.AddWithValue("@product_id", 014);
            cmd.Parameters.AddWithValue("@product_name", "TISSUE PAPER");
            cmd.Parameters.AddWithValue("@price", 600);
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
            cmd.Parameters.AddWithValue("@product_id", 015);
            cmd.Parameters.AddWithValue("@product_name", "LIPSTICK");
            cmd.Parameters.AddWithValue("@price", 1050);
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 016);
            cmd.Parameters.AddWithValue("@product_name", "HANDWASH");
            cmd.Parameters.AddWithValue("@price", 200);
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
            cmd.Parameters.AddWithValue("@product_id", 017);
            cmd.Parameters.AddWithValue("@product_name", "AIR FRESHNER");
            cmd.Parameters.AddWithValue("@price", 300);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 018);
            cmd.Parameters.AddWithValue("@product_name", "LOTION");
            cmd.Parameters.AddWithValue("@price", 890);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 019);
            cmd.Parameters.AddWithValue("@product_name", "POND'S CREAM");
            cmd.Parameters.AddWithValue("@price", 220);
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
            cmd.Parameters.AddWithValue("@product_id", 020);
            cmd.Parameters.AddWithValue("@product_name", "PEARS SOAP");
            cmd.Parameters.AddWithValue("@price", 250);
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

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 022 );
            cmd.Parameters.AddWithValue("@product_name", "HAIR OIL");
            cmd.Parameters.AddWithValue("@price", 300);
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

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 023);
            cmd.Parameters.AddWithValue("@product_name", "VASELINE BODY LOTION");
            cmd.Parameters.AddWithValue("@price", 350);
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
            cmd.Parameters.AddWithValue("@product_id", 077);
            cmd.Parameters.AddWithValue("@product_name", "DOVE SHAMPOO");
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

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 079);
            cmd.Parameters.AddWithValue("@product_name", "PERFUME");
            cmd.Parameters.AddWithValue("@price", 1500);
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

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
