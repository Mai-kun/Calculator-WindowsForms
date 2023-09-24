using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
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
            btnFloor = new Button();
            btnCeil = new Button();
            btnCtg = new Button();
            btnTg = new Button();
            txtTextField = new TextBox();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn7.Location = new System.Drawing.Point(30, 259);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.RightToLeft = RightToLeft.No;
            btn7.Size = new System.Drawing.Size(85, 85);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn8.Location = new System.Drawing.Point(119, 259);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.RightToLeft = RightToLeft.No;
            btn8.Size = new System.Drawing.Size(85, 85);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn9.Location = new System.Drawing.Point(208, 259);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.RightToLeft = RightToLeft.No;
            btn9.Size = new System.Drawing.Size(85, 85);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn4.Location = new System.Drawing.Point(30, 347);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.RightToLeft = RightToLeft.No;
            btn4.Size = new System.Drawing.Size(85, 85);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn5.Location = new System.Drawing.Point(119, 347);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.RightToLeft = RightToLeft.No;
            btn5.Size = new System.Drawing.Size(85, 85);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn6.Location = new System.Drawing.Point(208, 347);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.RightToLeft = RightToLeft.No;
            btn6.Size = new System.Drawing.Size(85, 85);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn1.Location = new System.Drawing.Point(30, 434);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.RightToLeft = RightToLeft.No;
            btn1.Size = new System.Drawing.Size(85, 85);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn2.Location = new System.Drawing.Point(119, 434);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.RightToLeft = RightToLeft.No;
            btn2.Size = new System.Drawing.Size(85, 85);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn3.Location = new System.Drawing.Point(208, 434);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.RightToLeft = RightToLeft.No;
            btn3.Size = new System.Drawing.Size(85, 85);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn0.Location = new System.Drawing.Point(119, 522);
            btn0.Margin = new Padding(4, 3, 4, 3);
            btn0.Name = "btn0";
            btn0.RightToLeft = RightToLeft.No;
            btn0.Size = new System.Drawing.Size(85, 85);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDevide
            // 
            btnDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDevide.Location = new System.Drawing.Point(315, 171);
            btnDevide.Margin = new Padding(4, 3, 4, 3);
            btnDevide.Name = "btnDevide";
            btnDevide.RightToLeft = RightToLeft.No;
            btnDevide.Size = new System.Drawing.Size(85, 85);
            btnDevide.TabIndex = 11;
            btnDevide.Text = "/";
            btnDevide.UseVisualStyleBackColor = true;
            btnDevide.Click += btnDevide_Click;
            // 
            // btnMultipli
            // 
            btnMultipli.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMultipli.Location = new System.Drawing.Point(315, 259);
            btnMultipli.Margin = new Padding(4, 3, 4, 3);
            btnMultipli.Name = "btnMultipli";
            btnMultipli.RightToLeft = RightToLeft.No;
            btnMultipli.Size = new System.Drawing.Size(85, 85);
            btnMultipli.TabIndex = 12;
            btnMultipli.Text = "x";
            btnMultipli.UseVisualStyleBackColor = true;
            btnMultipli.Click += btnMultipli_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMinus.Location = new System.Drawing.Point(315, 347);
            btnMinus.Margin = new Padding(4, 3, 4, 3);
            btnMinus.Name = "btnMinus";
            btnMinus.RightToLeft = RightToLeft.No;
            btnMinus.Size = new System.Drawing.Size(85, 85);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPlus.Location = new System.Drawing.Point(315, 434);
            btnPlus.Margin = new Padding(4, 3, 4, 3);
            btnPlus.Name = "btnPlus";
            btnPlus.RightToLeft = RightToLeft.No;
            btnPlus.Size = new System.Drawing.Size(85, 85);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAnswer.Location = new System.Drawing.Point(315, 522);
            btnAnswer.Margin = new Padding(4, 3, 4, 3);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.RightToLeft = RightToLeft.No;
            btnAnswer.Size = new System.Drawing.Size(85, 85);
            btnAnswer.TabIndex = 15;
            btnAnswer.Text = "=";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // btnComma
            // 
            btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnComma.Location = new System.Drawing.Point(208, 522);
            btnComma.Margin = new Padding(4, 3, 4, 3);
            btnComma.Name = "btnComma";
            btnComma.RightToLeft = RightToLeft.No;
            btnComma.Size = new System.Drawing.Size(85, 85);
            btnComma.TabIndex = 16;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btnClean
            // 
            btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClean.Location = new System.Drawing.Point(30, 171);
            btnClean.Margin = new Padding(4, 3, 4, 3);
            btnClean.Name = "btnClean";
            btnClean.RightToLeft = RightToLeft.No;
            btnClean.Size = new System.Drawing.Size(85, 85);
            btnClean.TabIndex = 17;
            btnClean.Text = "C";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(119, 171);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new System.Drawing.Size(85, 85);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "<=";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPercent.Location = new System.Drawing.Point(208, 171);
            btnPercent.Margin = new Padding(4, 3, 4, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.RightToLeft = RightToLeft.No;
            btnPercent.Size = new System.Drawing.Size(85, 85);
            btnPercent.TabIndex = 19;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // lbAnswer
            // 
            lbAnswer.BackColor = System.Drawing.SystemColors.Window;
            lbAnswer.BorderStyle = BorderStyle.FixedSingle;
            lbAnswer.Enabled = false;
            lbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAnswer.Location = new System.Drawing.Point(30, 106);
            lbAnswer.Margin = new Padding(4, 0, 4, 0);
            lbAnswer.Name = "lbAnswer";
            lbAnswer.Size = new System.Drawing.Size(747, 55);
            lbAnswer.TabIndex = 21;
            lbAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLeftBracket
            // 
            btnLeftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLeftBracket.Location = new System.Drawing.Point(422, 171);
            btnLeftBracket.Margin = new Padding(4, 3, 4, 3);
            btnLeftBracket.Name = "btnLeftBracket";
            btnLeftBracket.RightToLeft = RightToLeft.No;
            btnLeftBracket.Size = new System.Drawing.Size(85, 85);
            btnLeftBracket.TabIndex = 22;
            btnLeftBracket.Text = "(";
            btnLeftBracket.UseVisualStyleBackColor = true;
            btnLeftBracket.Click += btnLeftBracket_Click;
            // 
            // btnRightBracket
            // 
            btnRightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRightBracket.Location = new System.Drawing.Point(511, 171);
            btnRightBracket.Margin = new Padding(4, 3, 4, 3);
            btnRightBracket.Name = "btnRightBracket";
            btnRightBracket.RightToLeft = RightToLeft.No;
            btnRightBracket.Size = new System.Drawing.Size(85, 85);
            btnRightBracket.TabIndex = 23;
            btnRightBracket.Text = ")";
            btnRightBracket.UseVisualStyleBackColor = true;
            btnRightBracket.Click += btnRightBracket_Click;
            // 
            // btnPow
            // 
            btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPow.Location = new System.Drawing.Point(604, 259);
            btnPow.Margin = new Padding(4, 3, 4, 3);
            btnPow.Name = "btnPow";
            btnPow.RightToLeft = RightToLeft.No;
            btnPow.Size = new System.Drawing.Size(85, 85);
            btnPow.TabIndex = 24;
            btnPow.Text = "x^y\r\n";
            btnPow.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnE.Location = new System.Drawing.Point(604, 171);
            btnE.Margin = new Padding(4, 3, 4, 3);
            btnE.Name = "btnE";
            btnE.RightToLeft = RightToLeft.No;
            btnE.Size = new System.Drawing.Size(85, 85);
            btnE.TabIndex = 25;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnPi
            // 
            btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPi.Location = new System.Drawing.Point(693, 171);
            btnPi.Margin = new Padding(4, 3, 4, 3);
            btnPi.Name = "btnPi";
            btnPi.RightToLeft = RightToLeft.No;
            btnPi.Size = new System.Drawing.Size(85, 85);
            btnPi.TabIndex = 26;
            btnPi.Text = "Pi";
            btnPi.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSin.Location = new System.Drawing.Point(422, 259);
            btnSin.Margin = new Padding(4, 3, 4, 3);
            btnSin.Name = "btnSin";
            btnSin.RightToLeft = RightToLeft.No;
            btnSin.Size = new System.Drawing.Size(85, 85);
            btnSin.TabIndex = 27;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = true;
            // 
            // btnCos
            // 
            btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCos.Location = new System.Drawing.Point(511, 259);
            btnCos.Margin = new Padding(4, 3, 4, 3);
            btnCos.Name = "btnCos";
            btnCos.RightToLeft = RightToLeft.No;
            btnCos.Size = new System.Drawing.Size(85, 85);
            btnCos.TabIndex = 28;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = true;
            // 
            // btnFact
            // 
            btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFact.Location = new System.Drawing.Point(693, 259);
            btnFact.Margin = new Padding(4, 3, 4, 3);
            btnFact.Name = "btnFact";
            btnFact.RightToLeft = RightToLeft.No;
            btnFact.Size = new System.Drawing.Size(85, 85);
            btnFact.TabIndex = 31;
            btnFact.Text = "n!";
            btnFact.UseVisualStyleBackColor = true;
            // 
            // btnAbs
            // 
            btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAbs.Location = new System.Drawing.Point(604, 434);
            btnAbs.Margin = new Padding(4, 3, 4, 3);
            btnAbs.Name = "btnAbs";
            btnAbs.RightToLeft = RightToLeft.No;
            btnAbs.Size = new System.Drawing.Size(85, 85);
            btnAbs.TabIndex = 40;
            btnAbs.Text = "|x|";
            btnAbs.UseVisualStyleBackColor = true;
            // 
            // btnLn
            // 
            btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLn.Location = new System.Drawing.Point(511, 434);
            btnLn.Margin = new Padding(4, 3, 4, 3);
            btnLn.Name = "btnLn";
            btnLn.RightToLeft = RightToLeft.No;
            btnLn.Size = new System.Drawing.Size(85, 85);
            btnLn.TabIndex = 38;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLog.Location = new System.Drawing.Point(422, 434);
            btnLog.Margin = new Padding(4, 3, 4, 3);
            btnLog.Name = "btnLog";
            btnLog.RightToLeft = RightToLeft.No;
            btnLog.Size = new System.Drawing.Size(85, 85);
            btnLog.TabIndex = 37;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // btnFloor
            // 
            btnFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFloor.Location = new System.Drawing.Point(693, 347);
            btnFloor.Margin = new Padding(4, 3, 4, 3);
            btnFloor.Name = "btnFloor";
            btnFloor.RightToLeft = RightToLeft.No;
            btnFloor.Size = new System.Drawing.Size(85, 85);
            btnFloor.TabIndex = 36;
            btnFloor.Text = "floor";
            btnFloor.UseVisualStyleBackColor = true;
            // 
            // btnCeil
            // 
            btnCeil.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCeil.Location = new System.Drawing.Point(604, 347);
            btnCeil.Margin = new Padding(4, 3, 4, 3);
            btnCeil.Name = "btnCeil";
            btnCeil.RightToLeft = RightToLeft.No;
            btnCeil.Size = new System.Drawing.Size(85, 85);
            btnCeil.TabIndex = 35;
            btnCeil.Text = "ceil";
            btnCeil.UseVisualStyleBackColor = true;
            btnCeil.Click += btnCeil_Click;
            // 
            // btnCtg
            // 
            btnCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCtg.Location = new System.Drawing.Point(511, 347);
            btnCtg.Margin = new Padding(4, 3, 4, 3);
            btnCtg.Name = "btnCtg";
            btnCtg.RightToLeft = RightToLeft.No;
            btnCtg.Size = new System.Drawing.Size(85, 85);
            btnCtg.TabIndex = 33;
            btnCtg.Text = "ctg";
            btnCtg.UseVisualStyleBackColor = true;
            // 
            // btnTg
            // 
            btnTg.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTg.Location = new System.Drawing.Point(422, 347);
            btnTg.Margin = new Padding(4, 3, 4, 3);
            btnTg.Name = "btnTg";
            btnTg.RightToLeft = RightToLeft.No;
            btnTg.Size = new System.Drawing.Size(85, 85);
            btnTg.TabIndex = 32;
            btnTg.Text = "tg";
            btnTg.UseVisualStyleBackColor = true;
            // 
            // txtTextField
            // 
            txtTextField.BackColor = System.Drawing.SystemColors.Window;
            txtTextField.BorderStyle = BorderStyle.FixedSingle;
            txtTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTextField.ForeColor = System.Drawing.Color.Black;
            txtTextField.Location = new System.Drawing.Point(30, 21);
            txtTextField.Multiline = true;
            txtTextField.Name = "txtTextField";
            txtTextField.ReadOnly = true;
            txtTextField.RightToLeft = RightToLeft.No;
            txtTextField.ScrollBars = ScrollBars.Vertical;
            txtTextField.Size = new System.Drawing.Size(764, 82);
            txtTextField.TabIndex = 42;
            txtTextField.TabStop = false;
            txtTextField.TextAlign = HorizontalAlignment.Right;
            txtTextField.TextChanged += txtTextField_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(812, 627);
            Controls.Add(txtTextField);
            Controls.Add(btnAbs);
            Controls.Add(btnLn);
            Controls.Add(btnLog);
            Controls.Add(btnFloor);
            Controls.Add(btnCeil);
            Controls.Add(btnCtg);
            Controls.Add(btnTg);
            Controls.Add(btnFact);
            Controls.Add(btnCos);
            Controls.Add(btnSin);
            Controls.Add(btnPi);
            Controls.Add(btnE);
            Controls.Add(btnPow);
            Controls.Add(btnRightBracket);
            Controls.Add(btnLeftBracket);
            Controls.Add(lbAnswer);
            Controls.Add(btnPercent);
            Controls.Add(btnDelete);
            Controls.Add(btnClean);
            Controls.Add(btnComma);
            Controls.Add(btnAnswer);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultipli);
            Controls.Add(btnDevide);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "The Best Calculator";
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnFloor;
        private Button btnCeil;
        private Button btnCtg;
        private Button btnTg;
        private TextBox txtTextField;
    }
}

