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
    public partial class class_registation : Form
    {   
        classClass Class = new classClass();
        public class_registation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_day.Text = "";
            textBox_grade.Text = "";
            textBox_group.Text = "";
            textBox_hall.Text = "";
            textBox_subject.Text = "";
            textBox_teacher.Text = "";
            textBox_time.Text = "";

        }

        private void button_and_Click(object sender, EventArgs e)
        {
           

           


        }

        private void datagridview_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void class_registation_Load(object sender, EventArgs e)
        {
            datagridview_class.DataSource = Class.getclass(new MySqlCommand("SELECT * FROM `class`"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (textBox_day.Text == "" || textBox_grade.Text == "" || textBox_group.Text == "" ||
               textBox_time.Text == "" || textBox_hall.Text == "" || textBox_subject.Text == "" ||
               textBox_teacher.Text == ""||textBox1.Text=="")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id=textBox1.Text;
                string sub = textBox_subject.Text;
                string teacher = textBox_teacher.Text;
                string grade = textBox_grade.Text;
                string grp = textBox_group.Text;
                string day = textBox_day.Text;
                string time = textBox_time.Text;
                string hall = textBox_hall.Text;

                if (Class.insertCourse(id,sub, teacher, grade, grp, day, time, hall))
                {

                    MessageBox.Show("New class inserted", "Add class", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("clazz not insert", "Add class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
