using System.Globalization;

namespace CalculadoraWinFormsApp1
{
    public partial class Form1 : Form
    {
        private double firstValue;
        private double secondValue;
        private double result;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void handleAddNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (operation == "")
            {
                ResultField.Text += button.Text;
                firstValue = Convert.ToDouble(ResultField.Text, new CultureInfo("en-US"));
            }
            else
            {
                ResultField.Text += button.Text;
                secondValue = double.Parse(ResultField.Text);
            }
        }

        private void handleAddOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ResultField.Text += " ";
            ResultField.Text += button.Text;
            operation = button.Text;
            ResultField.Text = "";
        }

        private void handleCalculateNumbers(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "x":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    result = firstValue / secondValue;
                    break;
            }

            ResultField.Text = "";
            ResultField.Text = result.ToString();
        }

        private void handleCleanCalculator(object sender, EventArgs e)
        {
            firstValue = 0;
            secondValue = 0;
            operation = "";
            ResultField.Text = "";
            result = 0;
        }
    }
}