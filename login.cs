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


namespace kwa
{
    public partial class login : Form
    {
        studentClass student = new studentClass();
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(textBox_password.Text == ""||textBox_username.Text=="")
            {
                MessageBox.Show("Enter username and password", "no username and password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = textBox_username.Text;
                string password = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `login` WHERE `user`='" + username + "' AND`password`='" + password + "'"));
                if (table.Rows.Count > 0)
                {

                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("wrong username or password", "wrong login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
