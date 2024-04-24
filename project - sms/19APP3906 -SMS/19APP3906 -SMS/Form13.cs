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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else {
                try {
                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
                    MySqlConnection conn = new MySqlConnection(connection);

                   

                    string query = "INSERT INTO `teacher`(`id`, `tname`, `tcours`) VALUES(NULL,'" + textBox1.Text + "','" + textBox2.Text + "')";
                    MySqlCommand adddata = new MySqlCommand(query,conn);
                    conn.Open();
                    MySqlDataReader myreader = adddata.ExecuteReader();

                    MessageBox.Show("Added new Student");
                    conn.Close();
                   
                }


                catch(System.Exception ex){
                    MessageBox.Show("Error" +ex.ToString());
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
