using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class MainForm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnDevide = new Button();
            btnMultipli = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnAnswer = new Button();
            btnComma = new Button();
            btnClean = new Button();
            btnDelete = new Button();
            btnPercent = new Button();
            lbAnswer = new Label();
            btnLeftBracket = new Button();
            btnRightBracket = new Button();
            btnPow = new Button();
            btnE = new Button();
            btnPi = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnFact = new Button();
            btnAbs = new Button();
            btnLn = new Button();
            btnLog = new Button();
            btnCsc = new Button();
            btnSec = new Button();
            btnCtg = new Button();
            btnTg = new Button();
            txtTextField = new TextBox();
            btnExp = new Button();
            tabControl1 = new TabControl();
            tabcCalc = new TabPage();
            btnHistory = new Button();
            tabMatrix = new TabPage();
            txtHelp = new TextBox();
            dataGridView3 = new DataGridView();
            btnMatrixDivide = new Button();
            btnMatrixMultiply = new Button();
            btnMatrixMinus = new Button();
            btnMatrixPlus = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            btnCreateMatrix2 = new Button();
            txtRow2 = new TextBox();
            txtСolumn2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCreateMatrix1 = new Button();
            txtRow1 = new TextBox();
            txtСolumn1 = new TextBox();
            tabTransfers = new TabPage();
            txtHelpTemperature = new TextBox();
            txtTemperature2 = new TextBox();
            txtTemperature1 = new TextBox();
            cbTemperature2 = new ComboBox();
            cbTemperature1 = new ComboBox();
            btnChangeTemperature = new Button();
            label5 = new Label();
            btnChangeData = new Button();
            txtHelpData = new TextBox();
            txtData2 = new TextBox();
            txtData1 = new TextBox();
            cbData2 = new ComboBox();
            cbData1 = new ComboBox();
            lbData = new Label();
            tabControl1.SuspendLayout();
            tabcCalc.SuspendLayout();
            tabMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabTransfers.SuspendLayout();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(19, 218);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.RightToLeft = RightToLeft.No;
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(83, 218);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.RightToLeft = RightToLeft.No;
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(148, 218);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.RightToLeft = RightToLeft.No;
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(19, 284);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.RightToLeft = RightToLeft.No;
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(83, 284);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.RightToLeft = RightToLeft.No;
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(148, 284);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.RightToLeft = RightToLeft.No;
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(19, 350);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.RightToLeft = RightToLeft.No;
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(83, 350);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.RightToLeft = RightToLeft.No;
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(148, 350);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.RightToLeft = RightToLeft.No;
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(83, 416);
            btn0.Margin = new Padding(4, 3, 4, 3);
            btn0.Name = "btn0";
            btn0.RightToLeft = RightToLeft.No;
            btn0.Size = new Size(60, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDevide
            // 
            btnDevide.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDevide.Location = new Point(218, 152);
            btnDevide.Margin = new Padding(4, 3, 4, 3);
            btnDevide.Name = "btnDevide";
            btnDevide.RightToLeft = RightToLeft.No;
            btnDevide.Size = new Size(60, 60);
            btnDevide.TabIndex = 11;
            btnDevide.Text = "/";
            btnDevide.UseVisualStyleBackColor = true;
            btnDevide.Click += btnDevide_Click;
            // 
            // btnMultipli
            // 
            btnMultipli.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultipli.Location = new Point(218, 218);
            btnMultipli.Margin = new Padding(4, 3, 4, 3);
            btnMultipli.Name = "btnMultipli";
            btnMultipli.RightToLeft = RightToLeft.No;
            btnMultipli.Size = new Size(60, 60);
            btnMultipli.TabIndex = 12;
            btnMultipli.Text = "x";
            btnMultipli.UseVisualStyleBackColor = true;
            btnMultipli.Click += btnMultipli_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(218, 284);
            btnMinus.Margin = new Padding(4, 3, 4, 3);
            btnMinus.Name = "btnMinus";
            btnMinus.RightToLeft = RightToLeft.No;
            btnMinus.Size = new Size(60, 60);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(218, 350);
            btnPlus.Margin = new Padding(4, 3, 4, 3);
            btnPlus.Name = "btnPlus";
            btnPlus.RightToLeft = RightToLeft.No;
            btnPlus.Size = new Size(60, 60);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnswer.Location = new Point(218, 416);
            btnAnswer.Margin = new Padding(4, 3, 4, 3);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.RightToLeft = RightToLeft.No;
            btnAnswer.Size = new Size(60, 60);
            btnAnswer.TabIndex = 15;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnComma
            // 
            btnComma.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnComma.Location = new Point(148, 416);
            btnComma.Margin = new Padding(4, 3, 4, 3);
            btnComma.Name = "btnComma";
            btnComma.RightToLeft = RightToLeft.No;
            btnComma.Size = new Size(60, 60);
            btnComma.TabIndex = 16;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btnClean
            // 
            btnClean.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClean.Location = new Point(19, 152);
            btnClean.Margin = new Padding(4, 3, 4, 3);
            btnClean.Name = "btnClean";
            btnClean.RightToLeft = RightToLeft.No;
            btnClean.Size = new Size(60, 60);
            btnClean.TabIndex = 17;
            btnClean.Text = "CE";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(83, 152);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(60, 60);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "<=";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPercent.Location = new Point(148, 152);
            btnPercent.Margin = new Padding(4, 3, 4, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.RightToLeft = RightToLeft.No;
            btnPercent.Size = new Size(60, 60);
            btnPercent.TabIndex = 19;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // lbAnswer
            // 
            lbAnswer.BackColor = SystemColors.Window;
            lbAnswer.BorderStyle = BorderStyle.FixedSingle;
            lbAnswer.Enabled = false;
            lbAnswer.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer.Location = new Point(19, 94);
            lbAnswer.Margin = new Padding(4, 0, 4, 0);
            lbAnswer.Name = "lbAnswer";
            lbAnswer.Size = new Size(532, 55);
            lbAnswer.TabIndex = 21;
            lbAnswer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLeftBracket
            // 
            btnLeftBracket.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeftBracket.Location = new Point(287, 152);
            btnLeftBracket.Margin = new Padding(4, 3, 4, 3);
            btnLeftBracket.Name = "btnLeftBracket";
            btnLeftBracket.RightToLeft = RightToLeft.No;
            btnLeftBracket.Size = new Size(60, 60);
            btnLeftBracket.TabIndex = 22;
            btnLeftBracket.Text = "(";
            btnLeftBracket.UseVisualStyleBackColor = true;
            btnLeftBracket.Click += btnLeftBracket_Click;
            // 
            // btnRightBracket
            // 
            btnRightBracket.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRightBracket.Location = new Point(355, 152);
            btnRightBracket.Margin = new Padding(4, 3, 4, 3);
            btnRightBracket.Name = "btnRightBracket";
            btnRightBracket.RightToLeft = RightToLeft.No;
            btnRightBracket.Size = new Size(60, 60);
            btnRightBracket.TabIndex = 23;
            btnRightBracket.Text = ")";
            btnRightBracket.UseVisualStyleBackColor = true;
            btnRightBracket.Click += btnRightBracket_Click;
            // 
            // btnPow
            // 
            btnPow.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPow.Location = new Point(423, 218);
            btnPow.Margin = new Padding(4, 3, 4, 3);
            btnPow.Name = "btnPow";
            btnPow.RightToLeft = RightToLeft.No;
            btnPow.Size = new Size(60, 60);
            btnPow.TabIndex = 24;
            btnPow.Text = "x^y\r\n";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnPow_Click;
            // 
            // btnE
            // 
            btnE.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnE.Location = new Point(423, 152);
            btnE.Margin = new Padding(4, 3, 4, 3);
            btnE.Name = "btnE";
            btnE.RightToLeft = RightToLeft.No;
            btnE.Size = new Size(60, 60);
            btnE.TabIndex = 25;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnE_Click;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPi.Location = new Point(491, 152);
            btnPi.Margin = new Padding(4, 3, 4, 3);
            btnPi.Name = "btnPi";
            btnPi.RightToLeft = RightToLeft.No;
            btnPi.Size = new Size(60, 60);
            btnPi.TabIndex = 26;
            btnPi.Text = "Pi";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSin.Location = new Point(287, 218);
            btnSin.Margin = new Padding(4, 3, 4, 3);
            btnSin.Name = "btnSin";
            btnSin.RightToLeft = RightToLeft.No;
            btnSin.Size = new Size(60, 60);
            btnSin.TabIndex = 27;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCos.Location = new Point(355, 218);
            btnCos.Margin = new Padding(4, 3, 4, 3);
            btnCos.Name = "btnCos";
            btnCos.RightToLeft = RightToLeft.No;
            btnCos.Size = new Size(60, 60);
            btnCos.TabIndex = 28;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnFact
            // 
            btnFact.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFact.Location = new Point(491, 218);
            btnFact.Margin = new Padding(4, 3, 4, 3);
            btnFact.Name = "btnFact";
            btnFact.RightToLeft = RightToLeft.No;
            btnFact.Size = new Size(60, 60);
            btnFact.TabIndex = 31;
            btnFact.Text = "n!";
            btnFact.UseVisualStyleBackColor = true;
            btnFact.Click += btnFact_Click;
            // 
            // btnAbs
            // 
            btnAbs.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbs.Location = new Point(423, 350);
            btnAbs.Margin = new Padding(4, 3, 4, 3);
            btnAbs.Name = "btnAbs";
            btnAbs.RightToLeft = RightToLeft.No;
            btnAbs.Size = new Size(60, 60);
            btnAbs.TabIndex = 40;
            btnAbs.Text = "|x|";
            btnAbs.UseVisualStyleBackColor = true;
            btnAbs.Click += btnAbs_Click;
            // 
            // btnLn
            // 
            btnLn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLn.Location = new Point(355, 350);
            btnLn.Margin = new Padding(4, 3, 4, 3);
            btnLn.Name = "btnLn";
            btnLn.RightToLeft = RightToLeft.No;
            btnLn.Size = new Size(60, 60);
            btnLn.TabIndex = 38;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = true;
            btnLn.Click += btnLn_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.Location = new Point(287, 350);
            btnLog.Margin = new Padding(4, 3, 4, 3);
            btnLog.Name = "btnLog";
            btnLog.RightToLeft = RightToLeft.No;
            btnLog.Size = new Size(60, 60);
            btnLog.TabIndex = 37;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnCsc
            // 
            btnCsc.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCsc.Location = new Point(491, 284);
            btnCsc.Margin = new Padding(4, 3, 4, 3);
            btnCsc.Name = "btnCsc";
            btnCsc.RightToLeft = RightToLeft.No;
            btnCsc.Size = new Size(60, 60);
            btnCsc.TabIndex = 36;
            btnCsc.Text = "csc";
            btnCsc.UseVisualStyleBackColor = true;
            btnCsc.Click += btnCsc_Click;
            // 
            // btnSec
            // 
            btnSec.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSec.Location = new Point(423, 284);
            btnSec.Margin = new Padding(4, 3, 4, 3);
            btnSec.Name = "btnSec";
            btnSec.RightToLeft = RightToLeft.No;
            btnSec.Size = new Size(60, 60);
            btnSec.TabIndex = 35;
            btnSec.Text = "sec";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnCtg
            // 
            btnCtg.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCtg.Location = new Point(355, 284);
            btnCtg.Margin = new Padding(4, 3, 4, 3);
            btnCtg.Name = "btnCtg";
            btnCtg.RightToLeft = RightToLeft.No;
            btnCtg.Size = new Size(60, 60);
            btnCtg.TabIndex = 33;
            btnCtg.Text = "ctg";
            btnCtg.UseVisualStyleBackColor = true;
            btnCtg.Click += btnCtg_Click;
            // 
            // btnTg
            // 
            btnTg.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTg.Location = new Point(287, 284);
            btnTg.Margin = new Padding(4, 3, 4, 3);
            btnTg.Name = "btnTg";
            btnTg.RightToLeft = RightToLeft.No;
            btnTg.Size = new Size(60, 60);
            btnTg.TabIndex = 32;
            btnTg.Text = "tg";
            btnTg.UseVisualStyleBackColor = true;
            btnTg.Click += btnTg_Click;
            // 
            // txtTextField
            // 
            txtTextField.BackColor = SystemColors.Window;
            txtTextField.BorderStyle = BorderStyle.FixedSingle;
            txtTextField.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTextField.ForeColor = Color.Black;
            txtTextField.Location = new Point(19, 9);
            txtTextField.Multiline = true;
            txtTextField.Name = "txtTextField";
            txtTextField.ReadOnly = true;
            txtTextField.RightToLeft = RightToLeft.No;
            txtTextField.ScrollBars = ScrollBars.Vertical;
            txtTextField.Size = new Size(549, 82);
            txtTextField.TabIndex = 42;
            txtTextField.TabStop = false;
            txtTextField.TextAlign = HorizontalAlignment.Right;
            txtTextField.TextChanged += txtTextField_TextChanged;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnExp.Location = new Point(491, 350);
            btnExp.Margin = new Padding(4, 3, 4, 3);
            btnExp.Name = "btnExp";
            btnExp.RightToLeft = RightToLeft.No;
            btnExp.Size = new Size(60, 60);
            btnExp.TabIndex = 43;
            btnExp.Text = "exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += btnExp_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabcCalc);
            tabControl1.Controls.Add(tabMatrix);
            tabControl1.Controls.Add(tabTransfers);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(586, 525);
            tabControl1.TabIndex = 44;
            // 
            // tabcCalc
            // 
            tabcCalc.Controls.Add(btnHistory);
            tabcCalc.Controls.Add(btnExp);
            tabcCalc.Controls.Add(txtTextField);
            tabcCalc.Controls.Add(btnAbs);
            tabcCalc.Controls.Add(lbAnswer);
            tabcCalc.Controls.Add(btnLn);
            tabcCalc.Controls.Add(btnLeftBracket);
            tabcCalc.Controls.Add(btnLog);
            tabcCalc.Controls.Add(btn7);
            tabcCalc.Controls.Add(btnCsc);
            tabcCalc.Controls.Add(btn8);
            tabcCalc.Controls.Add(btnSec);
            tabcCalc.Controls.Add(btn9);
            tabcCalc.Controls.Add(btnCtg);
            tabcCalc.Controls.Add(btn4);
            tabcCalc.Controls.Add(btnTg);
            tabcCalc.Controls.Add(btn5);
            tabcCalc.Controls.Add(btnFact);
            tabcCalc.Controls.Add(btn6);
            tabcCalc.Controls.Add(btnCos);
            tabcCalc.Controls.Add(btn1);
            tabcCalc.Controls.Add(btnSin);
            tabcCalc.Controls.Add(btn2);
            tabcCalc.Controls.Add(btnPi);
            tabcCalc.Controls.Add(btn3);
            tabcCalc.Controls.Add(btnE);
            tabcCalc.Controls.Add(btn0);
            tabcCalc.Controls.Add(btnPow);
            tabcCalc.Controls.Add(btnDevide);
            tabcCalc.Controls.Add(btnRightBracket);
            tabcCalc.Controls.Add(btnMultipli);
            tabcCalc.Controls.Add(btnMinus);
            tabcCalc.Controls.Add(btnPercent);
            tabcCalc.Controls.Add(btnPlus);
            tabcCalc.Controls.Add(btnDelete);
            tabcCalc.Controls.Add(btnAnswer);
            tabcCalc.Controls.Add(btnClean);
            tabcCalc.Controls.Add(btnComma);
            tabcCalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabcCalc.Location = new Point(4, 29);
            tabcCalc.Name = "tabcCalc";
            tabcCalc.Padding = new Padding(3);
            tabcCalc.Size = new Size(578, 492);
            tabcCalc.TabIndex = 1;
            tabcCalc.Text = "Калькулятор";
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.Location = new Point(423, 416);
            btnHistory.Margin = new Padding(4, 3, 4, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.RightToLeft = RightToLeft.No;
            btnHistory.Size = new Size(128, 60);
            btnHistory.TabIndex = 44;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // tabMatrix
            // 
            tabMatrix.Controls.Add(txtHelp);
            tabMatrix.Controls.Add(dataGridView3);
            tabMatrix.Controls.Add(btnMatrixDivide);
            tabMatrix.Controls.Add(btnMatrixMultiply);
            tabMatrix.Controls.Add(btnMatrixMinus);
            tabMatrix.Controls.Add(btnMatrixPlus);
            tabMatrix.Controls.Add(dataGridView1);
            tabMatrix.Controls.Add(dataGridView2);
            tabMatrix.Controls.Add(label3);
            tabMatrix.Controls.Add(label4);
            tabMatrix.Controls.Add(btnCreateMatrix2);
            tabMatrix.Controls.Add(txtRow2);
            tabMatrix.Controls.Add(txtСolumn2);
            tabMatrix.Controls.Add(label2);
            tabMatrix.Controls.Add(label1);
            tabMatrix.Controls.Add(btnCreateMatrix1);
            tabMatrix.Controls.Add(txtRow1);
            tabMatrix.Controls.Add(txtСolumn1);
            tabMatrix.Location = new Point(4, 29);
            tabMatrix.Name = "tabMatrix";
            tabMatrix.Padding = new Padding(3);
            tabMatrix.Size = new Size(578, 492);
            tabMatrix.TabIndex = 0;
            tabMatrix.Text = "Матрицы";
            tabMatrix.UseVisualStyleBackColor = true;
            // 
            // txtHelp
            // 
            txtHelp.BackColor = Color.MistyRose;
            txtHelp.Enabled = false;
            txtHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHelp.Location = new Point(341, 282);
            txtHelp.Multiline = true;
            txtHelp.Name = "txtHelp";
            txtHelp.ReadOnly = true;
            txtHelp.Size = new Size(226, 184);
            txtHelp.TabIndex = 18;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.ColumnHeadersVisible = false;
            dataGridView3.Location = new Point(109, 280);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView3.Size = new Size(226, 186);
            dataGridView3.TabIndex = 17;
            // 
            // btnMatrixDivide
            // 
            btnMatrixDivide.FlatAppearance.BorderColor = Color.Black;
            btnMatrixDivide.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMatrixDivide.Location = new Point(247, 226);
            btnMatrixDivide.Name = "btnMatrixDivide";
            btnMatrixDivide.Size = new Size(88, 41);
            btnMatrixDivide.TabIndex = 16;
            btnMatrixDivide.Text = "/";
            btnMatrixDivide.UseVisualStyleBackColor = true;
            btnMatrixDivide.Click += btnMatrixDivide_Click;
            // 
            // btnMatrixMultiply
            // 
            btnMatrixMultiply.FlatAppearance.BorderColor = Color.Black;
            btnMatrixMultiply.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMatrixMultiply.Location = new Point(247, 182);
            btnMatrixMultiply.Name = "btnMatrixMultiply";
            btnMatrixMultiply.Size = new Size(88, 41);
            btnMatrixMultiply.TabIndex = 15;
            btnMatrixMultiply.Text = "*";
            btnMatrixMultiply.UseVisualStyleBackColor = true;
            btnMatrixMultiply.Click += btnMatrixMultiply_Click;
            // 
            // btnMatrixMinus
            // 
            btnMatrixMinus.FlatAppearance.BorderColor = Color.Black;
            btnMatrixMinus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMatrixMinus.Location = new Point(247, 138);
            btnMatrixMinus.Name = "btnMatrixMinus";
            btnMatrixMinus.Size = new Size(88, 41);
            btnMatrixMinus.TabIndex = 14;
            btnMatrixMinus.Text = "-";
            btnMatrixMinus.UseVisualStyleBackColor = true;
            btnMatrixMinus.Click += btnMatrixMinus_Click;
            // 
            // btnMatrixPlus
            // 
            btnMatrixPlus.FlatAppearance.BorderColor = Color.Black;
            btnMatrixPlus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMatrixPlus.Location = new Point(247, 94);
            btnMatrixPlus.Name = "btnMatrixPlus";
            btnMatrixPlus.Size = new Size(88, 41);
            btnMatrixPlus.TabIndex = 13;
            btnMatrixPlus.Text = "+";
            btnMatrixPlus.UseVisualStyleBackColor = true;
            btnMatrixPlus.Click += btnMatrixPlus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(15, 88);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(226, 186);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Location = new Point(341, 88);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView2.Size = new Size(226, 186);
            dataGridView2.TabIndex = 11;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(341, 47);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 9;
            label3.Text = "Строки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(341, 12);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 8;
            label4.Text = "Столбцы";
            // 
            // btnCreateMatrix2
            // 
            btnCreateMatrix2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateMatrix2.Location = new Point(470, 9);
            btnCreateMatrix2.Name = "btnCreateMatrix2";
            btnCreateMatrix2.Size = new Size(97, 64);
            btnCreateMatrix2.TabIndex = 7;
            btnCreateMatrix2.Text = "Создать";
            btnCreateMatrix2.UseVisualStyleBackColor = true;
            btnCreateMatrix2.Click += btnCreateMatrix2_Click;
            // 
            // txtRow2
            // 
            txtRow2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRow2.Location = new Point(421, 44);
            txtRow2.Name = "txtRow2";
            txtRow2.Size = new Size(43, 26);
            txtRow2.TabIndex = 6;
            // 
            // txtСolumn2
            // 
            txtСolumn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtСolumn2.Location = new Point(421, 9);
            txtСolumn2.Name = "txtСolumn2";
            txtСolumn2.Size = new Size(43, 26);
            txtСolumn2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Строки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "Столбцы";
            // 
            // btnCreateMatrix1
            // 
            btnCreateMatrix1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateMatrix1.Location = new Point(144, 6);
            btnCreateMatrix1.Name = "btnCreateMatrix1";
            btnCreateMatrix1.Size = new Size(97, 64);
            btnCreateMatrix1.TabIndex = 2;
            btnCreateMatrix1.Text = "Создать";
            btnCreateMatrix1.UseVisualStyleBackColor = true;
            btnCreateMatrix1.Click += btnCreateMatrix1_Click;
            // 
            // txtRow1
            // 
            txtRow1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRow1.Location = new Point(95, 41);
            txtRow1.Name = "txtRow1";
            txtRow1.Size = new Size(43, 26);
            txtRow1.TabIndex = 1;
            // 
            // txtСolumn1
            // 
            txtСolumn1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtСolumn1.Location = new Point(95, 6);
            txtСolumn1.Name = "txtСolumn1";
            txtСolumn1.Size = new Size(43, 26);
            txtСolumn1.TabIndex = 0;
            // 
            // tabTransfers
            // 
            tabTransfers.Controls.Add(txtHelpTemperature);
            tabTransfers.Controls.Add(txtTemperature2);
            tabTransfers.Controls.Add(txtTemperature1);
            tabTransfers.Controls.Add(cbTemperature2);
            tabTransfers.Controls.Add(cbTemperature1);
            tabTransfers.Controls.Add(btnChangeTemperature);
            tabTransfers.Controls.Add(label5);
            tabTransfers.Controls.Add(btnChangeData);
            tabTransfers.Controls.Add(txtHelpData);
            tabTransfers.Controls.Add(txtData2);
            tabTransfers.Controls.Add(txtData1);
            tabTransfers.Controls.Add(cbData2);
            tabTransfers.Controls.Add(cbData1);
            tabTransfers.Controls.Add(lbData);
            tabTransfers.Location = new Point(4, 29);
            tabTransfers.Name = "tabTransfers";
            tabTransfers.Size = new Size(578, 492);
            tabTransfers.TabIndex = 2;
            tabTransfers.Text = "Переводы";
            tabTransfers.UseVisualStyleBackColor = true;
            // 
            // txtHelpTemperature
            // 
            txtHelpTemperature.BackColor = Color.MistyRose;
            txtHelpTemperature.Enabled = false;
            txtHelpTemperature.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHelpTemperature.Location = new Point(362, 184);
            txtHelpTemperature.Multiline = true;
            txtHelpTemperature.Name = "txtHelpTemperature";
            txtHelpTemperature.ReadOnly = true;
            txtHelpTemperature.Size = new Size(208, 76);
            txtHelpTemperature.TabIndex = 27;
            // 
            // txtTemperature2
            // 
            txtTemperature2.Location = new Point(169, 231);
            txtTemperature2.Name = "txtTemperature2";
            txtTemperature2.Size = new Size(187, 26);
            txtTemperature2.TabIndex = 26;
            txtTemperature2.TextChanged += txtTemperature2_TextChanged;
            // 
            // txtTemperature1
            // 
            txtTemperature1.Location = new Point(169, 184);
            txtTemperature1.Name = "txtTemperature1";
            txtTemperature1.Size = new Size(187, 26);
            txtTemperature1.TabIndex = 25;
            txtTemperature1.TextChanged += txtTemperature1_TextChanged;
            // 
            // cbTemperature2
            // 
            cbTemperature2.FormattingEnabled = true;
            cbTemperature2.Items.AddRange(new object[] { "Цельсий", "Фаренгейт", "Кельвин", "Ранкин", "Реомюр" });
            cbTemperature2.Location = new Point(64, 231);
            cbTemperature2.Name = "cbTemperature2";
            cbTemperature2.Size = new Size(99, 28);
            cbTemperature2.TabIndex = 24;
            cbTemperature2.SelectedIndexChanged += cbTemperature2_SelectedIndexChanged;
            // 
            // cbTemperature1
            // 
            cbTemperature1.FormattingEnabled = true;
            cbTemperature1.Items.AddRange(new object[] { "Цельсий", "Фаренгейт", "Кельвин", "Ранкин", "Реомюр" });
            cbTemperature1.Location = new Point(64, 184);
            cbTemperature1.Name = "cbTemperature1";
            cbTemperature1.Size = new Size(99, 28);
            cbTemperature1.TabIndex = 23;
            cbTemperature1.SelectedIndexChanged += cbTemperature1_SelectedIndexChanged;
            // 
            // btnChangeTemperature
            // 
            btnChangeTemperature.BackColor = Color.Transparent;
            btnChangeTemperature.BackgroundImageLayout = ImageLayout.None;
            btnChangeTemperature.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeTemperature.ForeColor = SystemColors.ControlText;
            btnChangeTemperature.Location = new Point(8, 184);
            btnChangeTemperature.Name = "btnChangeTemperature";
            btnChangeTemperature.Size = new Size(50, 76);
            btnChangeTemperature.TabIndex = 22;
            btnChangeTemperature.Text = "Rev";
            btnChangeTemperature.UseVisualStyleBackColor = false;
            btnChangeTemperature.Click += btnChangeTemperature_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 140);
            label5.Name = "label5";
            label5.Size = new Size(295, 20);
            label5.TabIndex = 21;
            label5.Text = "Перевод в другие шкалы температур";
            // 
            // btnChangeData
            // 
            btnChangeData.BackColor = Color.Transparent;
            btnChangeData.BackgroundImageLayout = ImageLayout.None;
            btnChangeData.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeData.ForeColor = SystemColors.ControlText;
            btnChangeData.Location = new Point(8, 44);
            btnChangeData.Name = "btnChangeData";
            btnChangeData.Size = new Size(50, 76);
            btnChangeData.TabIndex = 20;
            btnChangeData.Text = "Rev";
            btnChangeData.UseVisualStyleBackColor = false;
            btnChangeData.Click += btnChangeData_Click;
            // 
            // txtHelpData
            // 
            txtHelpData.BackColor = Color.MistyRose;
            txtHelpData.Enabled = false;
            txtHelpData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHelpData.Location = new Point(362, 44);
            txtHelpData.Multiline = true;
            txtHelpData.Name = "txtHelpData";
            txtHelpData.ReadOnly = true;
            txtHelpData.Size = new Size(208, 76);
            txtHelpData.TabIndex = 19;
            // 
            // txtData2
            // 
            txtData2.Location = new Point(169, 91);
            txtData2.Name = "txtData2";
            txtData2.Size = new Size(187, 26);
            txtData2.TabIndex = 8;
            txtData2.TextChanged += txtData2_TextChanged;
            // 
            // txtData1
            // 
            txtData1.Location = new Point(169, 44);
            txtData1.Name = "txtData1";
            txtData1.Size = new Size(187, 26);
            txtData1.TabIndex = 7;
            txtData1.TextChanged += txtData1_TextChanged;
            // 
            // cbData2
            // 
            cbData2.FormattingEnabled = true;
            cbData2.Items.AddRange(new object[] { "Бит", "Байт", "Килобайт", "Мегабайт", "Гигабайт", "Терабайт", "Петабайт" });
            cbData2.Location = new Point(64, 91);
            cbData2.Name = "cbData2";
            cbData2.Size = new Size(99, 28);
            cbData2.TabIndex = 6;
            cbData2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cbData1
            // 
            cbData1.FormattingEnabled = true;
            cbData1.Items.AddRange(new object[] { "Бит", "Байт", "Килобайт", "Мегабайт", "Гигабайт", "Терабайт", "Петабайт" });
            cbData1.Location = new Point(64, 44);
            cbData1.Name = "cbData1";
            cbData1.Size = new Size(99, 28);
            cbData1.TabIndex = 5;
            cbData1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbData.Location = new Point(8, 11);
            lbData.Name = "lbData";
            lbData.Size = new Size(239, 20);
            lbData.TabIndex = 4;
            lbData.Text = "Перевод данных информации";
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 525);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm1";
            Text = "The Best Calculator";
            tabControl1.ResumeLayout(false);
            tabcCalc.ResumeLayout(false);
            tabcCalc.PerformLayout();
            tabMatrix.ResumeLayout(false);
            tabMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabTransfers.ResumeLayout(false);
            tabTransfers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnDevide;
        private Button btnMultipli;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnAnswer;
        private Button btnComma;
        private Button btnClean;
        private Button btnDelete;
        private Button btnPercent;
        private Label lbAnswer;
        private Button btnLeftBracket;
        private Button btnRightBracket;
        private Button btnPow;
        private Button btnE;
        private Button btnPi;
        private Button btnSin;
        private Button btnCos;
        private Button btnFact;
        private Button btnAbs;
        private Button btnLn;
        private Button btnLog;
        private Button btnCsc;
        private Button btnSec;
        private Button btnCtg;
        private Button btnTg;
        private TextBox txtTextField;
        private Button btnExp;
        private TabControl tabControl1;
        private TabPage tabCalc;
        private TabPage tabMatrix;
        private Button btnHistory;
        private TabPage tabcCalc;
        private Label label3;
        private Label label4;
        private Button btnCreateMatrix2;
        private TextBox txtRow2;
        private TextBox txtСolumn2;
        private Label label2;
        private Label label1;
        private Button btnCreateMatrix1;
        private TextBox txtRow1;
        private TextBox txtСolumn1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button btnMatrixPlus;
        private Button btnMatrixDivide;
        private Button btnMatrixMultiply;
        private Button btnMatrixMinus;
        private DataGridView dataGridView3;
        private TextBox txtHelp;
        private TabPage tabTransfers;
        private Label lbData;
        private ComboBox cbData1;
        private ComboBox cbData2;
        private TextBox txtData2;
        private TextBox txtData1;
        private TextBox txtHelpData;
        private Button btnChangeData;
        private ComboBox cbTemperature2;
        private ComboBox cbTemperature1;
        private Button btnChangeTemperature;
        private Label label5;
        private TextBox txtHelpTemperature;
        private TextBox txtTemperature2;
        private TextBox txtTemperature1;
    }
}

