using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kwa
{
    public partial class manegeStudentForm : Form
    {   
        studentClass student=new studentClass();
        public manegeStudentForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ID.Text);
            if (MessageBox.Show("Are you sure you want to remove this student", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(student.deletestudent(id))
                {
                    showTable();
                    MessageBox.Show("Student Removed", "Remove student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }



        }

        private void button_clear_Click(object sender, EventArgs e)
        {   
            int id=Convert.ToInt32(textBox_ID.Text);
            string name = textBox_name.Text;
            string address = textBox_address.Text;
            string age = textBox_age.Text;
            string grade = textBox_grade.Text;
            string school = textBox_sch.Text;
            string number = textBox_number.Text;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] Picture = ms.ToArray();
            string sub1 = textBox_sub1.Text;
            string sub2 = textBox_sub2.Text;
            string sub3 = textBox_sub3.Text;
            string sub4 = textBox_sub4.Text;
            string sub5 = textBox_sub5.Text;
            string sub6 = textBox_sub6.Text;
            string sub7 = textBox_sub7.Text;
            string sub8 = textBox_sub8.Text;
            string sub9 = textBox_sub9.Text;
            string sub10 = textBox_sub10.Text;

            if (student.updatestudent(id,name, address, age, grade, school, number, Picture, sub1, sub2, sub3, sub4, sub4, sub5, sub6, sub7, sub8, sub9, sub10))
            {
                MessageBox.Show("student data updated", "data updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox_address.Clear();
            textBox_age.Clear();
            textBox_grade.Clear();
            textBox_name.Clear();
            textBox_number.Clear();
            textBox_sch.Clear();
            textBox_sub1.Clear();
            textBox_sub2.Clear();
            textBox_sub3.Clear();
            textBox_sub4.Clear();
            textBox_sub5.Clear();
            textBox_sub6.Clear();
            textBox_sub7.Clear();
            textBox_sub8.Clear();

            textBox_sub9.Clear();
            textBox_sub10.Clear();

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(opf.FileName);
        }
        public void showTable()
        {
            datagridview_student.DataSource = student.getstudentlist();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void manegeStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void datagridview_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridview_student_Click(object sender, EventArgs e)
        {
            byte[]img = (byte[])datagridview_student.CurrentRow.Cells[0].Value;
            MemoryStream ms=new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            textBox_ID.Text = datagridview_student.CurrentRow.Cells[1].Value.ToString();
            textBox_name.Text = datagridview_student.CurrentRow.Cells[2].Value.ToString();
            textBox_address.Text = datagridview_student.CurrentRow.Cells[3].Value.ToString();
            textBox_age.Text = datagridview_student.CurrentRow.Cells[4].Value.ToString();   
            textBox_grade.Text = datagridview_student.CurrentRow.Cells[5].Value.ToString();    
            textBox_sch.Text= datagridview_student.CurrentRow.Cells[6].Value.ToString(); 
            textBox_number.Text = datagridview_student.CurrentRow.Cells[7].Value.ToString();    
            textBox_sub1.Text = datagridview_student.CurrentRow.Cells[8].Value.ToString();  
            textBox_sub2.Text= datagridview_student.CurrentRow.Cells[9].Value.ToString();
            textBox_sub3.Text= datagridview_student.CurrentRow.Cells[10].Value.ToString();  
            textBox_sub4.Text= datagridview_student.CurrentRow.Cells[11].Value.ToString();
            textBox_sub5.Text= datagridview_student.CurrentRow.Cells[12].Value.ToString();
            textBox_sub6.Text= datagridview_student.CurrentRow.Cells[13].Value.ToString();
            textBox_sub7.Text= datagridview_student.CurrentRow.Cells[14].Value.ToString();    
            textBox_sub8.Text= datagridview_student.CurrentRow.Cells[15].Value.ToString(); 
            textBox_sub9.Text= datagridview_student.CurrentRow.Cells[16].Value.ToString();
            textBox_sub10.Text= datagridview_student.CurrentRow.Cells[17].Value.ToString(); 
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            datagridview_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
    }
}
