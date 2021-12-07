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
using System.Media;
using System.Speech.Synthesis;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool clicks = false;
        private void audioClicks()
        {
            SoundPlayer player = new SoundPlayer(Calculator.Properties.Resources.Clicks);
            player.Play();
        }

        bool tts = false;
        private void audioTTS(string result)
        {
            if (tts == true)
            {
                SpeechSynthesizer tts = new SpeechSynthesizer();
                tts.Speak("The computational result is" + result);
            }
        }

        private void numPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            string cache = lblHistory.Text;
            string entry = txtResults.Text;

            if (clicks == true)
            {
                audioClicks();
            }

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
            lblHistory.Text = cache + operand2 + " =";

            if (clicks == true)
            {
                audioClicks();
            }


            switch (opr)
            {
                case
                    "Add":operand = operand + operand2;
                    txtResults.Text = operand.ToString();
                    audioTTS(txtResults.Text);
                    break;
                case
                    "Sub":operand = operand - operand2;
                    txtResults.Text = operand.ToString();
                    audioTTS(txtResults.Text);
                    break;
                case
                    "Mpy":operand = operand * operand2;
                    txtResults.Text = operand.ToString();
                    audioTTS(txtResults.Text);
                    break;
                case
                    "Div":operand = operand / operand2;
                    txtResults.Text = operand.ToString();
                    audioTTS(txtResults.Text);
                    break;
                default:
                    break;
            }
            opr = "";
        }

        bool flagOpPressed = false;
        private void operator_Click(object sender, EventArgs e)
        {
            btnEqu.PerformClick();

            string cache = txtResults.Text;
            string lblOpr = "";
            operand = Double.Parse(txtResults.Text);

            if (clicks == true)
            {
                audioClicks();
            }


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
            if (clicks == true)
            {
                audioClicks();
            }

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
            if (clicks == true)
            {
                audioClicks();
            }

            opr = "";
            operand = 0;
            flagOpPressed = false;
            txtResults.Text = "0";
            lblHistory.Text = "";
        }

        private void btnBksp_Click(object sender, EventArgs e)
        {
            if (clicks == true)
            {
                audioClicks();
            }

            if (txtResults.Text.Length == 0)
            {
                
            }
            else
            {
                txtResults.Text = txtResults.Text.Remove(txtResults.Text.Length - 1);
            }
        }

        private void u_operatorClick(object sender, EventArgs e)
        {
            if (clicks == true)
            {
                audioClicks();
            }

            Button btn = (Button)sender;
            string u_opr = btn.Tag.ToString();
            string cache = txtResults.Text;

            double value = Double.Parse(txtResults.Text);

            string results;
            switch (u_opr)
            {
                case "Sqrt":
                    results = Math.Sqrt(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "√(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
                    break;
                case "Sqr":
                    results = Math.Pow(value,2).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "(" + cache + ")²" + " =";
                    audioTTS(txtResults.Text);
                    break;
                case "Swap":
                    value = value - value*2;
                    txtResults.Text = value.ToString();
                    audioTTS(txtResults.Text);
                    break;
                case "1/x":
                    results = Math.Pow(value, -1).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "1/(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
                    break;
                case "ln":
                    results = Math.Log(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "ln(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
                    break;
                case "ex":
                    results = Math.Exp(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "e^(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
                    break;
                case "10x":
                    results = Math.Pow(10, value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "10^(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
                    break;
                case "log10":
                    results = Math.Log10(value).ToString("N10");
                    txtResults.Text = results.TrimEnd('0').TrimEnd('.');
                    lblHistory.Text = "log(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
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
                    lblHistory.Text = "sin(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
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
                    lblHistory.Text = "cos(" + cache + ")" + " =";
                    audioTTS(txtResults.Text); 
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
                    lblHistory.Text = "tan(" + cache + ")" + " =";
                    audioTTS(txtResults.Text);
                    break;
            }
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

        private void calMode()
        {
            Size = new Size(265, 490);
            txtResults.Size = new Size(230, 45);
            lblHistory.Size = new Size(230, 30);
            advMode = false;
        }
        private void calSuperDuperPortableMode()
        {
            Size = new Size(265, 130);
            txtResults.Size = new Size(230, 45);
            lblHistory.Size = new Size(230, 30);
            advMode = false;
        }

        bool radMode = true;
        private void btnAngle_Click(object sender, EventArgs e)
        {
            if (radMode == true)
            {
                btnAngle.Text = "DEG";
                radMode = false;
            }
            else
            {
                btnAngle.Text = "RAD";
                radMode = true;
            }
        }

        private void btnSpk_Click(object sender, EventArgs e)
        {
            if (clicks == true)
            {
                btnSpk.ForeColor = Color.White;
                clicks = false;
            }
            else
            {
                btnSpk.ForeColor = Color.Orange;
                clicks = true;
            }
        }

        private void btnTTS_Click(object sender, EventArgs e)
        {
            if (tts == true)
            {
                btnTTS.ForeColor = Color.White;
                tts = false;
            }
            else
            {
                btnTTS.ForeColor = Color.Orange;
                tts = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResults.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            calSuperDuperPortableMode();
        }

        // INOP
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
                case "Enter":
                    btnEqu.PerformClick();
                    break;
                case "Add":
                    btnAdd.PerformClick();
                    break;
                case "Subtract":
                    btnSub.PerformClick();
                    break;
                case "Multiply":
                    btnMpy.PerformClick();
                    break;
                case "Divide":
                    btnDiv.PerformClick();
                    break;
                case "Back":
                    btnBksp.PerformClick();
                    break;
            }
        }
        //INOP

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            string btnnum = e.KeyChar.ToString();

            switch (btnnum)
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case ".":
                    btnDot.PerformClick();
                    break;
                case "=":
                    btnEqu.PerformClick();
                    break;
                case "+":
                    btnAdd.PerformClick();
                    break;
                case "-":
                    btnSub.PerformClick();
                    break;
                case "*":
                    btnMpy.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "Back":
                    btnBksp.PerformClick();
                    break;
            }
        }
    }
}
