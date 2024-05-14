using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GROCERIO_PROJECT_OOP2
{
    public partial class Reg : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["grocerio"].ConnectionString;
        public Reg()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Landing().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox5.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox5.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
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

   

       /** private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.Icon = Properties.Resources.error;
                errorProvider3.SetError(this.textBox3, "Fill up the box!");

            }
            else
            {
                errorProvider3.Icon = Properties.Resources.check;
            }
        }**/

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                textBox5.Focus();
                errorProvider4.Icon = Properties.Resources.error;
                errorProvider4.SetError(this.textBox5, "Fill up the box!");

            }
            else
            {
                errorProvider4.Icon = Properties.Resources.check;
            }

        }

      /**  private void textBox5_TextChanged(object sender, EventArgs e)
        {

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


        }**/

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.Icon = Properties.Resources.error;
                errorProvider3.SetError(this.textBox3, "Fill up the box!");

            }
            else
            {
                errorProvider3.Icon = Properties.Resources.check;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=HACHIBURRAHMAN\\SQLEXPRESS;Initial Catalog=grocerio;Integrated Security=True;TrustServerCertificate=True");
                string query = "select * from reg_tbl where username=@username and password=@password and mobileno=@mobileno and email=@email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox2.Text);
                cmd.Parameters.AddWithValue("@mobileno", textBox3.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);


                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login().Show();

                }
                else
                {
                    MessageBox.Show("Registration Unsuccessful", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill up all the boxes", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
       
/**private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }**/

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
