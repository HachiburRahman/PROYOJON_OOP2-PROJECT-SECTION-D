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
    public partial class Cart : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;

        public Cart()
        {
            InitializeComponent();
            BindGridView();
            Getdatafromdatabase();


        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void Getdatafromdatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            { 
            try
            {
                string query = "select * from cart_tbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                con.Close();
            }
        
                
                }


        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
            string query = "select * from cart_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 70;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO CONFIRM YOUR PAYMENT?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new Payment().Show();
            }
            else if (result == DialogResult.No)
            {


            }

        }
               
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "DELETE")
            {
                int Product_ID;
                Product_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductIdColumn"].Value);
                SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                try

                {
                    string query = "DELETE from cart_tbl where PRODUCT_ID=@PRODUCT_ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PRODUCT_ID", Product_ID);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("data deleted successfully!!");

                    }
                    else
                    {

                        MessageBox.Show("data not deleted!!");
                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    con.Close();
                }
                }



            }

        private void Cart_Activated(object sender, EventArgs e)
        {
            Getdatafromdatabase();
        }

         private void button6_Click(object sender, EventArgs e)
         {

              int A = 0, B = 0;
              

               for (A = 0; A< dataGridView1.Rows.Count; ++A)               
                   {
                   B += Convert.ToInt32(dataGridView1.Rows[A].Cells[3].Value)*Convert.ToInt32(dataGridView1.Rows[A].Cells[4].Value);

              textBox1.Text = B.ToString();
            }
               
           
               
                
               
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


             
}
        
    
    
        
 

