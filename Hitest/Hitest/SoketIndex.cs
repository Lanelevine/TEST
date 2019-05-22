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
using DevExpress.XtraEditors;


namespace Hitest
{
    public partial class SoketIndex : DevExpress.XtraEditors.XtraForm
    {

        Error error = new Error();

        public SoketIndex()
        {
            InitializeComponent();
        }

        private void Claculator_Load(object sender, EventArgs e)
        {

        }

        private void CEclearBtn_Click(object sender, EventArgs e)
        {
            CEBox.Clear();
        }

        private void CclearBtn_Click(object sender, EventArgs e)
        {
            CBox.Clear();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CEBox.Select(CBox.Text.Length, 0);
        }
        #region :: btn(0~9) Click ::
        private void btn0_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "0";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "0";
            }
            else
            {
                CEBox.Text += CEBox.Text = "0";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "1";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "1";
            }
            else
            {
                CEBox.Text += CEBox.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "2";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "2";
            }
            else
            {
                CEBox.Text += CEBox.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "3";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "3";
            }
            else
            {
                CEBox.Text += CEBox.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "4";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "4";
            }
            else
            {
                CEBox.Text += CEBox.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "5";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "5";
            }
            else
            {
                CEBox.Text += CEBox.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "6";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "6";
            }
            else
            {
                CEBox.Text += CEBox.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "7";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "7";
            }
            else
            {
                CEBox.Text += CEBox.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "8";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "8";
            }
            else
            {
                CEBox.Text += CEBox.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text = "9";
            }
            else if (CEBox.Text == "0")
            {
                CEBox.Text = "9";
            }
            else
            {
                CEBox.Text += CEBox.Text = "9";
            }
        }
        #endregion

        private void dPoint_Click(object sender, EventArgs e)
        {
            if (CEBox.Text == "")
            {
                CEBox.Text += ".";
            }
            else if (CEBox.Text == ".")
            {
                CEBox.Text = ".";
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CBox.Text += CEBox.Text + "+";
            CEBox.Clear();
        }

        private void PmBtn_Click(object sender, EventArgs e)
        {
            if (CBox.Text == "-")
            {
                CEBox.Text = "+";
            }
            else if (CBox.Text == "")
            {
                CEBox.Text = "+";
            }
            else if (CBox.Text == "+")
            {
                CEBox.Text = "-";
            }
        }



        #region ::EsignBtn_Click :: 입력한 값을 계산합니다.
        private void EsignBtn_Click(object sender, EventArgs e)
        {

            try
            {
                clac();

                CBox.Clear();

            }
            catch (FormatException fx)
            {
                error.ErrorListBox.Items.Add(fx);
                error.Show();
            }

        }

        void clac()
        {
            int result;

            switch (CEBox.Text + CBox.Text)
            {

                case "+":
                    result = Convert.ToInt32(CBox.Text) + Convert.ToInt32(CEBox.Text);
                    CEBox.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = Convert.ToInt32(CBox.Text) - Convert.ToInt32(CEBox.Text);
                    CEBox.Text = Convert.ToString(result);
                    break;
                case "x":
                    result = Convert.ToInt32(CBox.Text) * Convert.ToInt32(CEBox.Text);
                    CEBox.Text = Convert.ToString(result);
                    break;
                case "÷":
                    result = Convert.ToInt32(CBox.Text) / Convert.ToInt32(CEBox.Text);
                    CEBox.Text = Convert.ToString(result);
                    break;
                default: break;
            }
        }
        #endregion

        private void MinBtn_Click(object sender, EventArgs e)
        {
            CBox.Text += CEBox.Text + "-";
            CEBox.Clear();
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            CBox.Text += CEBox.Text + "x";
            CEBox.Clear();
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            CBox.Text += CEBox.Text + "÷";
            CEBox.Clear();
        }
    }
}