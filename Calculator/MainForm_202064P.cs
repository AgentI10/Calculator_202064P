using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void numPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            string cache = lblHistory.Text;
            string entry = txtResults.Text;

            if (flagOpPressed == true)
            {
                entry = "";
                flagOpPressed = false;
            }

            switch(num)
            {
                case ".":
                    if (!entry.Contains("."))
                {
                    entry += ".";
                }
                break;
            default:
                    if (entry == "0")
                        entry = "";
                    entry += num;
                break;
            }
            txtResults.Text = entry;
        }

        string opr = "";
        double operand = 0;

        private void btnEqu_Click(object sender, EventArgs e)
        {
            double operand2 = Double.Parse(txtResults.Text);
            string cache = lblHistory.Text;
            switch (opr)
            {
                case
                    "Add":operand = operand + operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case
                    "Sub":operand = operand - operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case
                    "Mpy":operand = operand * operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case
                    "Div":operand = operand / operand2;
                    txtResults.Text = operand.ToString();
                    break;
                default:
                    break;
            }
            opr = "";
            lblHistory.Text = cache + operand2 + " =";
        }

        bool flagOpPressed = false;
        private void operator_Click(object sender, EventArgs e)
        {
            btnEqu.PerformClick();

            string cache = txtResults.Text;
            string lblOpr = "";
            operand = Double.Parse(txtResults.Text);

            Button btn = (Button)sender;
            opr = btn.Tag.ToString();
                flagOpPressed = true;
            switch (opr)
            {
                case
                    "Add":
                    lblOpr = " + ";
                    break;
                case
                    "Sub":
                    lblOpr = " - ";
                    break;
                case
                    "Mpy":
                    lblOpr = " × ";
                    break;
                case
                    "Div":
                    lblOpr = " ÷ ";
                    break;
                default:
                    break;
            }
            lblHistory.Text = cache + lblOpr;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            string cache = txtResults.Text;
            opr = "";
            operand = 0;
            flagOpPressed = true;
            txtResults.Text = "0";
            if (cache == "0") { lblHistory.Text = ""; }
            else { lblHistory.Text = "Ans = " + cache; }
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            opr = "";
            operand = 0;
            flagOpPressed = false;
            txtResults.Text = "0";
            lblHistory.Text = "";
        }

        private void btnBksp_Click(object sender, EventArgs e)
        {
            txtResults.Text = txtResults.Text.Remove(txtResults.Text.Length - 1);
        }

        private void u_operatorClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string u_opr = btn.Tag.ToString();
            string cache = txtResults.Text;
            string lblOpr = "";

            double value = Double.Parse(txtResults.Text);

            string results;
            switch (u_opr)
            {
                case "Sqrt":
                    results = Math.Sqrt(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "√";
                    break;
                case "Sqr":
                    results = Math.Pow(value,2).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "x²";
                    break;
                case "Swap":
                    value = value - value*2;
                    txtResults.Text = value.ToString();
                    break;
                case "1/x":
                    results = Math.Pow(value, -1).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "1/x";
                    break;
                case "ln":
                    results = Math.Log(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "ln";
                    break;
                case "ex":
                    results = Math.Exp(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "ex";
                    break;
                case "10x":
                    results = Math.Pow(10, value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "10x";
                    break;
                case "log10":
                    results = Math.Log10(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblOpr = "log";
                    break;
                case "sin":
                    if (radMode == true)
                    {
                        results = Math.Sin(value).ToString("N10");
                        txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    }
                    else
                    {
                        results = (Math.Sin((value * Math.PI) / 180)).ToString("N10");
                        txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    }
                    lblOpr = "sin";
                    break;
                case "cos":
                    if (radMode == true)
                    {
                        results = Math.Cos(value).ToString("N10");
                        txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    }
                    else
                    {
                        results = (Math.Cos((value * Math.PI) / 180)).ToString("N10");
                        txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    }
                    lblOpr = "cos";
                    break;
                case "tan":
                    if (radMode == true)
                    {
                        results = Math.Tan(value).ToString("N10");
                        txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    }
                    else
                    {
                        results = (Math.Tan((value * Math.PI) / 180)).ToString("N10");
                        txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    }
                    lblOpr = "tan";
                    break;
            }
            lblHistory.Text = lblOpr + "(" + cache + ")" + " =";
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            Clipboard.SetText(attribute.Value.ToString());
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnSwitch_Click(object sender, EventArgs e)
        {

        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHistory_Click(object sender, EventArgs e)
        {

        }

        bool advMode = false;
        private void btnMode_Click(object sender, EventArgs e)
        {
            if (advMode == false) 
            { 
                Size = new Size(390, 490);
                txtResults.Size = new Size(355, 45);
                lblHistory.Size = new Size(355, 30);
                advMode = true;
            }
            else
            {
                Size = new Size(265, 490);
                txtResults.Size = new Size(230, 45);
                lblHistory.Size = new Size(230, 30);
                advMode = false;
            }
        }

        bool radMode = true;
        private void btnAngle_Click(object sender, EventArgs e)
        {
            if (radMode == true)
            {
                btnAngle.Text = "Deg";
                radMode = false;
            }
            else
            {
                btnAngle.Text = "Rad";
                radMode = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            string btnnum = e.KeyCode.ToString();

            switch(btnnum)
            {
                case "D0":
                    btn0.PerformClick();
                    break;
                case "D1":
                    btn1.PerformClick();
                    break;
                case "D2":
                    btn2.PerformClick();
                    break;
                case "D3":
                    btn3.PerformClick();
                    break;
                case "D4":
                    btn4.PerformClick();
                    break;
                case "D5":
                    btn5.PerformClick();
                    break;
                case "D6":
                    btn6.PerformClick();
                    break;
                case "D7":
                    btn7.PerformClick();
                    break;
                case "D8":
                    btn8.PerformClick();
                    break;
                case "D9":
                    btn9.PerformClick();
                    break;
                case "OemPeriod":
                    btnDot.PerformClick();
                    break;
                case "Equal":
                    btnEqu.PerformClick();
                    break;
            }
        }
    }
}
