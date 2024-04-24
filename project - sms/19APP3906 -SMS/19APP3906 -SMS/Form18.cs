﻿using System;
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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add fees
            int id;
            id = int.Parse(textBox1.Text);
            int fees;
            fees = int.Parse(textBox4.Text);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
                    MySqlConnection conn = new MySqlConnection(connection);



                    string query = "INSERT INTO `fees`(`id`, `name`, `course`, `fees`) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    MySqlCommand adddata = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader myreader = adddata.ExecuteReader();

                    MessageBox.Show("Added Student fees");
                    conn.Close();

                }


                catch (System.Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update fees
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
            try
            {


                MySqlConnection conn = new MySqlConnection(connection);



                string query2 = "UPDATE `fees` SET name='" + textBox2.Text + "',cours='" + textBox3.Text + "',fees='" + textBox4.Text + "' where id='" + textBox1.Text + "'";
                MySqlCommand addData = new MySqlCommand(query2, conn);
                conn.Open();
                MySqlDataReader myreader = addData.ExecuteReader();
                MessageBox.Show("fees successfully updated.");
                conn.Close();


            }
            catch (System.Exception ex)
            {

                MessageBox.Show("error" + ex.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //display
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";

            MySqlConnection conn = new MySqlConnection(connection);

            string query1 = "SELECT * FROM  `fees` ";
            MySqlCommand cmd = new MySqlCommand(query1, conn);
            conn.Open();



            MySqlDataAdapter adapter = new MySqlDataAdapter(query1, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
