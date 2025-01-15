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
    public partial class attendence : Form
    {   
        DGVPrinter printer=new DGVPrinter();
        attendClass attend =new attendClass();
        public attendence()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (textBox_subject.Text == "" || textBox_teacher.Text == "" )
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime A_date = dateTimePicker1.Value;
                string Cid = textBox_subject.Text;
                string Sid = textBox_teacher.Text;


                if (attend.insertattend(A_date,Cid,Sid))
                {
                    textBox_teacher.Text = "";
                    MessageBox.Show("student attended marked", "student attended", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void attendence_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `attendence`"));
        }
        public void showData(MySqlCommand command)
        {
            datagridview_class.ReadOnly = true;
            datagridview_class.DataSource = attend.getList(command);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                datagridview_class.DataSource = attend.searchsid(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            datagridview_class.DataSource = attend.searchdate(textBox2.Text);
            textBox2.Text = "";
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            printer.Title = "KWA Attendence Sheet";
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
