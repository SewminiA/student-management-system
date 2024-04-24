using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19APP3906__SMS
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 teacheradd = new Form13();
            teacheradd.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 coursupdateform = new Form15();
            coursupdateform.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 deletetecherform = new Form16();
            deletetecherform.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 listteacherform = new Form19();
            listteacherform.Show();
        }
    }
}
