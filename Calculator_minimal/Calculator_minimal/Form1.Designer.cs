namespace Calculator_minimal
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
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisplay2.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(270, 30);
            this.txtDisplay2.TabIndex = 0;
            this.txtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay1.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDisplay1.Location = new System.Drawing.Point(-2, 42);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(297, 114);
            this.txtDisplay1.TabIndex = 1;
            this.txtDisplay1.Text = "0";
            this.txtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnDivide.Location = new System.Drawing.Point(220, 158);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 57);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnMultiply.Location = new System.Drawing.Point(220, 215);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 57);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnMinus.Location = new System.Drawing.Point(220, 272);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 57);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnPlus.Location = new System.Drawing.Point(220, 329);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 57);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(195)))), ((int)(((byte)(20)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnEqual.Location = new System.Drawing.Point(220, 386);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 57);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.DimGray;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnDot.Location = new System.Drawing.Point(145, 386);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 57);
            this.btnDot.TabIndex = 13;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.DimGray;
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum0.Location = new System.Drawing.Point(-5, 386);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(150, 57);
            this.btnNum0.TabIndex = 14;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.DimGray;
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum3.Location = new System.Drawing.Point(145, 329);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(75, 57);
            this.btnNum3.TabIndex = 15;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.DimGray;
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum2.Location = new System.Drawing.Point(70, 329);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(75, 57);
            this.btnNum2.TabIndex = 16;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.DimGray;
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum1.Location = new System.Drawing.Point(-5, 329);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(75, 57);
            this.btnNum1.TabIndex = 17;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.DimGray;
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum4.Location = new System.Drawing.Point(-5, 272);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(75, 57);
            this.btnNum4.TabIndex = 18;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.DimGray;
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum5.Location = new System.Drawing.Point(70, 272);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(75, 57);
            this.btnNum5.TabIndex = 19;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.DimGray;
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum6.Location = new System.Drawing.Point(145, 272);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(75, 57);
            this.btnNum6.TabIndex = 20;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.DimGray;
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum7.Location = new System.Drawing.Point(-5, 215);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(75, 57);
            this.btnNum7.TabIndex = 21;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.DimGray;
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum8.Location = new System.Drawing.Point(70, 215);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(75, 57);
            this.btnNum8.TabIndex = 22;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.DimGray;
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnNum9.Location = new System.Drawing.Point(145, 215);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(75, 57);
            this.btnNum9.TabIndex = 23;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnClear2.FlatAppearance.BorderSize = 0;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnClear2.Location = new System.Drawing.Point(70, 158);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 57);
            this.btnClear2.TabIndex = 24;
            this.btnClear2.Text = "C";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(145, 158);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 57);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnClear1.FlatAppearance.BorderSize = 0;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnClear1.Location = new System.Drawing.Point(-5, 158);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 57);
            this.btnClear1.TabIndex = 26;
            this.btnClear1.Text = "CE";
            this.btnClear1.UseVisualStyleBackColor = false;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(294, 441);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.txtDisplay2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDisplay2;
        private TextBox txtDisplay1;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnNum0;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnClear2;
        private Button btn_delete;
        private Button btnClear1;
        protected internal Button btnDot;
    }
}