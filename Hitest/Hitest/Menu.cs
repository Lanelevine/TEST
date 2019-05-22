using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Hitest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void HomePagebtn_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome", "http://hidataweb.cafe24.com/pages/Index.jsp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClacBtn_Click(object sender, EventArgs e)
        {
            Calculator clac = new Calculator();
            clac.Show();
        }

        private void Talk_Click(object sender, EventArgs e)
        {
            SoketIndex talk = new SoketIndex();
            talk.Show();
        }
    }
}
