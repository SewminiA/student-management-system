using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _19APP3906__SMS
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            Form9 courseaddform = new Form9();
            courseaddform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            Form10 coursupdate = new Form10();
            coursupdate.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete
            Form11 coursdelete = new Form11();
            coursdelete.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //list
            Form12 courslist = new Form12();
            courslist.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
