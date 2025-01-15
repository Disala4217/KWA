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
    public partial class Register_Form : Form
    {   studentClass student=new studentClass();
        public Register_Form()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Form_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            datagridview_student.DataSource = student.getstudentlist();  
            DataGridViewImageColumn imageColumn=new DataGridViewImageColumn();
            imageColumn=(DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Width = 80;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf=new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK) 
                pictureBox1.Image =Image.FromFile(opf.FileName);
        }
            
        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string address=textBox_address.Text;
            string age=textBox_age.Text;
            string grade=textBox_grade.Text;
            string school = textBox_sch.Text;
            string number = textBox_number.Text;
            MemoryStream ms=new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] Picture=ms.ToArray();
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

            if (student.insertstudent(name, address, age, grade, school, number, Picture, sub1, sub2, sub3, sub4, sub4, sub5, sub6, sub7, sub8, sub9, sub10))
            {
                MessageBox.Show("new student added","add student",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("error-student don't added","error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            

            

        }
        bool verify()
        {
            if ((textBox_name.Text == "") || ( textBox_address.Text == "")||
           (textBox_age.Text == "") || (textBox_grade.Text == "")||
           (textBox_sch.Text == "") || (textBox_number.Text == "")||
           (pictureBox1.Image == null) || (textBox_sub1.Text == "")||
           (textBox_sub2.Text == "") || (textBox_sub3.Text == "")||
           (textBox_sub4.Text == "") || (textBox_sub5.Text == "") ||
           (textBox_sub6.Text == "") || (textBox_sub7.Text == "") ||
           (textBox_sub8.Text == "") || (textBox_sub9.Text == "") ||
           (textBox_sub10.Text == ""))
            {
                return false;
            }
           else
                return true;
        }
           
            

        private void button_clear_Click(object sender, EventArgs e)
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

        private void datagridview_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
