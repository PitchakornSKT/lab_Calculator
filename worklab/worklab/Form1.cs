namespace worklab
{
    public partial class calculator : Form
    {
        Double resultVale = 0;
        //String opPerformed = "";
        String opPerformed = string.Empty;
        bool isOpPerformed = false;
        string fstNum,secNum;
        public calculator()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if(resultVale !=0 )
            {
                opPerformed = n.Text;

                //label1.Text = resultVale + " " + opPerformed;
                label1.Text = resultVale+" "+opPerformed;
                isOpPerformed = true;
            }else
            opPerformed= n.Text;
            resultVale = Double.Parse(textBox1.Text);
            //label1.Text = resultVale + " " + opPerformed;
            label1.Text = fstNum = $"{resultVale}{opPerformed}";
            isOpPerformed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") ||(isOpPerformed))
                textBox1.Clear();
            isOpPerformed = false;
            Button n = (Button)sender;
            if(n.Text == ".") 
            { 
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + n.Text;
            }else
            textBox1.Text = textBox1.Text + n.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(opPerformed)
                {
                case "+":
                    textBox1.Text = (resultVale + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultVale - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultVale * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultVale / Double.Parse(textBox1.Text)).ToString();
                    break;
                default: label1.Text = $"{textBox1} =";
                    break;

            }
            resultVale = Double.Parse(textBox1.Text);
            opPerformed = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}