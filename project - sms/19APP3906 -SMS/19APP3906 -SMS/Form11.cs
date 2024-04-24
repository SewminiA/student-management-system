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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
            try
            {
                MySqlConnection conn = new MySqlConnection(connection);
                string query3 = "DELETE FROM `cours`   where id='" + textBox4.Text + "'";
                MySqlCommand addData = new MySqlCommand(query3, conn);
                conn.Open();
                MySqlDataReader myreader = addData.ExecuteReader();
                MessageBox.Show("cours successfully deleted.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
