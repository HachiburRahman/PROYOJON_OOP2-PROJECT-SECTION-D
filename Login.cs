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
    public partial class Login : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Landing().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch(status)
                {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="")
            {
                SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
                string query = "select * from login_tbl where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Home().Show();

                }
                else
                {
                    MessageBox.Show("Login Unsuccessful", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill up both the boxes", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text)==true)
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Fill up the box!");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text) == true)
            { 
            
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.textBox2, "Fill up the box!");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

