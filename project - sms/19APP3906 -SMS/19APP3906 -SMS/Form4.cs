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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //add student
            string gender = radioButton1.Checked ? "Male" : "Female";
            if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || gender == "" || textBox3.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else {
                try {
                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
                    MySqlConnection conn = new MySqlConnection(connection);

                   

                    string query = "INSERT INTO `stud_detail`(`id`, `fname`, `lname`, `bdate`, `gender`, `phone`) VALUES(NULL,'" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + textBox3.Text + "')";
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
            //reset
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            dateTimePicker1.Value = DateTime.Now;

            
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
