using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19APP3906__SMS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 registerform = new Form4();
            registerform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            Form6 updateform = new Form6();
            updateform.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //detail form

            Form5 detailform = new Form5();
            detailform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            Form7 deleteform = new Form7();
            deleteform.Show();
            this.Hide();
        }
    }
}
