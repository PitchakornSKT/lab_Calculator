using System.Runtime.InteropServices;

namespace Calculator_minimal
{
    public partial class Form1 : Form
    {
        //Fields
        Double result = 0;
        string operation = string.Empty;
        bool enterValue = false;
        string fstNum, secNum;
        string operationPerformed = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0" || enterValue) txtDisplay1.Text = string.Empty
                    txtDisplay1.Clear();

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!txtDisplay1.Text.Contains("."))
                    txtDisplay1.Text = txtDisplay1.Text + button.Text;
            }
            else
            txtDisplay1.Text = txtDisplay1.Text + button.Text;
        }

        private void BtnMath_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                txtDisplay2.Text = result + " " + operationPerformed;
                enterValue = true;
            }
            else result = Double.Parse(txtDisplay1.Text);
            operationPerformed = button.Text;
            enterValue = true;
            if(txtDisplay1.Text != "0")
            {
                txtDisplay2.Text = fstNum = $"{result}{operation}";
                txtDisplay1.Text = string.Empty;
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            result = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secNum = txtDisplay1.Text;
            txtDisplay2.Text = $"{txtDisplay2.Text} {txtDisplay1.Text} =";
            if (txtDisplay1.Text != string.Empty)
            {
                if (txtDisplay1.Text == "0") txtDisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        txtDisplay1.Text = (result + Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "-":
                        txtDisplay1.Text = (result - Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "×":
                        txtDisplay1.Text = (result * Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "÷":
                        txtDisplay1.Text = (result / Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    default: txtDisplay2.Text = $"{txtDisplay1} =";
                        break;
                }
            }
            result = Double.Parse(txtDisplay1.Text);
            operation = string.Empty;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length > 0)
                txtDisplay1.Text = txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1, 1);
            if (txtDisplay1.Text == string.Empty) txtDisplay1.Text = "0";
        }
    }
}