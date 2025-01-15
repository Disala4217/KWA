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
    public partial class classprint : Form
    {
        DGVPrinter printer = new DGVPrinter();
        classClass Class = new classClass();
        public classprint()
        {
            InitializeComponent();
        }

        private void button_grade_Click(object sender, EventArgs e)
        {
            datagridview_class.DataSource = Class.searchgrade(textBox3.Text);

            textBox3.Text = "";
        }

        private void classprint_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            datagridview_class.DataSource = Class.getclass(new MySqlCommand("SELECT * FROM `class`"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datagridview_class.DataSource = Class.searchteacher(textBox_teacher.Text);

            textBox_teacher.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridview_class.DataSource = Class.searchday(textBox_day.Text);

            textBox_day.Text = "" ;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            datagridview_class.DataSource = Class.searchsubject(textBox_sub.Text);

            textBox_sub.Text = "";
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            printer.Title = "KWA CLASS DETAILS";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.RowHeight = (DGVPrinter.RowHeightSetting)80;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "KELENI WISDOM ACADEMY";
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(datagridview_class);
        }
    }
}
