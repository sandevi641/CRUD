using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CVRNC54;Initial Catalog=myDB;Integrated Security=True");


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into DataTb values('"+textBox7.Text+"','"+ textBox1.Text + "','"+ textBox2.Text + "','"+ textBox3.Text + "',getdate(),'"+ textBox5.Text + "','"+ textBox6.Text + "')",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucsessfuly Created !","Sucses",MessageBoxButtons.OK,MessageBoxIcon.Information);
            conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("update DataTb set  Name = '" + textBox1.Text + "',Contact Number = '" + textBox2.Text + "',Email = '" + textBox3.Text + "',Date Of Birth = '" + textBox4.Text + "',Age = '" + textBox5.Text + "',Gender = '" + textBox6.Text + "' where StudentId = '" + textBox7.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucsessfuly Updated !", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete DataTb where StudentId = '" + textBox7.Text + "'",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucsessfully Deleted !");
            conn.Close();
        }
    }
}
