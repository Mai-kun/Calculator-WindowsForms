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

        private void btnClean_Click(object sender, EventArgs e) => txtTextField.Text = "";

        private void btn0_Click(object sender, EventArgs e) => txtTextField.Text += "0";

        private void btn1_Click(object sender, EventArgs e) => txtTextField.Text += "1";

        private void btn2_Click(object sender, EventArgs e) => txtTextField.Text += "2";

        private void btn3_Click(object sender, EventArgs e) => txtTextField.Text += "3";

        private void btn4_Click(object sender, EventArgs e) => txtTextField.Text += "4";

        private void btn5_Click(object sender, EventArgs e) => txtTextField.Text += "5";

        private void btn6_Click(object sender, EventArgs e) => txtTextField.Text += "6";

        private void btn7_Click(object sender, EventArgs e) => txtTextField.Text += "7";

        private void btn8_Click(object sender, EventArgs e) => txtTextField.Text += "8";

        private void btn9_Click(object sender, EventArgs e) => txtTextField.Text += "9";


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1); }
            catch { }
        }

        private static bool IsMathematicalSignOrComma(char formula)
        {
            if (formula == '/' ||
                formula == '*' ||
                formula == '-' ||
                formula == '+' ||
                formula == ',')
            {
                return true;
            }
            else return false;
        }

        private void btnComma_Click(object sender, EventArgs e) => txtTextField.Text += ",";

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                if (IsMathematicalSignOrComma(txtTextField.Text[^1]))
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1);

                txtTextField.Text += '/';
            }
        }

        private void btnMultipli_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                if (IsMathematicalSignOrComma(txtTextField.Text[^1]))
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1);

                txtTextField.Text += '*';
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                if (IsMathematicalSignOrComma(txtTextField.Text[^1]))
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1);

                txtTextField.Text += '-';
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                if (IsMathematicalSignOrComma(txtTextField.Text[^1]))
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1);

                txtTextField.Text += '+';
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                string _number1 = null;
                string _number2 = null;
                string text = txtTextField.Text;

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
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - _number1.Length, _number1.Length);
                }
                else
                {
                    PercentNumber = (temp1 * tepm2) / 100;
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - _number2.Length, _number2.Length);
                }

                txtTextField.Text += PercentNumber;
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                txtTextField.Text = CalculatorWithParser.Calc(txtTextField.Text.Replace(",", ".")).ToString(); ;
                lbAnswer.Text = "";
            }
            catch (Exception)
            {
                lbAnswer.Text = "Error";
                txtTextField.Text = "";
            }
        }

        private void txtTextField_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTextField.Text))
            {
                string StringForCheck = txtTextField.Text;
                try
                {
                    if (!IsMathematicalSignOrComma(StringForCheck[^1]))
                    {
                        lbAnswer.Text = CalculatorWithParser.Calc(txtTextField.Text).ToString();
                    }
                }
                catch { }
            }
        }


        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsMathematicalSignOrComma(txtTextField.Text[^1]))
                {
                    txtTextField.Text += '*';
                }
            }
            catch { }

            txtTextField.Text += "(";
        }

        private void btnRightBracket_Click(object sender, EventArgs e) => txtTextField.Text += ")";

        private void btnCeil_Click(object sender, EventArgs e)
        {

        }
    }
}

//TODO Обработать случай мат. символа и скобки    *)
//TODO Обработать случай мат. символа и скобки    (5-6*)
//TODO Обработать случай мат. символа и скобки    5-6)
//TODO Обработать случай                          ()

