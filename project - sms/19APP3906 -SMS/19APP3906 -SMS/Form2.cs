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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 studform = new Form3();
            studform.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 coursform = new Form8();
            coursform.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 teacher = new Form14();
            teacher.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 score = new Form17();
            score.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form18 feesform = new Form18();
            feesform.Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            try
            {
                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=SMS";
                MySqlConnection conn = new MySqlConnection(connection);
                
                {

                    //count of cours
                    string query = "SELECT COUNT(*) FROM stud_detail";
                    MySqlCommand addData = new MySqlCommand(query, conn);
                    conn.Open();
                    int studentCount = Convert.ToInt32(addData.ExecuteScalar());
                    label6.Text = "Total Students: " + studentCount.ToString();

                    //count of courses
                    string query1 = "SELECT COUNT(*) FROM cours";
                    MySqlCommand addData1 = new MySqlCommand(query1, conn);
                   
                    int coursCount = Convert.ToInt32(addData1.ExecuteScalar());
                    label4.Text = "Total Cours: " + coursCount.ToString();

                     //count of Teachers
                    string query2 = "SELECT COUNT(*) FROM cours";
                    MySqlCommand addData2 = new MySqlCommand(query2, conn);
                    
                    int tCount = Convert.ToInt32(addData2.ExecuteScalar());
                    label5.Text = "Total Teachers: " + tCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

         }

        private void button5_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }
        }
    }
