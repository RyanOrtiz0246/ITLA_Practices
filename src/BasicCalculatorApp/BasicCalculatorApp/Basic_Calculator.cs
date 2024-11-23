namespace BasicCalculatorApp
{
    public partial class Basic_Calculator : Form
    {
        public Basic_Calculator()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (ValidateEntries(out double num1, out double num2))
            {
                double result = num1 + num2;
                listBoxResult.Items.Add($"Addition: {num1} + {num2} = {result}");
            }
        }

        private void btnSubtration_Click(object sender, EventArgs e)
        {
            if (ValidateEntries(out double num1, out double num2))
            {
                double result = num1 - num2;
                listBoxResult.Items.Add($"Subtration: {num1} - {num2} = {result}");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textNumber1.Clear();
            textNumber2.Clear();
            listBoxResult.Items.Clear();
        }

        private bool ValidateEntries(out double num1, out double num2)
        {
            bool valid = true;
            num1 = 0;
            num2 = 0;

            if (!double.TryParse(textNumber1.Text, out num1))
            {
                MessageBox.Show("Enter a valid number in field 1.");
                valid = false;
            }

            if (!double.TryParse(textNumber2.Text, out num2))
            {
                MessageBox.Show("Enter a valid number in field 2.");
                valid = false;
            }

            return valid;
        }
        private void Basic_Calculator_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Pictures", "274.jpg");
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}