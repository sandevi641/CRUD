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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CVRNC54;Initial Catalog=myDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            try
            {
                string querry = "SELECT * FROM login WHERE username = '"+textBox1.Text+ "'AND password = '"+textBox2.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                    new Form2().ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Invalid Login Details! ", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox1.Clear();
                }
            }

            catch
            {
                MessageBox.Show("Eror");        }
            finally
            {
                conn.Close();       }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
