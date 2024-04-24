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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            showdetalscours();
        }
        private void showdetalscours()
        {
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
