namespace Calculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnMpy = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnBksp = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btn10x = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.btnAngle = new System.Windows.Forms.Button();
            this.btnSpk = new System.Windows.Forms.Button();
            this.btnTTS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn7.Location = new System.Drawing.Point(10, 200);
            this.btn7.Margin = new System.Windows.Forms.Padding(5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numPad_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.txtResults.ForeColor = System.Drawing.Color.White;
            this.txtResults.Location = new System.Drawing.Point(10, 50);
            this.txtResults.Margin = new System.Windows.Forms.Padding(5);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(355, 35);
            this.txtResults.TabIndex = 1;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn8.Location = new System.Drawing.Point(70, 200);
            this.btn8.Margin = new System.Windows.Forms.Padding(5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numPad_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn9.Location = new System.Drawing.Point(130, 200);
            this.btn9.Margin = new System.Windows.Forms.Padding(5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numPad_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn4.Location = new System.Drawing.Point(10, 260);
            this.btn4.Margin = new System.Windows.Forms.Padding(5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numPad_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn5.Location = new System.Drawing.Point(70, 260);
            this.btn5.Margin = new System.Windows.Forms.Padding(5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numPad_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn6.Location = new System.Drawing.Point(130, 260);
            this.btn6.Margin = new System.Windows.Forms.Padding(5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numPad_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1.Location = new System.Drawing.Point(10, 320);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numPad_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn2.Location = new System.Drawing.Point(70, 320);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numPad_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn3.Location = new System.Drawing.Point(130, 320);
            this.btn3.Margin = new System.Windows.Forms.Padding(5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numPad_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn0.Location = new System.Drawing.Point(10, 380);
            this.btn0.Margin = new System.Windows.Forms.Padding(5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 10;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numPad_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDot.Location = new System.Drawing.Point(70, 380);
            this.btnDot.Margin = new System.Windows.Forms.Padding(5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(50, 50);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.numPad_Click);
            this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCE.Location = new System.Drawing.Point(10, 140);
            this.btnCE.Margin = new System.Windows.Forms.Padding(5);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 12;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            this.btnCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(132)))), ((int)(((byte)(181)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(190, 380);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operator_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSqrt.Location = new System.Drawing.Point(315, 140);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(5);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(50, 50);
            this.btnSqrt.TabIndex = 14;
            this.btnSqrt.Tag = "Sqrt";
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.u_operatorClick);
            this.btnSqrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnEqu
            // 
            this.btnEqu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(172)))), ((int)(((byte)(231)))));
            this.btnEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEqu.Location = new System.Drawing.Point(130, 380);
            this.btnEqu.Margin = new System.Windows.Forms.Padding(5);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(50, 50);
            this.btnEqu.TabIndex = 0;
            this.btnEqu.Tag = "Equ";
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = false;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            this.btnEqu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(132)))), ((int)(((byte)(181)))));
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSub.Location = new System.Drawing.Point(190, 320);
            this.btnSub.Margin = new System.Windows.Forms.Padding(5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 50);
            this.btnSub.TabIndex = 16;
            this.btnSub.Tag = "Sub";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.operator_Click);
            this.btnSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnSqr
            // 
            this.btnSqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSqr.Location = new System.Drawing.Point(315, 200);
            this.btnSqr.Margin = new System.Windows.Forms.Padding(5);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(50, 50);
            this.btnSqr.TabIndex = 17;
            this.btnSqr.Tag = "Sqr";
            this.btnSqr.Text = "x²";
            this.btnSqr.UseVisualStyleBackColor = false;
            this.btnSqr.Click += new System.EventHandler(this.u_operatorClick);
            this.btnSqr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblID.Location = new System.Drawing.Point(11, 435);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "Ilhan, 202064P, E1";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // btnMpy
            // 
            this.btnMpy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(132)))), ((int)(((byte)(181)))));
            this.btnMpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMpy.Location = new System.Drawing.Point(190, 260);
            this.btnMpy.Margin = new System.Windows.Forms.Padding(5);
            this.btnMpy.Name = "btnMpy";
            this.btnMpy.Size = new System.Drawing.Size(50, 50);
            this.btnMpy.TabIndex = 19;
            this.btnMpy.Tag = "Mpy";
            this.btnMpy.Text = "×";
            this.btnMpy.UseVisualStyleBackColor = false;
            this.btnMpy.Click += new System.EventHandler(this.operator_Click);
            this.btnMpy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(132)))), ((int)(((byte)(181)))));
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDiv.Location = new System.Drawing.Point(190, 200);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 50);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.Tag = "Div";
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.operator_Click);
            this.btnDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnBksp
            // 
            this.btnBksp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnBksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBksp.Location = new System.Drawing.Point(130, 140);
            this.btnBksp.Margin = new System.Windows.Forms.Padding(5);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(50, 50);
            this.btnBksp.TabIndex = 21;
            this.btnBksp.Tag = "Bksp";
            this.btnBksp.Text = "⌫";
            this.btnBksp.UseVisualStyleBackColor = false;
            this.btnBksp.Click += new System.EventHandler(this.btnBksp_Click);
            this.btnBksp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnC.Location = new System.Drawing.Point(70, 140);
            this.btnC.Margin = new System.Windows.Forms.Padding(5);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 22;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(132)))), ((int)(((byte)(181)))));
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSwitch.Location = new System.Drawing.Point(190, 140);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(50, 50);
            this.btnSwitch.TabIndex = 23;
            this.btnSwitch.Tag = "Swap";
            this.btnSwitch.Text = "+/-";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.u_operatorClick);
            this.btnSwitch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // lblHistory
            // 
            this.lblHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHistory.Location = new System.Drawing.Point(10, 9);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(355, 30);
            this.lblHistory.TabIndex = 24;
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHistory.TextChanged += new System.EventHandler(this.lblHistory_TextChanged);
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMode.Location = new System.Drawing.Point(10, 105);
            this.btnMode.Margin = new System.Windows.Forms.Padding(5);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(50, 25);
            this.btnMode.TabIndex = 25;
            this.btnMode.Tag = "";
            this.btnMode.Text = "Mode";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1x.Location = new System.Drawing.Point(315, 260);
            this.btn1x.Margin = new System.Windows.Forms.Padding(5);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(50, 50);
            this.btn1x.TabIndex = 26;
            this.btn1x.Tag = "1/x";
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.u_operatorClick);
            this.btn1x.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSin.Location = new System.Drawing.Point(255, 140);
            this.btnSin.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(50, 50);
            this.btnSin.TabIndex = 27;
            this.btnSin.Tag = "sin";
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.u_operatorClick);
            this.btnSin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCos.Location = new System.Drawing.Point(255, 200);
            this.btnCos.Margin = new System.Windows.Forms.Padding(5);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(50, 50);
            this.btnCos.TabIndex = 28;
            this.btnCos.Tag = "cos";
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.u_operatorClick);
            this.btnCos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTan.Location = new System.Drawing.Point(255, 260);
            this.btnTan.Margin = new System.Windows.Forms.Padding(5);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(50, 50);
            this.btnTan.TabIndex = 29;
            this.btnTan.Tag = "tan";
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.u_operatorClick);
            this.btnTan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnLog10
            // 
            this.btnLog10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnLog10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLog10.Location = new System.Drawing.Point(255, 380);
            this.btnLog10.Margin = new System.Windows.Forms.Padding(5);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(50, 50);
            this.btnLog10.TabIndex = 30;
            this.btnLog10.Tag = "log10";
            this.btnLog10.Text = "log";
            this.btnLog10.UseVisualStyleBackColor = false;
            this.btnLog10.Click += new System.EventHandler(this.u_operatorClick);
            this.btnLog10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btn10x
            // 
            this.btn10x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btn10x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn10x.Location = new System.Drawing.Point(315, 380);
            this.btn10x.Margin = new System.Windows.Forms.Padding(5);
            this.btn10x.Name = "btn10x";
            this.btn10x.Size = new System.Drawing.Size(50, 50);
            this.btn10x.TabIndex = 31;
            this.btn10x.Tag = "10x";
            this.btn10x.Text = "10ˣ";
            this.btn10x.UseVisualStyleBackColor = false;
            this.btn10x.Click += new System.EventHandler(this.u_operatorClick);
            this.btn10x.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLn.Location = new System.Drawing.Point(255, 320);
            this.btnLn.Margin = new System.Windows.Forms.Padding(5);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(50, 50);
            this.btnLn.TabIndex = 32;
            this.btnLn.Tag = "ln";
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.u_operatorClick);
            this.btnLn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnex.Location = new System.Drawing.Point(315, 320);
            this.btnex.Margin = new System.Windows.Forms.Padding(5);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(50, 50);
            this.btnex.TabIndex = 33;
            this.btnex.Tag = "ex";
            this.btnex.Text = "eˣ";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.u_operatorClick);
            this.btnex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnAngle
            // 
            this.btnAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAngle.Location = new System.Drawing.Point(255, 105);
            this.btnAngle.Margin = new System.Windows.Forms.Padding(5);
            this.btnAngle.Name = "btnAngle";
            this.btnAngle.Size = new System.Drawing.Size(50, 25);
            this.btnAngle.TabIndex = 34;
            this.btnAngle.Tag = "";
            this.btnAngle.Text = "Rad";
            this.btnAngle.UseVisualStyleBackColor = false;
            this.btnAngle.Click += new System.EventHandler(this.btnAngle_Click);
            // 
            // btnSpk
            // 
            this.btnSpk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnSpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSpk.Location = new System.Drawing.Point(70, 105);
            this.btnSpk.Margin = new System.Windows.Forms.Padding(5);
            this.btnSpk.Name = "btnSpk";
            this.btnSpk.Size = new System.Drawing.Size(50, 25);
            this.btnSpk.TabIndex = 35;
            this.btnSpk.Tag = "";
            this.btnSpk.Text = "Spk";
            this.btnSpk.UseVisualStyleBackColor = false;
            this.btnSpk.Click += new System.EventHandler(this.btnSpk_Click);
            // 
            // btnTTS
            // 
            this.btnTTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTTS.Location = new System.Drawing.Point(130, 105);
            this.btnTTS.Margin = new System.Windows.Forms.Padding(5);
            this.btnTTS.Name = "btnTTS";
            this.btnTTS.Size = new System.Drawing.Size(50, 25);
            this.btnTTS.TabIndex = 36;
            this.btnTTS.Tag = "";
            this.btnTTS.Text = "TTS";
            this.btnTTS.UseVisualStyleBackColor = false;
            this.btnTTS.Click += new System.EventHandler(this.btnTTS_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(374, 451);
            this.Controls.Add(this.btnTTS);
            this.Controls.Add(this.btnSpk);
            this.Controls.Add(this.btnAngle);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btn10x);
            this.Controls.Add(this.btnLog10);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnBksp);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMpy);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btn7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnMpy;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnBksp;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btn10x;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnAngle;
        private System.Windows.Forms.Button btnSpk;
        private System.Windows.Forms.Button btnTTS;
    }
}

