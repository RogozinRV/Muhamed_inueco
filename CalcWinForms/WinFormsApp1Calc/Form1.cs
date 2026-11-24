using calc;

namespace WinFormsApp1Calc
{
    public partial class Form1 : Form
    {
        double firstNum;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        // ¬се цифры и точка идут сюда
        private void Number_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        // ќперации
        private void button12_Click(object sender, EventArgs e) { SaveNumber("+"); }
        private void button13_Click(object sender, EventArgs e) { SaveNumber("-"); }
        private void button14_Click(object sender, EventArgs e) { SaveNumber("*"); }
        private void button15_Click(object sender, EventArgs e) { SaveNumber("/"); }

        // –авно
        private void button11_Click(object sender, EventArgs e)
        {
            double secondNum = double.Parse(textBox1.Text);
            double result = 0;

            if (operation == "+") result = Operations.Add(new double[] { firstNum, secondNum });
            if (operation == "-") result = Operations.Subtract(firstNum, secondNum);
            if (operation == "*") result = Operations.Multiply(new double[] { firstNum, secondNum });
            if (operation == "/") result = Operations.Divide(firstNum, secondNum);

            textBox1.Text = result.ToString();
        }

        // C Ч сброс всего
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNum = 0;
            operation = "";
        }

        // CE Ч очистить ввод
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        // % Ч процент
        private void button18_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            textBox1.Text = Operations.ToPercent(value).ToString();
        }

        private void SaveNumber(string op)
        {
            firstNum = double.Parse(textBox1.Text);
            operation = op;
            textBox1.Clear();
        }
    }
}