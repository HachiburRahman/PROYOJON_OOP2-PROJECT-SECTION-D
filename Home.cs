using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROCERIO_PROJECT_OOP2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cart().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Landing().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            new FishMeat().Show();

        }
           
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FruitsVeg().Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Household().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BabyProducts().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Groceries().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Wellbeing().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new Landing().Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            new Track().Show();
        }
    }
}
