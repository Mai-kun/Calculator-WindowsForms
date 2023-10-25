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
            txtHelp.Visible = false;
            txtHelpData.Visible = false;
            txtHelpTemperature.Visible = false;
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
                txtTextField.Text = Utilities.Calculator.Calculate(txtTextField.Text).ToString();
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
                        lbAnswer.Text = Utilities.Calculator.Calculate(txtTextField.Text).ToString();
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

        private void btnE_Click(object sender, EventArgs e) => txtTextField.Text += "e";
        private void btnPi_Click(object sender, EventArgs e) => txtTextField.Text += "p";
        #endregion

        #region Матрицы

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
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                btnCreateMatrix1.Text = "Обновить";
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

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
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoResizeRows();
                btnCreateMatrix2.Text = "Обновить";
            }
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
        }


        private void btnMatrixPlus_Click(object sender, EventArgs e)
        {
            if (txtRow1.Text == "" || txtСolumn1.Text == "" || txtRow2.Text == "" || txtСolumn2.Text == "")
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Задайте размер матриц(ы)";
                txtHelp.Visible = true;
                return;
            }
            if (dataGridView1.ColumnCount != dataGridView2.ColumnCount || dataGridView1.RowCount != dataGridView2.RowCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество строк и столбцов у обоих матриц должны быь одинаковы";
                txtHelp.Visible = true;
                return;
            }

            txtHelp.Visible = false;
            dataGridView3.Visible = true;
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) + Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoResizeRows();
        }

        private void btnMatrixMinus_Click(object sender, EventArgs e)
        {
            if (txtRow1.Text == "" || txtСolumn1.Text == "" || txtRow2.Text == "" || txtСolumn2.Text == "")
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Задайте размер матриц(ы)";
                txtHelp.Visible = true;
                return;
            }
            if (dataGridView1.ColumnCount != dataGridView2.ColumnCount || dataGridView1.RowCount != dataGridView2.RowCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество строк и столбцов у обоих матриц должны быть одинаковы";
                txtHelp.Visible = true;
                return;
            }

            txtHelp.Visible = false;
            dataGridView3.Visible = true;
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView1.ColumnCount;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) - Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
                }
            }
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoResizeRows();
        }

        private void btnMatrixMultiply_Click(object sender, EventArgs e)
        {
            if (txtRow1.Text == "" || txtСolumn1.Text == "" || txtRow2.Text == "" || txtСolumn2.Text == "")
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Задайте размер матриц(ы)";
                txtHelp.Visible = true;
                return;
            }
            if (dataGridView1.ColumnCount != dataGridView2.RowCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы";
                txtHelp.Visible = true;
                return;
            }
            if (dataGridView1.RowCount < dataGridView2.ColumnCount)
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Количество срок первой матрицы должно быть меньше количества столбцов второй матрицы";
                txtHelp.Visible = true;
                return;
            }

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

        private void btnMatrixDivide_Click(object sender, EventArgs e)
        {
            if (txtRow1.Text == "" || txtСolumn1.Text == "" || txtRow2.Text == "" || txtСolumn2.Text == "")
            {
                txtHelp.Text = "Ошибка:" + Environment.NewLine +
                    "Задайте размер матриц(ы)";
                txtHelp.Visible = true;
                return;
            }

            txtHelp.Text = "Функция пока не работает, может быть в дальнейшем у разработчика дойдут руки, чтобы это сделать";
            txtHelp.Visible = true;
        }

        #endregion

        #region Переводы

        #region InformationData
        private int selectedState1 = -1;
        private int selectedState2 = -1;
        private double firstNumber;
        private bool flagData = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState1 = cbData1.SelectedIndex;
            if ((txtData1.Text != "" || txtData2.Text != "") && (selectedState1 != -1 && selectedState2 != -1))
            {
                flagData = true;
                txtData2.Text = Utilities.СonvertingData.Convert(firstNumber, selectedState1, selectedState2);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState2 = cbData2.SelectedIndex;
            if ((txtData1.Text != "" || txtData2.Text != "") && (selectedState1 != -1 && selectedState2 != -1))
            {
                flagData = true;
                txtData2.Text = Utilities.СonvertingData.Convert(firstNumber, selectedState1, selectedState2);
            }
        }

        private void txtData1_TextChanged(object sender, EventArgs e)
        {
            if (flagData == true)
            {
                flagData = false;
                return;
            }

            try
            {
                firstNumber = double.Parse(txtData1.Text.Replace('.', ','));
                flagData = true;

                if (selectedState1 != -1 && selectedState2 != -1)
                {
                    txtHelpData.Visible = false;
                    txtData2.Text = Utilities.СonvertingData.Convert(firstNumber, selectedState1, selectedState2);
                }
            }
            catch (Exception)
            {
                txtHelpData.Text = "Ошибка" + Environment.NewLine +
                    "Введены неверные данные (Допустимы только числа)";
                txtHelpData.Visible = true;
            }
        }

        private void txtData2_TextChanged(object sender, EventArgs e)
        {
            if (flagData == true)
            {
                flagData = false;
                return;
            }

            try
            {
                flagData = true;
                double secondNumber = double.Parse(txtData2.Text.Replace(".", ","));
                if (selectedState1 != -1 && selectedState2 != -1)
                {
                    txtHelpData.Visible = false;
                    txtData1.Text = Utilities.СonvertingData.Convert(secondNumber, selectedState2, selectedState1);
                }
            }
            catch (Exception)
            {
                txtHelpData.Text = "Ошибка" + Environment.NewLine +
                    "Введены неверные данные (Допустимы только числа)";
                txtHelpData.Visible = true;
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            (cbData1.SelectedIndex, cbData2.SelectedIndex) =
                (cbData2.SelectedIndex, cbData1.SelectedIndex);
        }
        #endregion InformationData

        #region Temperature
        private int selectionStateTemp1 = -1;
        private int selectionStateTemp2 = -1;
        private double firstNumberTemp;
        private bool flagTemperature = false;


        private void cbTemperature1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionStateTemp1 = cbTemperature1.SelectedIndex;
            if ((txtTemperature1.Text != "" || txtTemperature2.Text != "") && (selectionStateTemp1 != -1 && selectionStateTemp2 != -1))
            {
                flagTemperature = true;
                txtTemperature2.Text = Utilities.ConvertingTemperature.Convert(firstNumberTemp, selectionStateTemp1, selectionStateTemp2);
            }
        }

        private void cbTemperature2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionStateTemp2 = cbTemperature2.SelectedIndex;
            if ((txtTemperature1.Text != "" || txtTemperature2.Text != "") && (selectionStateTemp1 != -1 && selectionStateTemp2 != -1))
            {
                flagTemperature = true;
                txtTemperature2.Text = Utilities.ConvertingTemperature.Convert(firstNumberTemp, selectionStateTemp1, selectionStateTemp2);
            }
        }

        private void txtTemperature1_TextChanged(object sender, EventArgs e)
        {
            if (flagTemperature == true)
            {
                flagTemperature = false;
                return;
            }

            try
            {
                firstNumberTemp = double.Parse(txtTemperature1.Text.Replace('.', ','));
                flagTemperature = true;

                if (selectionStateTemp1 != -1 && selectionStateTemp2 != -1)
                {
                    txtHelpTemperature.Visible = false;
                    txtTemperature2.Text = Utilities.ConvertingTemperature.Convert(firstNumberTemp, selectionStateTemp1, selectionStateTemp2);
                }
            }
            catch (Exception)
            {
                txtHelpTemperature.Text = "Ошибка" + Environment.NewLine +
                    "Введены неверные данные (Допустимы только числа)";
                txtHelpTemperature.Visible = true;
            }
        }

        private void txtTemperature2_TextChanged(object sender, EventArgs e)
        {
            if (flagTemperature == true)
            {
                flagTemperature = false;
                return;
            }

            try
            {
                double secondNumberTemp = double.Parse(txtTemperature2.Text.Replace('.', ','));
                flagTemperature = true;

                if (selectionStateTemp1 != -1 && selectionStateTemp2 != -1)
                {
                    txtHelpTemperature.Visible = false;
                    txtTemperature1.Text = Utilities.ConvertingTemperature.Convert(secondNumberTemp, selectionStateTemp2, selectionStateTemp1);
                }
            }
            catch (Exception)
            {
                txtHelpTemperature.Text = "Ошибка" + Environment.NewLine +
                    "Введены неверные данные (Допустимы только числа)";
                txtHelpTemperature.Visible = true;
            }
        }

        private void btnChangeTemperature_Click(object sender, EventArgs e)
        {
            (cbTemperature1.SelectedIndex, cbTemperature2.SelectedIndex) =
                (cbTemperature2.SelectedIndex, cbTemperature1.SelectedIndex);
        }
        #endregion Temperature

        #endregion Переводы



    }
}

