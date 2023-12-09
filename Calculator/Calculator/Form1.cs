namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        double result;
        String option;
        private void button_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();

            }



            txt_result.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();

            }
            txt_result.Text = txt_result.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }

            txt_result.Text = txt_result.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }



            txt_result.Text = txt_result.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }

            txt_result.Text = txt_result.Text + ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }

            txt_result.Text = txt_result.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }


            txt_result.Text = txt_result.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }

            txt_result.Text = txt_result.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }


            txt_result.Text = txt_result.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }


            txt_result.Text = txt_result.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txt_result.Text == "0")
            {
                txt_result.Clear();
            }

            txt_result.Text = txt_result.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txt_result.Text);
            txt_result.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txt_result.Text);
            txt_result.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txt_result.Text);
            txt_result.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txt_result.Text);
            txt_result.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txt_result.Text);
            if (option == "+")
            {
                result = num1 + num2;
            }

            if (option == "-")
            {
                result = num1 - num2;
            }

            if (option == "*")
            {
                result = num1 * num2;
            }

            if (option == "/")
            {
                result = num1 / num2;
            }

            txt_result.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
            num1 = 0.0;
            num2 = 0.0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}