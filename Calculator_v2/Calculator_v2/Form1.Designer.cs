namespace Calculator_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.rtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.btn1 = new Calculator_v2.RjControl.RjButton();
            this.btn2 = new Calculator_v2.RjControl.RjButton();
            this.btnPlus = new Calculator_v2.RjControl.RjButton();
            this.btn3 = new Calculator_v2.RjControl.RjButton();
            this.btnSubtrac = new Calculator_v2.RjControl.RjButton();
            this.btn6 = new Calculator_v2.RjControl.RjButton();
            this.btn5 = new Calculator_v2.RjControl.RjButton();
            this.btn4 = new Calculator_v2.RjControl.RjButton();
            this.btnMultiply = new Calculator_v2.RjControl.RjButton();
            this.btn9 = new Calculator_v2.RjControl.RjButton();
            this.btn8 = new Calculator_v2.RjControl.RjButton();
            this.btn7 = new Calculator_v2.RjControl.RjButton();
            this.btnDivision = new Calculator_v2.RjControl.RjButton();
            this.btnBs = new Calculator_v2.RjControl.RjButton();
            this.btnClearAll = new Calculator_v2.RjControl.RjButton();
            this.btnClear = new Calculator_v2.RjControl.RjButton();
            this.btn0 = new Calculator_v2.RjControl.RjButton();
            this.btnDot = new Calculator_v2.RjControl.RjButton();
            this.btnEquals = new Calculator_v2.RjControl.RjButton();
            this.pnlTitle.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.button2);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(350, 40);
            this.pnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(300, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.rtBoxDisplayHistory);
            this.pnlHistory.Controls.Add(this.btnClearHistory);
            this.pnlHistory.Location = new System.Drawing.Point(0, 565);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(350, 5);
            this.pnlHistory.TabIndex = 1;
            // 
            // rtBoxDisplayHistory
            // 
            this.rtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.rtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoxDisplayHistory.ForeColor = System.Drawing.Color.Black;
            this.rtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.rtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.rtBoxDisplayHistory.Name = "rtBoxDisplayHistory";
            this.rtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.rtBoxDisplayHistory.TabIndex = 2;
            this.rtBoxDisplayHistory.Text = "";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
            this.btnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.btnClearHistory.TabIndex = 1;
            this.btnClearHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 3;
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Font = new System.Drawing.Font("Browallia New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay2.ForeColor = System.Drawing.Color.White;
            this.txtDisplay2.Location = new System.Drawing.Point(-9, 91);
            this.txtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(350, 30);
            this.txtDisplay2.TabIndex = 4;
            this.txtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay1.Font = new System.Drawing.Font("Browallia New", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay1.ForeColor = System.Drawing.Color.White;
            this.txtDisplay1.Location = new System.Drawing.Point(-4, 121);
            this.txtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(345, 68);
            this.txtDisplay1.TabIndex = 5;
            this.txtDisplay1.Text = "0";
            this.txtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay1.TextChanged += new System.EventHandler(this.txtDisplay1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.BackgroundColor = System.Drawing.Color.Silver;
            this.btn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn1.BorderRadius = 5;
            this.btn1.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(3, 450);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(85, 55);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.Black;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.BackgroundColor = System.Drawing.Color.Silver;
            this.btn2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn2.BorderRadius = 5;
            this.btn2.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(89, 450);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn2.Size = new System.Drawing.Size(85, 55);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.Black;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Gray;
            this.btnPlus.BackgroundColor = System.Drawing.Color.Gray;
            this.btnPlus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlus.BorderRadius = 5;
            this.btnPlus.BorderSize = 0;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(263, 450);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlus.Size = new System.Drawing.Size(85, 55);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.TextColor = System.Drawing.Color.Black;
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnMath);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.BackgroundColor = System.Drawing.Color.Silver;
            this.btn3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn3.BorderRadius = 5;
            this.btn3.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(176, 450);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn3.Size = new System.Drawing.Size(85, 55);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.Black;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSubtrac
            // 
            this.btnSubtrac.BackColor = System.Drawing.Color.Gray;
            this.btnSubtrac.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSubtrac.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubtrac.BorderRadius = 5;
            this.btnSubtrac.BorderSize = 0;
            this.btnSubtrac.FlatAppearance.BorderSize = 0;
            this.btnSubtrac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrac.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtrac.ForeColor = System.Drawing.Color.Black;
            this.btnSubtrac.Location = new System.Drawing.Point(263, 393);
            this.btnSubtrac.Name = "btnSubtrac";
            this.btnSubtrac.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSubtrac.Size = new System.Drawing.Size(85, 55);
            this.btnSubtrac.TabIndex = 16;
            this.btnSubtrac.Text = "-";
            this.btnSubtrac.TextColor = System.Drawing.Color.Black;
            this.btnSubtrac.UseVisualStyleBackColor = false;
            this.btnSubtrac.Click += new System.EventHandler(this.btnMath);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.BackgroundColor = System.Drawing.Color.Silver;
            this.btn6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn6.BorderRadius = 5;
            this.btn6.BorderSize = 0;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(176, 393);
            this.btn6.Name = "btn6";
            this.btn6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn6.Size = new System.Drawing.Size(85, 55);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.Black;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.BackgroundColor = System.Drawing.Color.Silver;
            this.btn5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn5.BorderRadius = 5;
            this.btn5.BorderSize = 0;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(89, 393);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn5.Size = new System.Drawing.Size(85, 55);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.Black;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.BackgroundColor = System.Drawing.Color.Silver;
            this.btn4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn4.BorderRadius = 5;
            this.btn4.BorderSize = 0;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(3, 393);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn4.Size = new System.Drawing.Size(85, 55);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.Black;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Gray;
            this.btnMultiply.BackgroundColor = System.Drawing.Color.Gray;
            this.btnMultiply.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMultiply.BorderRadius = 5;
            this.btnMultiply.BorderSize = 0;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(263, 336);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMultiply.Size = new System.Drawing.Size(85, 55);
            this.btnMultiply.TabIndex = 20;
            this.btnMultiply.Text = "×";
            this.btnMultiply.TextColor = System.Drawing.Color.Black;
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMath);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.BackgroundColor = System.Drawing.Color.Silver;
            this.btn9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn9.BorderRadius = 5;
            this.btn9.BorderSize = 0;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(176, 336);
            this.btn9.Name = "btn9";
            this.btn9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn9.Size = new System.Drawing.Size(85, 55);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.TextColor = System.Drawing.Color.Black;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.BackgroundColor = System.Drawing.Color.Silver;
            this.btn8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn8.BorderRadius = 5;
            this.btn8.BorderSize = 0;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(89, 336);
            this.btn8.Name = "btn8";
            this.btn8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn8.Size = new System.Drawing.Size(85, 55);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.Black;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.BackgroundColor = System.Drawing.Color.Silver;
            this.btn7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn7.BorderRadius = 5;
            this.btn7.BorderSize = 0;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(3, 336);
            this.btn7.Name = "btn7";
            this.btn7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn7.Size = new System.Drawing.Size(85, 55);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.Black;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Gray;
            this.btnDivision.BackgroundColor = System.Drawing.Color.Gray;
            this.btnDivision.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDivision.BorderRadius = 5;
            this.btnDivision.BorderSize = 0;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.ForeColor = System.Drawing.Color.Black;
            this.btnDivision.Location = new System.Drawing.Point(263, 280);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDivision.Size = new System.Drawing.Size(85, 55);
            this.btnDivision.TabIndex = 24;
            this.btnDivision.Text = "÷";
            this.btnDivision.TextColor = System.Drawing.Color.Black;
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnMath);
            // 
            // btnBs
            // 
            this.btnBs.BackColor = System.Drawing.Color.Gray;
            this.btnBs.BackgroundColor = System.Drawing.Color.Gray;
            this.btnBs.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBs.BorderRadius = 5;
            this.btnBs.BorderSize = 0;
            this.btnBs.FlatAppearance.BorderSize = 0;
            this.btnBs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBs.Font = new System.Drawing.Font("Browallia New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBs.ForeColor = System.Drawing.Color.Black;
            this.btnBs.Image = ((System.Drawing.Image)(resources.GetObject("btnBs.Image")));
            this.btnBs.Location = new System.Drawing.Point(176, 280);
            this.btnBs.Name = "btnBs";
            this.btnBs.Size = new System.Drawing.Size(85, 55);
            this.btnBs.TabIndex = 23;
            this.btnBs.TextColor = System.Drawing.Color.Black;
            this.btnBs.UseVisualStyleBackColor = false;
            this.btnBs.Click += new System.EventHandler(this.btnBs_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Gray;
            this.btnClearAll.BackgroundColor = System.Drawing.Color.Gray;
            this.btnClearAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClearAll.BorderRadius = 5;
            this.btnClearAll.BorderSize = 0;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(89, 280);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClearAll.Size = new System.Drawing.Size(85, 55);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.Text = "CE";
            this.btnClearAll.TextColor = System.Drawing.Color.Black;
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.BackgroundColor = System.Drawing.Color.Gray;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 5;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(3, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClear.Size = new System.Drawing.Size(85, 55);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.BackgroundColor = System.Drawing.Color.Silver;
            this.btn0.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn0.BorderRadius = 5;
            this.btn0.BorderSize = 0;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(3, 507);
            this.btn0.Name = "btn0";
            this.btn0.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btn0.Size = new System.Drawing.Size(171, 55);
            this.btn0.TabIndex = 25;
            this.btn0.Text = "0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0.TextColor = System.Drawing.Color.Black;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Silver;
            this.btnDot.BackgroundColor = System.Drawing.Color.Silver;
            this.btnDot.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDot.BorderRadius = 5;
            this.btnDot.BorderSize = 0;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(176, 507);
            this.btnDot.Name = "btnDot";
            this.btnDot.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDot.Size = new System.Drawing.Size(85, 55);
            this.btnDot.TabIndex = 26;
            this.btnDot.Text = ".";
            this.btnDot.TextColor = System.Drawing.Color.Black;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEquals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEquals.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEquals.BorderRadius = 5;
            this.btnEquals.BorderSize = 0;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.ForeColor = System.Drawing.Color.Black;
            this.btnEquals.Location = new System.Drawing.Point(263, 507);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEquals.Size = new System.Drawing.Size(85, 55);
            this.btnEquals.TabIndex = 27;
            this.btnEquals.Text = "=";
            this.btnEquals.TextColor = System.Drawing.Color.Black;
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnBs);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubtrac);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTitle.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTitle;
        private Button button2;
        private Button button1;
        private Button btnExit;
        private Panel pnlHistory;
        private Panel panel1;
        private TextBox txtDisplay2;
        private TextBox txtDisplay1;
        private RichTextBox rtBoxDisplayHistory;
        private Button btnClearHistory;
        private RjControl.RjButton btn1;
        private RjControl.RjButton btn2;
        private RjControl.RjButton btnPlus;
        private RjControl.RjButton btn3;
        private RjControl.RjButton btnSubtrac;
        private RjControl.RjButton btn6;
        private RjControl.RjButton btn5;
        private RjControl.RjButton btn4;
        private RjControl.RjButton btnMultiply;
        private RjControl.RjButton btn9;
        private RjControl.RjButton btn8;
        private RjControl.RjButton btn7;
        private RjControl.RjButton btnDivision;
        private RjControl.RjButton btnBs;
        private RjControl.RjButton btnClearAll;
        private RjControl.RjButton btnClear;
        private RjControl.RjButton btn0;
        private RjControl.RjButton btnDot;
        private RjControl.RjButton btnEquals;
    }
}