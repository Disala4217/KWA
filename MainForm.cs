using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kwa
{
    public partial class MainForm : Form
    {studentClass student=new studentClass();
        public MainForm()
        {
           
            InitializeComponent();
            customizDesign();
        }
        #region studentmenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new manegeStudentForm());
            hideSubmenu();
        }
        #endregion studentmenu
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            label3.Text = "Total Student : " + student.totalStudent();
       
        }
        private void customizDesign()
        {
            panel_studentmenu.Visible = false;
            panel_subject.Visible = false;

        }
        private void hideSubmenu()
        {
            if(panel_studentmenu.Visible==true)
                panel_studentmenu.Visible=false;
            if(panel_subject.Visible==true)
                panel_subject.Visible=false;
        }
        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible==false)
            {
                hideSubmenu();
                submenu.Visible=true;
            }
            else
                submenu.Visible=false;
                    
                
        }
        private void button_std_click(object sender, EventArgs e)
        {
            showSubmenu(panel_studentmenu);
        }
        #region studentmenu
        private void button_registation_Click(object sender, EventArgs e)
        {
            openChildForm(new Register_Form());
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new print_student());
            hideSubmenu();
        }
        #endregion studentmenu
        private void button_sub_Click(object sender, EventArgs e)
        {
            
            showSubmenu(panel_subject);
        }
        #region subject
        private void button_newclz_Click(object sender, EventArgs e)
        {
            openChildForm(new class_registation());
            hideSubmenu();
        }

        private void button_manageclz_Click(object sender, EventArgs e)
        {
            openChildForm(new manege_class());
            hideSubmenu();
        }

        private void button_printclz_Click(object sender, EventArgs e)
        {
            openChildForm(new classprint());
            hideSubmenu();
        }
        #endregion subject
        private void button_std_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panel_studentmenu); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm=null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); 
            activeForm=childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            openChildForm(new attendence());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            pictureBox3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();

        }

        
    }
}
