using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewCalc
{
    public partial class FormCalc : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public FormCalc()
        {
            InitializeComponent();
            
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {

        }

        private void BtnXCube_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDisplay.Text);
            double c = a * a * a;
            txtDisplay.Text = System.Convert.ToString(c);
        }

        private void EngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Width = 595;
            this.Width = 640;
        }

        private void StandartToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            txtDisplay.Width = 286;
            this.Width = 331;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value)) txtDisplay.Text = "";
            enter_value = false;
            Button num = sender as Button;
            if(num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                }
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOper.Text = "";
        }

        private void BtnDelLeft_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOper.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            lblShowOper.Text = "0";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q = results;
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void BетPI_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(txtDisplay.Text);
            lblShowOper.Text = System.Convert.ToString("log (" + txtDisplay.Text + ")");
            iLog = Math.Log10(iLog);
            txtDisplay.Text = System.Convert.ToString(iLog);
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txtDisplay.Text);
            lblShowOper.Text = System.Convert.ToString("sqrt (" + txtDisplay.Text + ")");
            sqrt = Math.Sqrt(sqrt);
            txtDisplay.Text = System.Convert.ToString(sqrt);
        }

        private void BtnSinus_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lblShowOper.Text = System.Convert.ToString("sin (" + txtDisplay.Text + ")");
            sin = Math.Sin(sin);
            txtDisplay.Text = System.Convert.ToString(sin);
        }

        private void BtnCosinus_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtDisplay.Text);
            lblShowOper.Text = System.Convert.ToString("cos (" + txtDisplay.Text + ")");
            cos = Math.Cos(cos) * 180/ 3.141592653589976323;
            txtDisplay.Text = System.Convert.ToString(cos);
        }

        private void BtnTangens_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(txtDisplay.Text);
            lblShowOper.Text = System.Convert.ToString("tan (" + txtDisplay.Text + ")");
            tan = Math.Sqrt(tan);
            txtDisplay.Text = System.Convert.ToString(tan);
        }



        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOper.Text = "";
        }

        private void NumKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D1)
            {
                Button num = sender as Button;
                num = btn1;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D2)
            {
                Button num = sender as Button;
                num = btn2;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D3)
            {
                Button num = sender as Button;
                num = btn3;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D4)
            {
                Button num = sender as Button;
                num = btn4;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D5)
            {
                Button num = sender as Button;
                num = btn5;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D6)
            {
                Button num = sender as Button;
                num = btn6;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D7)
            {
                Button num = sender as Button;
                num = button4;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D8)
            {
                Button num = sender as Button;
                num = btn8;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D9)
            {
                Button num = sender as Button;
                num = btn9;
                Button_Click(num, e);
            }
            if (e.KeyCode == Keys.D0)
            {
                Button num = sender as Button;
                num = btn0;
                Button_Click(num, e);
            }
        }

        private void BtnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void BtnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void BtnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void BtnXSquare_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDisplay.Text);
            double c = a * a;
            txtDisplay.Text = System.Convert.ToString(c);
        }

        private void BtnInverse_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(txtDisplay.Text);
            lblShowOper.Text = System.Convert.ToString("log (" + txtDisplay.Text + ")");
            iLog = Math.Log(iLog);
            txtDisplay.Text = System.Convert.ToString(iLog);
        }

        private void BtnPersentage_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //private void btnNum7_Click(object sender, KeyEventArgs e)
        //{
        //    button4.Text = "7";
        //    button4.Tag = "7";
        //    button_Click(sender, e);
        //}
    }
}
