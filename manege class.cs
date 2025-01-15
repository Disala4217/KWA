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
    
    public partial class manege_class : Form
    {
        classClass Class = new classClass();
        public manege_class()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox_day.Text = "";
            textBox_grade.Text = "";
            textBox_group.Text = "";
            textBox_hall.Text = "";
            textBox_subject.Text = "";
            textBox_teacher.Text = "";
            textBox_time.Text = "";
        }

        private void manege_class_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            datagridview_class.DataSource = Class.getclass(new MySqlCommand("SELECT * FROM `class`"));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_time.Text == "" || textBox_teacher.Text == "" || textBox1.Text.Equals("") ||
                textBox_day.Text == "" || textBox_subject.Text == "" || textBox_hall.Text == "" || textBox_group.Text == ""
                )
            {
                MessageBox.Show("Need Class data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id = textBox1.Text;
                string sub = textBox_subject.Text;
                string teacher = textBox_teacher.Text;
                string grade = textBox_grade.Text;
                string grp = textBox_group.Text;
                string date = textBox_day.Text;
                string time = textBox_time.Text;
                string hall = textBox_hall.Text;



                if (Class.updateclass(id, sub, teacher, grade, grp, date, time, hall))
                {
                    showData();
                    button1.PerformClick();
                    MessageBox.Show("Class update successfuly", "Update Class", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error-Class not Edit", "Update Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void datagridview_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = datagridview_class.CurrentRow.Cells[0].Value.ToString();
            textBox_subject.Text = datagridview_class.CurrentRow.Cells[1].Value.ToString();
            textBox_teacher.Text = datagridview_class.CurrentRow.Cells[2].Value.ToString();
            textBox_grade.Text = datagridview_class.CurrentRow.Cells[3].Value.ToString();
            textBox_group.Text = datagridview_class.CurrentRow.Cells[4].Value.ToString();
            textBox_day.Text = datagridview_class.CurrentRow.Cells[5].Value.ToString();
            textBox_time.Text = datagridview_class.CurrentRow.Cells[6].Value.ToString();
            textBox_hall.Text = datagridview_class.CurrentRow.Cells[7].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    if (Class.deletclass(id))
                    {
                        showData();
                        button1.PerformClick();
                        MessageBox.Show("Class Deleted", "Removed Class", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Removed Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            datagridview_class.DataSource = Class.getclass(new MySqlCommand("SELECT * FROM `class` WHERE CONCAT(`Subject`, `Teacher`, `Grade`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }
    }
}
