using Calculator_v2.RjControl;
using System;
using System.Diagnostics;

namespace Calculator_v2
{
    public partial class Form1 : Form
    {
        //Fields
        Double result = 0;
        string operation = string.Empty;
        string fstNum,secNum;
        bool enterValue = false;
        private bool value;

        public Form1()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMath(object sender, EventArgs e)
        {
            if (result != 0) btnEquals.PerformClick();
            else result = Double.Parse(txtDisplay1.Text);

            RjButton button = (RjButton)sender;
            operation = button.Text;
            enterValue = true;
            if (txtDisplay1.Text != "0")
            {
                txtDisplay2.Text = fstNum = $"{result} {operation}";
                txtDisplay1.Text = string.Empty;
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secNum = txtDisplay1.Text;
            txtDisplay2.Text = $"{txtDisplay2.Text} {txtDisplay1.Text} =";
            if (txtDisplay1.Text != string.Empty)
            {
                if (txtDisplay1.Text == "0") txtDisplay2.Text = string.Empty;
                switch(operation)
                {
                    case "+":
                        txtDisplay1.Text = (result + Double.Parse(txtDisplay1.Text)).ToString();
                        rtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {txtDisplay1.Text} \n");
                        break;
                    case "-":
                        txtDisplay1.Text = (result - Double.Parse(txtDisplay1.Text)).ToString();
                        rtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {txtDisplay1.Text} \n");
                        break;
                    case "×":
                        txtDisplay1.Text = (result * Double.Parse(txtDisplay1.Text)).ToString();
                        rtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {txtDisplay1.Text} \n");
                        break;
                    case "÷":
                        txtDisplay1.Text = (result / Double.Parse(txtDisplay1.Text)).ToString();
                        rtBoxDisplayHistory.AppendText($"{fstNum}{secNum} = {txtDisplay1.Text} \n");
                        break;
                    default: txtDisplay2.Text = $"{txtDisplay1.Text} = ";
                        break;
                }

                result = Double.Parse(txtDisplay1.Text);
                operation = string.Empty;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Height = (pnlHistory.Height == 5) ? pnlHistory.Height = 345 : 5;
        }

        private void btnBs_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length > 0)
                txtDisplay1.Text = txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1, 1);
            if (txtDisplay1.Text == string.Empty) txtDisplay1.Text = "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            txtDisplay2.Text = string.Empty;
            result = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDisplay1_TextChanged(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length > 0)
            {
                txtDisplay1.Text = Convert.ToDouble(txtDisplay1.Text).ToString("N0");
                txtDisplay1.SelectionStart = txtDisplay1.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if(txtDisplay1.Text == "0" || enterValue) txtDisplay1.Text = string.Empty;

            enterValue = false;
            RjButton button = (RjButton)sender;
            if(button.Text == ".")
            {
                if(!txtDisplay1.Text.Contains("."))
                    txtDisplay1.Text = txtDisplay1.Text + button.Text;
            }
             else txtDisplay1.Text = txtDisplay1.Text + button.Text;
           
        }
    }
}