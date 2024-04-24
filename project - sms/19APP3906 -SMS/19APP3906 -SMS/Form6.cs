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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
         

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //update student
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
            try
            {

                
                MySqlConnection conn = new MySqlConnection(connection);

                string gender = radioButton1.Checked ? "Male" : "Female";

                string query2 = "UPDATE stud_detail SET fname='" + textBox1.Text + "',lname='" + textBox2.Text + "',bdate='" + dateTimePicker1.Text + "',gender='" + gender + "',phone='" + textBox3.Text + "' where id='" + textBox4.Text + "'";
                MySqlCommand addData = new MySqlCommand(query2, conn);
                conn.Open();
                MySqlDataReader myreader = addData.ExecuteReader();
                MessageBox.Show("user successfully updated.");
                conn.Close();


            }
            catch(System.Exception ex) {

                MessageBox.Show("error"+ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //display student
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";

            MySqlConnection conn = new MySqlConnection(connection);

            string query1 = "SELECT * FROM stud_detail";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
