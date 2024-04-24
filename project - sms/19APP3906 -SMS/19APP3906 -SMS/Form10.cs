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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
            try
            {


                MySqlConnection conn = new MySqlConnection(connection);

               

                string query2 = " UPDATE `cours` SET cname='" + textBox2.Text + "',chours='" + textBox3.Text + "', cfees='" + textBox4.Text + "' where id='" + textBox1.Text + "'";
                MySqlCommand addData = new MySqlCommand(query2, conn);
                conn.Open();
                MySqlDataReader myreader = addData.ExecuteReader();
                MessageBox.Show("Cours successfully updated.");
                conn.Close();


            }
            catch (System.Exception ex)
            {

                MessageBox.Show("error" + ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //display
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";

            MySqlConnection conn = new MySqlConnection(connection);

            string query1 = "SELECT * FROM `cours`";
            MySqlCommand cmd = new MySqlCommand(query1, conn);
            conn.Open();



            MySqlDataAdapter adapter = new MySqlDataAdapter(query1, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
