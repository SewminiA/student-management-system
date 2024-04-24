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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add course
            int chours;
            chours = int.Parse(textBox2.Text);
            int cfees;
            cfees = int.Parse(textBox3.Text);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
                    MySqlConnection conn = new MySqlConnection(connection);



                    string query = "INSERT INTO `cours`(`id`, `cname`, `chours`, `cfees`) VALUES (NULL,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    MySqlCommand adddata = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader myreader = adddata.ExecuteReader();

                    MessageBox.Show("Added new course");
                    conn.Close();

                }


                catch (System.Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            

            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
