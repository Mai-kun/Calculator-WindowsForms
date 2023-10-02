using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm1 : Form
    {

        public MainForm1()
        {
            InitializeComponent();
            btnCreateMatrix1.Text = "Create";
            btnCreateMatrix2.Text = "Create";
            txtHelp.Visible = false;
            dataGridView3.Visible = false;
        }

        #region Калькулятор

        string history;
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<HistoryForm>().Any())
            {
                HistoryForm historyForm = new HistoryForm(history);
                historyForm.Show();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (btnClean.Text == "CE")
            {
                lbAnswer.Text = "";
                history = "";
            }

            btnClean.Text = "CE";
            txtTextField.Text = "";


        }

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
            if (txtTextField.Text != "")
            {
                txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1);
            }
        }

        private static bool IsMathematicalSignOrComma(char lastSign)
        {
            if (lastSign == '/' ||
                lastSign == '*' ||
                lastSign == '-' ||
                lastSign == '+' ||
                lastSign == ',' ||
                lastSign == '^')
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

            }
            txtTextField.Text += '-';
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

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                if (IsMathematicalSignOrComma(txtTextField.Text[^1]))
                    txtTextField.Text = txtTextField.Text.Remove(txtTextField.Text.Length - 1);

                txtTextField.Text += '^';
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtTextField.Text != "")
            {
                string _number1 = null;
                string _number2 = null;
                string text = txtTextField.Text;

                try
                {
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
                catch { }
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            history += txtTextField.Text + " = ";
            try
            {
                txtTextField.Text = Calculator.Calculate(txtTextField.Text).ToString();
                history += txtTextField.Text + Environment.NewLine;
                lbAnswer.Text = "";
            }
            catch (Exception)
            {
                lbAnswer.Text = "Ошибка";
                history += lbAnswer.Text + Environment.NewLine;
                txtTextField.Text = "";
            }
        }

        private void txtTextField_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTextField.Text))
                btnClean.Text = "C";

            if (!string.IsNullOrEmpty(txtTextField.Text))
            {
                string StringForCheck = txtTextField.Text;
                try
                {
                    if (!IsMathematicalSignOrComma(StringForCheck[^1]))
                    {
                        lbAnswer.Text = Calculator.Calculate(txtTextField.Text).ToString();
                    }
                }
                catch { lbAnswer.Text = ""; }
            }
        }

        private void AddMultiplySign()
        {
            if (!string.IsNullOrEmpty(txtTextField.Text) &&
                !IsMathematicalSignOrComma(txtTextField.Text[^1]) &&
                txtTextField.Text[^1] != '(')
            {
                txtTextField.Text += '*';
            }
        }

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "(";
        }

        private void btnRightBracket_Click(object sender, EventArgs e) => txtTextField.Text += ")";

        private void btnSin_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "sin(";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "cos(";
        }

        private void btnTg_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "tan(";
        }

        private void btnCtg_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "ctg(";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "log(";
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "ln(";
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "sec(";
        }

        private void btnCsc_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "csc(";
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "abs(";
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            AddMultiplySign();
            txtTextField.Text += "exp(";
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTextField.Text) && Char.IsDigit(txtTextField.Text[^1]) || txtTextField.Text[^1] == ')')
            {
                txtTextField.Text += "!";
            }
        }

        #endregion

        #region Матрицы
        private void AutoSizeAllCells()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
        }

        private void btnCreateMatrix1_Click(object sender, EventArgs e)
        {
            if (txtRow1.Text == "" || txtСolumn1.Text == "")
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Введите размер первой матрицы";
                txtHelp.Visible = true;
            }
            else
            {
                dataGridView1.RowCount = Convert.ToInt32(txtRow1.Text);
                dataGridView1.ColumnCount = Convert.ToInt32(txtСolumn1.Text);
                AutoSizeAllCells();
                btnCreateMatrix1.Text = "Обновить";
            }
        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            AutoSizeAllCells();
        }


        private void btnCreateMatrix2_Click(object sender, EventArgs e)
        {
            if (txtRow2.Text == "" || txtСolumn2.Text == "")
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Введите размер второй матрицы";
                txtHelp.Visible = true;
            }
            else
            {
                dataGridView2.RowCount = Convert.ToInt32(txtRow2.Text);
                dataGridView2.ColumnCount = Convert.ToInt32(txtСolumn2.Text);
                AutoSizeAllCells();
                btnCreateMatrix2.Text = "Обновить";
            }
        }
        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            AutoSizeAllCells();
        }


        private void btnMatrixPlus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount != dataGridView2.ColumnCount || dataGridView1.RowCount != dataGridView2.RowCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество строк и столбцов у обоих матриц должны быь одинаковы";
                txtHelp.Visible = true;
            }
            else
            {
                txtHelp.Visible = false;
                dataGridView3.Visible = true;
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) + Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }
                dataGridView3.AutoResizeColumns();
                dataGridView3.AutoResizeRows();
            }
        }

        private void btnMatrixMinus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount != dataGridView2.ColumnCount || dataGridView1.RowCount != dataGridView2.RowCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество строк и столбцов у обоих матриц должны быь одинаковы";
                txtHelp.Visible = true;
            }
            else
            {
                txtHelp.Visible = false;
                dataGridView3.Visible = true;
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView1.ColumnCount;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) - Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                    }
                }
                dataGridView3.AutoResizeColumns();
                dataGridView3.AutoResizeRows();
            }
        }

        private void btnMatrixMultiply_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount != dataGridView2.RowCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы";
                txtHelp.Visible = true;
            }
            else if (dataGridView1.RowCount < dataGridView2.ColumnCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество срок первой матрицы должно быть меньше количества столбцов второй матрицы";
                txtHelp.Visible = true;
            }
            else
            {
                txtHelp.Visible = false;
                dataGridView3.Visible = true;
                dataGridView3.RowCount = dataGridView1.RowCount;
                dataGridView3.ColumnCount = dataGridView2.ColumnCount;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < dataGridView2.RowCount; k++)
                        {
                            temp += Convert.ToDouble(dataGridView1.Rows[i].Cells[k].Value) * Convert.ToDouble(dataGridView2.Rows[k].Cells[j].Value);
                        }
                        dataGridView3.Rows[i].Cells[j].Value = temp;
                    }
                }
                dataGridView3.AutoResizeColumns();
                dataGridView3.AutoResizeRows();
            }

        }

        private void btnMatrixDivide_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}

