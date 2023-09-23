using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e) => lbTextField.Text = "";

        private void btn0_Click(object sender, EventArgs e) => lbTextField.Text += "0";

        private void btn1_Click(object sender, EventArgs e) => lbTextField.Text += "1";

        private void btn2_Click(object sender, EventArgs e) => lbTextField.Text += "2";

        private void btn3_Click(object sender, EventArgs e) => lbTextField.Text += "3";

        private void btn4_Click(object sender, EventArgs e) => lbTextField.Text += "4";

        private void btn5_Click(object sender, EventArgs e) => lbTextField.Text += "5";

        private void btn6_Click(object sender, EventArgs e) => lbTextField.Text += "6";

        private void btn7_Click(object sender, EventArgs e) => lbTextField.Text += "7";

        private void btn8_Click(object sender, EventArgs e) => lbTextField.Text += "8";

        private void btn9_Click(object sender, EventArgs e) => lbTextField.Text += "9";


        private void btnDelete_Click(object sender, EventArgs e) => lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - 1);


        private bool IsMathemaicalSignOrComma(string formula)
        {
            if (formula[formula.Length - 1] == '/' ||
                formula[formula.Length - 1] == '*' ||
                formula[formula.Length - 1] == '-' ||
                formula[formula.Length - 1] == '+' ||
                formula[formula.Length - 1] == ',')
            {
                return true;
            }
            else return false;
        }

        private void btnComma_Click(object sender, EventArgs e) => lbTextField.Text += ",";

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (lbTextField.Text != "")
            {
                if (IsMathemaicalSignOrComma(lbTextField.Text))
                    lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - 1);
                    
                lbTextField.Text += '/';
            }
        }

        private void btnMultipli_Click(object sender, EventArgs e)
        {
            if (lbTextField.Text != "")
            {
                if (IsMathemaicalSignOrComma(lbTextField.Text))
                    lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - 1);

                lbTextField.Text += '*';
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lbTextField.Text != "")
            {
                if (IsMathemaicalSignOrComma(lbTextField.Text))
                    lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - 1);

                lbTextField.Text += '-';
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lbTextField.Text != "")
            {
                if (IsMathemaicalSignOrComma(lbTextField.Text))
                    lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - 1);

                lbTextField.Text += '+';
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (lbTextField.Text != "")
            {
                string _number1 = null;
                string _number2 = null;
                string text = lbTextField.Text;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '/' || text[i] == '*' || text[i] == '-' || text[i] == '+')
                    {
                        for (i++; i < text.Length; i++)
                        {
                            _number2 += text[i];
                        }
                    }
                    else
                    {
                        _number1 += text[i];
                    }
                }

                double temp1 = Convert.ToDouble(_number1);
                double tepm2 = Convert.ToDouble(_number2);

                double PercentNumber;
                if (_number2 == null)
                {
                    PercentNumber = temp1 / 100;
                    lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - _number1.Length, _number1.Length);
                }
                else
                {
                    PercentNumber = (temp1 * tepm2) / 100;
                    lbTextField.Text = lbTextField.Text.Remove(lbTextField.Text.Length - _number2.Length, _number2.Length);
                }

                lbTextField.Text += PercentNumber;
            }
        }
        
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            lbTextField.Text = lbAnswer.Text;
            lbAnswer.Text = "";
        }

        private void lbTextField_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbTextField.Text))
            {
                if (IsMathemaicalSignOrComma(lbTextField.Text))
                {
                    string StringWithoutLastSign = lbTextField.Text.Remove(lbTextField.Text.Length - 1);
                    lbAnswer.Text = new DataTable().Compute(StringWithoutLastSign.Replace(",", "."), null).ToString();
                }
                else
                {
                    lbAnswer.Text = new DataTable().Compute(lbTextField.Text.Replace(",", "."), null).ToString();
                }
            }
        }
    }
}

//TODO: Ошибки:
//TODO: Ограничить ввод чисел для строки



