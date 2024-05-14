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
    public partial class Payment_Successful : Form
    {
        public Payment_Successful()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("YOUR ORDER CODE IS 001", "ORDER CODE", MessageBoxButtons.OK);


            this.Hide();
            new Thanks().Show();
        }

        private void Payment_Successful_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}

