using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using movieBO;
using movieDBOp;
using System.Collections;

namespace movie
{
    public partial class LogIn : Form
    {
        SqlConnection connection;
        UserBO user;
        UserDBOp userComm;


        public LogIn()
        {
            InitializeComponent();
            user = new UserBO();
            textBox2.PasswordChar ='*' ;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MovieDatabase;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From [User] Where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
           // DataTable table = ds.Tables["User"];
            int i = 1;
            int counter = 0;
            int status = 0;
            while((status == 0) && (counter <= dt.Rows.Count))
            {
                if (dt.Rows[0][0].ToString() == i.ToString())
                {
                    status = 1;
                }
                else
                {
                    counter++;
                    i++;
                }
            }
            

            if (status == 1)
            {
                MessageBox.Show("Success!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Load()
        {

        }
    }
}
