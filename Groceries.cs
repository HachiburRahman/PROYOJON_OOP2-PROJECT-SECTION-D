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
    public partial class Groceries : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;

        public Groceries()
        {
            InitializeComponent();
        }

        private void Groceries_Load(object sender, EventArgs e) { 


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
            cmd.Parameters.AddWithValue("@product_id", 900);
            cmd.Parameters.AddWithValue("@product_name", "BISCUIT");
            cmd.Parameters.AddWithValue("@price", 575);
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
            cmd.Parameters.AddWithValue("@product_id", 902);
            cmd.Parameters.AddWithValue("@product_name", "OIL");
            cmd.Parameters.AddWithValue("@price", 980);
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

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 903);
            cmd.Parameters.AddWithValue("@product_name", "CHEESE");
            cmd.Parameters.AddWithValue("@price", 267);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 904);
            cmd.Parameters.AddWithValue("@product_name", "BUTTER");
            cmd.Parameters.AddWithValue("@price", 430);
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
            cmd.Parameters.AddWithValue("@product_id", 905);
            cmd.Parameters.AddWithValue("@product_name", "SPAGHETTI");
            cmd.Parameters.AddWithValue("@price", 590);
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

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 906);
            cmd.Parameters.AddWithValue("@product_name", "CHILLI POWDER");
            cmd.Parameters.AddWithValue("@price", 35);
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

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "insert into cart_tbl values( @product_id, @product_name, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@product_id", 907);
            cmd.Parameters.AddWithValue("@product_name", "RED LENTIL/1KG");
            cmd.Parameters.AddWithValue("@price", 45);
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
            cmd.Parameters.AddWithValue("@product_id", 906);
            cmd.Parameters.AddWithValue("@product_name", "CHINIGURA RICE/2KG");
            cmd.Parameters.AddWithValue("@price", 150);
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
            cmd.Parameters.AddWithValue("@product_id", 908);
            cmd.Parameters.AddWithValue("@product_name", "FLOUR/1KG");
            cmd.Parameters.AddWithValue("@price", 60);
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
            cmd.Parameters.AddWithValue("@product_id", 989);
            cmd.Parameters.AddWithValue("@product_name", "HOLUD GURA/250G");
            cmd.Parameters.AddWithValue("@price",50);
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
            cmd.Parameters.AddWithValue("@product_id", 909);
            cmd.Parameters.AddWithValue("@product_name", "ROAST MASALA /250G");
            cmd.Parameters.AddWithValue("@price", 60);
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
            cmd.Parameters.AddWithValue("@product_id", 908);
            cmd.Parameters.AddWithValue("@product_name", "RADHUNI SORISHA OIL");
            cmd.Parameters.AddWithValue("@price", 90 );
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

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    
    
