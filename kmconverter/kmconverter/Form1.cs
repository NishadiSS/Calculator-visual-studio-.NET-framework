namespace kmconverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndistance_Click(object sender, EventArgs e)
        {

            double kmdistance;

            kmdistance = double.Parse(txtmile.Text) * 1.6;
            MessageBox.Show("The distance in kilometer" + " " + kmdistance.ToString());
            txtmile.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtmile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnweight_Click(object sender, EventArgs e)
        {
            double kgweight;

            kgweight = double.Parse(txtweight.Text) * 0.45;
            MessageBox.Show("The weight in kilogram" + " " + kgweight.ToString());
            txtweight.Clear();
        }
    }
}