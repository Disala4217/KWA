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
using DGVPrinterHelper;

namespace kwa
{   
    
    public partial class print_student : Form
    {
        studentClass student = new studentClass();
        DGVPrinter printer = new DGVPrinter();
        public print_student()
        {
            InitializeComponent();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void print_student_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
        }
        public void showData(MySqlCommand command)
        {
            datagridview_student.ReadOnly = true;
            datagridview_student.DataSource = student.getList(command);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            datagridview_student.DataSource = student.searchStudent1(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            textBox_search.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridview_student.DataSource = student.searchStudent2(textBox1.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datagridview_student.DataSource = student.searchStudent3(textBox2.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            datagridview_student.DataSource = student.searchStudent(textBox3.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)datagridview_student.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            textBox3.Text = "";
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            printer.Title = "KWA STUDENT DETAILS";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.RowHeight = (DGVPrinter.RowHeightSetting)80 ;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "KELENI WISDOM ACADEMY";
            printer.printDocument.DefaultPageSettings.Landscape= true;
            printer.PrintDataGridView(datagridview_student);
        }
    }
    
}
