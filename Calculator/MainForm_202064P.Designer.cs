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
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn7.Location = new System.Drawing.Point(10, 200);
            this.btn7.Margin = new System.Windows.Forms.Padding(5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numPad_Click);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(10, 50);
            this.txtResults.Margin = new System.Windows.Forms.Padding(5);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(230, 45);
            this.txtResults.TabIndex = 1;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn8.Location = new System.Drawing.Point(70, 200);
            this.btn8.Margin = new System.Windows.Forms.Padding(5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn9.Location = new System.Drawing.Point(130, 200);
            this.btn9.Margin = new System.Windows.Forms.Padding(5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn4.Location = new System.Drawing.Point(10, 260);
            this.btn4.Margin = new System.Windows.Forms.Padding(5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn5.Location = new System.Drawing.Point(70, 260);
            this.btn5.Margin = new System.Windows.Forms.Padding(5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn6.Location = new System.Drawing.Point(130, 260);
            this.btn6.Margin = new System.Windows.Forms.Padding(5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn1.Location = new System.Drawing.Point(10, 320);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn2.Location = new System.Drawing.Point(70, 320);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn3.Location = new System.Drawing.Point(130, 320);
            this.btn3.Margin = new System.Windows.Forms.Padding(5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn0.Location = new System.Drawing.Point(10, 380);
            this.btn0.Margin = new System.Windows.Forms.Padding(5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(110, 50);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDot.Location = new System.Drawing.Point(130, 380);
            this.btnDot.Margin = new System.Windows.Forms.Padding(5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(50, 50);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.numPad_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Transparent;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCE.Location = new System.Drawing.Point(10, 140);
            this.btnCE.Margin = new System.Windows.Forms.Padding(5);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 12;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAdd.Location = new System.Drawing.Point(190, 320);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(253, 140);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(45, 49);
            this.btnSqrt.TabIndex = 14;
            this.btnSqrt.Tag = "Sqrt";
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.u_operatorClick);
            // 
            // btnEqu
            // 
            this.btnEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEqu.Location = new System.Drawing.Point(190, 380);
            this.btnEqu.Margin = new System.Windows.Forms.Padding(5);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(50, 50);
            this.btnEqu.TabIndex = 15;
            this.btnEqu.Tag = "Equ";
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = true;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSub.Location = new System.Drawing.Point(190, 260);
            this.btnSub.Margin = new System.Windows.Forms.Padding(5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 50);
            this.btnSub.TabIndex = 16;
            this.btnSub.Tag = "Sub";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqr.Location = new System.Drawing.Point(253, 87);
            this.btnSqr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(45, 49);
            this.btnSqr.TabIndex = 17;
            this.btnSqr.Tag = "Sqr";
            this.btnSqr.Text = "x²";
            this.btnSqr.UseVisualStyleBackColor = true;
            this.btnSqr.Click += new System.EventHandler(this.u_operatorClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
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
            this.btnMpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMpy.Location = new System.Drawing.Point(190, 200);
            this.btnMpy.Margin = new System.Windows.Forms.Padding(5);
            this.btnMpy.Name = "btnMpy";
            this.btnMpy.Size = new System.Drawing.Size(50, 50);
            this.btnMpy.TabIndex = 19;
            this.btnMpy.Tag = "Mpy";
            this.btnMpy.Text = "×";
            this.btnMpy.UseVisualStyleBackColor = true;
            this.btnMpy.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDiv.Location = new System.Drawing.Point(190, 140);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 50);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.Tag = "Div";
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnBksp
            // 
            this.btnBksp.BackColor = System.Drawing.Color.Transparent;
            this.btnBksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBksp.Location = new System.Drawing.Point(190, 105);
            this.btnBksp.Margin = new System.Windows.Forms.Padding(5);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(50, 25);
            this.btnBksp.TabIndex = 21;
            this.btnBksp.Tag = "Bksp";
            this.btnBksp.Text = "⌫";
            this.btnBksp.UseVisualStyleBackColor = false;
            this.btnBksp.Click += new System.EventHandler(this.btnBksp_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnC.Location = new System.Drawing.Point(70, 140);
            this.btnC.Margin = new System.Windows.Forms.Padding(5);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 22;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSwitch.Location = new System.Drawing.Point(130, 140);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(50, 50);
            this.btnSwitch.TabIndex = 23;
            this.btnSwitch.Tag = "Swap";
            this.btnSwitch.Text = "+/-";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.u_operatorClick);
            // 
            // lblHistory
            // 
            this.lblHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHistory.Location = new System.Drawing.Point(40, 9);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(200, 30);
            this.lblHistory.TabIndex = 24;
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHistory.TextChanged += new System.EventHandler(this.lblHistory_TextChanged);
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 451);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Calculator";
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
    }
}

