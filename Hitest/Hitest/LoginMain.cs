using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hitest
{
    public partial class LoginMain : Form
    {
        public LoginMain()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(IdTextbox.Text == "Admin" && PwTextbox.Text == "1234")
            {
                DialogResult dialogresult = XtraMessageBox.Show("Success", "로그인완료", MessageBoxButtons.OK);
                {
                    if(dialogresult = DialogResult.OK)
                    {

                    }
                }
            }
            else
            {

            }
        }
    }
}
