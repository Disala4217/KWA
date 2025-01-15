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
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if(panel1.Width>=734)
            {
                timer1.Stop();
                login login = new login();
                login.Show();
                this.Hide();
            }
        }
    }
}
