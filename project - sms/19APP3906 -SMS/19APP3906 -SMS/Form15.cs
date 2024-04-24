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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update teacher

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
            try
            {


                MySqlConnection conn = new MySqlConnection(connection);

               

                string query2 = "UPDATE `teacher` SET tname='" + textBox2.Text + "',tcours='" + textBox3.Text + "' where id='" + textBox1.Text + "'";
                MySqlCommand addData = new MySqlCommand(query2, conn);
                conn.Open();
                MySqlDataReader myreader = addData.ExecuteReader();
                MessageBox.Show("teacher successfully updated.");
                conn.Close();


            }
            catch (System.Exception ex)
            {

                MessageBox.Show("error" + ex.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
