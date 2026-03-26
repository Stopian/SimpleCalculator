namespace WinFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCalculator = new Label();
            txtUserInput = new TextBox();
            txtResult = new TextBox();
            btnCalculatorCE = new Button();
            btnCalculatorC = new Button();
            btnCalculatorDel = new Button();
            btnCalculatorDivision = new Button();
            btnCalculatorNo7 = new Button();
            btnCalculatorNo8 = new Button();
            btnCalculatorNo9 = new Button();
            btnCalculatorMultiplied = new Button();
            btnCalculatorNo4 = new Button();
            btnCalculatorNo5 = new Button();
            btnCalculatorNo6 = new Button();
            btnCalculatorMinus = new Button();
            btnCalculatorNo1 = new Button();
            btnCalculatorNo2 = new Button();
            btnCalculatorNo3 = new Button();
            btnCalculatorPlus = new Button();
            btnCalculatorSignChange = new Button();
            btnCalculatorNo0 = new Button();
            btnCalculatorDecimal = new Button();
            btnCalculatorEqual = new Button();
            button1 = new Button();
            btnSquare = new Button();
            btnRoot = new Button();
            btnCalculatorPercentage = new Button();
            btnLParentheses = new Button();
            btnRParentheses = new Button();
            SuspendLayout();
            // 
            // lblCalculator
            // 
            lblCalculator.AutoSize = true;
            lblCalculator.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblCalculator.Location = new Point(89, 44);
            lblCalculator.Name = "lblCalculator";
            lblCalculator.Size = new Size(426, 65);
            lblCalculator.TabIndex = 0;
            lblCalculator.Text = "Simple Calculator";
            // 
            // txtUserInput
            // 
            txtUserInput.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtUserInput.Location = new Point(89, 139);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(429, 35);
            txtUserInput.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtResult.Location = new Point(89, 193);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(429, 35);
            txtResult.TabIndex = 2;
            // 
            // btnCalculatorCE
            // 
            btnCalculatorCE.BackColor = Color.White;
            btnCalculatorCE.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorCE.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculatorCE.Location = new Point(143, 266);
            btnCalculatorCE.Name = "btnCalculatorCE";
            btnCalculatorCE.Size = new Size(96, 50);
            btnCalculatorCE.TabIndex = 3;
            btnCalculatorCE.Text = "CE";
            btnCalculatorCE.UseVisualStyleBackColor = false;
            btnCalculatorCE.Click += btnCalculatorCE_Click;
            // 
            // btnCalculatorC
            // 
            btnCalculatorC.BackColor = Color.White;
            btnCalculatorC.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorC.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculatorC.Location = new Point(245, 266);
            btnCalculatorC.Name = "btnCalculatorC";
            btnCalculatorC.Size = new Size(96, 50);
            btnCalculatorC.TabIndex = 3;
            btnCalculatorC.Text = "C";
            btnCalculatorC.UseVisualStyleBackColor = false;
            btnCalculatorC.Click += btnCalculatorC_Click;
            // 
            // btnCalculatorDel
            // 
            btnCalculatorDel.BackColor = Color.White;
            btnCalculatorDel.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorDel.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculatorDel.Location = new Point(347, 266);
            btnCalculatorDel.Name = "btnCalculatorDel";
            btnCalculatorDel.Size = new Size(96, 50);
            btnCalculatorDel.TabIndex = 3;
            btnCalculatorDel.Text = "del";
            btnCalculatorDel.UseVisualStyleBackColor = false;
            btnCalculatorDel.Click += btnCalculatorDel_Click;
            // 
            // btnCalculatorDivision
            // 
            btnCalculatorDivision.BackColor = Color.White;
            btnCalculatorDivision.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorDivision.ForeColor = Color.Red;
            btnCalculatorDivision.Location = new Point(347, 322);
            btnCalculatorDivision.Name = "btnCalculatorDivision";
            btnCalculatorDivision.Size = new Size(96, 50);
            btnCalculatorDivision.TabIndex = 3;
            btnCalculatorDivision.Text = "÷";
            btnCalculatorDivision.UseVisualStyleBackColor = false;
            btnCalculatorDivision.Click += btnCalculatorDivision_Click;
            // 
            // btnCalculatorNo7
            // 
            btnCalculatorNo7.BackColor = Color.White;
            btnCalculatorNo7.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo7.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo7.Location = new Point(41, 390);
            btnCalculatorNo7.Name = "btnCalculatorNo7";
            btnCalculatorNo7.Size = new Size(96, 50);
            btnCalculatorNo7.TabIndex = 3;
            btnCalculatorNo7.Text = "7";
            btnCalculatorNo7.UseVisualStyleBackColor = false;
            btnCalculatorNo7.Click += NumberButton_Click;
            // 
            // btnCalculatorNo8
            // 
            btnCalculatorNo8.BackColor = Color.White;
            btnCalculatorNo8.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo8.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo8.Location = new Point(143, 390);
            btnCalculatorNo8.Name = "btnCalculatorNo8";
            btnCalculatorNo8.Size = new Size(96, 50);
            btnCalculatorNo8.TabIndex = 3;
            btnCalculatorNo8.Text = "8";
            btnCalculatorNo8.UseVisualStyleBackColor = false;
            btnCalculatorNo8.Click += NumberButton_Click;
            // 
            // btnCalculatorNo9
            // 
            btnCalculatorNo9.BackColor = Color.White;
            btnCalculatorNo9.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo9.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo9.Location = new Point(245, 390);
            btnCalculatorNo9.Name = "btnCalculatorNo9";
            btnCalculatorNo9.Size = new Size(96, 50);
            btnCalculatorNo9.TabIndex = 3;
            btnCalculatorNo9.Text = "9";
            btnCalculatorNo9.UseVisualStyleBackColor = false;
            btnCalculatorNo9.Click += NumberButton_Click;
            // 
            // btnCalculatorMultiplied
            // 
            btnCalculatorMultiplied.BackColor = Color.White;
            btnCalculatorMultiplied.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorMultiplied.ForeColor = Color.Red;
            btnCalculatorMultiplied.Location = new Point(347, 390);
            btnCalculatorMultiplied.Name = "btnCalculatorMultiplied";
            btnCalculatorMultiplied.Size = new Size(96, 50);
            btnCalculatorMultiplied.TabIndex = 3;
            btnCalculatorMultiplied.Text = "X";
            btnCalculatorMultiplied.UseVisualStyleBackColor = false;
            btnCalculatorMultiplied.Click += btnCalculatorMultiplied_Click;
            // 
            // btnCalculatorNo4
            // 
            btnCalculatorNo4.BackColor = Color.White;
            btnCalculatorNo4.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo4.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo4.Location = new Point(41, 458);
            btnCalculatorNo4.Name = "btnCalculatorNo4";
            btnCalculatorNo4.Size = new Size(96, 50);
            btnCalculatorNo4.TabIndex = 3;
            btnCalculatorNo4.Text = "4";
            btnCalculatorNo4.UseVisualStyleBackColor = false;
            btnCalculatorNo4.Click += NumberButton_Click;
            // 
            // btnCalculatorNo5
            // 
            btnCalculatorNo5.BackColor = Color.White;
            btnCalculatorNo5.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo5.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo5.Location = new Point(143, 458);
            btnCalculatorNo5.Name = "btnCalculatorNo5";
            btnCalculatorNo5.Size = new Size(96, 50);
            btnCalculatorNo5.TabIndex = 3;
            btnCalculatorNo5.Text = "5";
            btnCalculatorNo5.UseVisualStyleBackColor = false;
            btnCalculatorNo5.Click += NumberButton_Click;
            // 
            // btnCalculatorNo6
            // 
            btnCalculatorNo6.BackColor = Color.White;
            btnCalculatorNo6.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo6.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo6.Location = new Point(245, 458);
            btnCalculatorNo6.Name = "btnCalculatorNo6";
            btnCalculatorNo6.Size = new Size(96, 50);
            btnCalculatorNo6.TabIndex = 3;
            btnCalculatorNo6.Text = "6";
            btnCalculatorNo6.UseVisualStyleBackColor = false;
            btnCalculatorNo6.Click += NumberButton_Click;
            // 
            // btnCalculatorMinus
            // 
            btnCalculatorMinus.BackColor = Color.White;
            btnCalculatorMinus.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorMinus.ForeColor = Color.Red;
            btnCalculatorMinus.Location = new Point(347, 458);
            btnCalculatorMinus.Name = "btnCalculatorMinus";
            btnCalculatorMinus.Size = new Size(96, 50);
            btnCalculatorMinus.TabIndex = 3;
            btnCalculatorMinus.Text = "-";
            btnCalculatorMinus.UseVisualStyleBackColor = false;
            btnCalculatorMinus.Click += btnCalculatorMinus_Click;
            // 
            // btnCalculatorNo1
            // 
            btnCalculatorNo1.BackColor = Color.White;
            btnCalculatorNo1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo1.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo1.Location = new Point(41, 526);
            btnCalculatorNo1.Name = "btnCalculatorNo1";
            btnCalculatorNo1.Size = new Size(96, 50);
            btnCalculatorNo1.TabIndex = 3;
            btnCalculatorNo1.Text = "1";
            btnCalculatorNo1.UseVisualStyleBackColor = false;
            btnCalculatorNo1.Click += NumberButton_Click;
            // 
            // btnCalculatorNo2
            // 
            btnCalculatorNo2.BackColor = Color.White;
            btnCalculatorNo2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo2.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo2.Location = new Point(143, 526);
            btnCalculatorNo2.Name = "btnCalculatorNo2";
            btnCalculatorNo2.Size = new Size(96, 50);
            btnCalculatorNo2.TabIndex = 3;
            btnCalculatorNo2.Text = "2";
            btnCalculatorNo2.UseVisualStyleBackColor = false;
            btnCalculatorNo2.Click += NumberButton_Click;
            // 
            // btnCalculatorNo3
            // 
            btnCalculatorNo3.BackColor = Color.White;
            btnCalculatorNo3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo3.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo3.Location = new Point(245, 526);
            btnCalculatorNo3.Name = "btnCalculatorNo3";
            btnCalculatorNo3.Size = new Size(96, 50);
            btnCalculatorNo3.TabIndex = 3;
            btnCalculatorNo3.Text = "3";
            btnCalculatorNo3.UseVisualStyleBackColor = false;
            btnCalculatorNo3.Click += NumberButton_Click;
            // 
            // btnCalculatorPlus
            // 
            btnCalculatorPlus.BackColor = Color.White;
            btnCalculatorPlus.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorPlus.ForeColor = Color.Red;
            btnCalculatorPlus.Location = new Point(347, 526);
            btnCalculatorPlus.Name = "btnCalculatorPlus";
            btnCalculatorPlus.Size = new Size(96, 50);
            btnCalculatorPlus.TabIndex = 3;
            btnCalculatorPlus.Text = "+";
            btnCalculatorPlus.UseVisualStyleBackColor = false;
            btnCalculatorPlus.Click += btnCalculatorPlus_Click;
            // 
            // btnCalculatorSignChange
            // 
            btnCalculatorSignChange.BackColor = Color.White;
            btnCalculatorSignChange.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorSignChange.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculatorSignChange.Location = new Point(41, 594);
            btnCalculatorSignChange.Name = "btnCalculatorSignChange";
            btnCalculatorSignChange.Size = new Size(96, 50);
            btnCalculatorSignChange.TabIndex = 3;
            btnCalculatorSignChange.Text = "+/-";
            btnCalculatorSignChange.UseVisualStyleBackColor = false;
            btnCalculatorSignChange.Click += btnCalculatorSignChange_Click;
            // 
            // btnCalculatorNo0
            // 
            btnCalculatorNo0.BackColor = Color.White;
            btnCalculatorNo0.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorNo0.ForeColor = SystemColors.ActiveCaption;
            btnCalculatorNo0.Location = new Point(143, 594);
            btnCalculatorNo0.Name = "btnCalculatorNo0";
            btnCalculatorNo0.Size = new Size(96, 50);
            btnCalculatorNo0.TabIndex = 3;
            btnCalculatorNo0.Text = "0";
            btnCalculatorNo0.UseVisualStyleBackColor = false;
            btnCalculatorNo0.Click += NumberButton_Click;
            // 
            // btnCalculatorDecimal
            // 
            btnCalculatorDecimal.BackColor = Color.White;
            btnCalculatorDecimal.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorDecimal.Location = new Point(245, 594);
            btnCalculatorDecimal.Name = "btnCalculatorDecimal";
            btnCalculatorDecimal.Size = new Size(96, 50);
            btnCalculatorDecimal.TabIndex = 3;
            btnCalculatorDecimal.Text = ".";
            btnCalculatorDecimal.UseVisualStyleBackColor = false;
            btnCalculatorDecimal.Click += btnCalculatorDecimal_Click;
            // 
            // btnCalculatorEqual
            // 
            btnCalculatorEqual.BackColor = Color.White;
            btnCalculatorEqual.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorEqual.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculatorEqual.Location = new Point(347, 594);
            btnCalculatorEqual.Name = "btnCalculatorEqual";
            btnCalculatorEqual.Size = new Size(96, 50);
            btnCalculatorEqual.TabIndex = 3;
            btnCalculatorEqual.Text = "=";
            btnCalculatorEqual.UseVisualStyleBackColor = false;
            btnCalculatorEqual.Click += btnCalculatorEqual_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(41, 322);
            button1.Name = "button1";
            button1.Size = new Size(96, 50);
            button1.TabIndex = 4;
            button1.Text = "1/x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.White;
            btnSquare.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSquare.ForeColor = SystemColors.ActiveCaptionText;
            btnSquare.Location = new Point(143, 322);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(96, 50);
            btnSquare.TabIndex = 5;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.White;
            btnRoot.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRoot.ForeColor = SystemColors.ActiveCaptionText;
            btnRoot.Location = new Point(245, 322);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(96, 50);
            btnRoot.TabIndex = 6;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnCalculatorPercentage
            // 
            btnCalculatorPercentage.BackColor = Color.White;
            btnCalculatorPercentage.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCalculatorPercentage.ForeColor = SystemColors.ActiveCaptionText;
            btnCalculatorPercentage.Location = new Point(41, 266);
            btnCalculatorPercentage.Name = "btnCalculatorPercentage";
            btnCalculatorPercentage.Size = new Size(96, 50);
            btnCalculatorPercentage.TabIndex = 7;
            btnCalculatorPercentage.Text = "%";
            btnCalculatorPercentage.UseVisualStyleBackColor = false;
            btnCalculatorPercentage.Click += btnCalculatorPercentage_Click;
            // 
            // btnLParentheses
            // 
            btnLParentheses.BackColor = Color.White;
            btnLParentheses.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLParentheses.ForeColor = SystemColors.ActiveCaptionText;
            btnLParentheses.Location = new Point(473, 289);
            btnLParentheses.Name = "btnLParentheses";
            btnLParentheses.Size = new Size(96, 50);
            btnLParentheses.TabIndex = 8;
            btnLParentheses.Text = "(";
            btnLParentheses.UseVisualStyleBackColor = false;
            btnLParentheses.Click += btnLParentheses_Click;
            // 
            // btnRParentheses
            // 
            btnRParentheses.BackColor = Color.White;
            btnRParentheses.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRParentheses.ForeColor = SystemColors.ActiveCaptionText;
            btnRParentheses.Location = new Point(473, 362);
            btnRParentheses.Name = "btnRParentheses";
            btnRParentheses.Size = new Size(96, 50);
            btnRParentheses.TabIndex = 9;
            btnRParentheses.Text = ")";
            btnRParentheses.UseVisualStyleBackColor = false;
            btnRParentheses.Click += btnRParentheses_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 680);
            Controls.Add(btnRParentheses);
            Controls.Add(btnLParentheses);
            Controls.Add(btnCalculatorPercentage);
            Controls.Add(btnRoot);
            Controls.Add(btnSquare);
            Controls.Add(button1);
            Controls.Add(btnCalculatorEqual);
            Controls.Add(btnCalculatorDecimal);
            Controls.Add(btnCalculatorPlus);
            Controls.Add(btnCalculatorNo3);
            Controls.Add(btnCalculatorMinus);
            Controls.Add(btnCalculatorNo6);
            Controls.Add(btnCalculatorNo0);
            Controls.Add(btnCalculatorMultiplied);
            Controls.Add(btnCalculatorNo2);
            Controls.Add(btnCalculatorNo9);
            Controls.Add(btnCalculatorNo5);
            Controls.Add(btnCalculatorSignChange);
            Controls.Add(btnCalculatorDivision);
            Controls.Add(btnCalculatorNo1);
            Controls.Add(btnCalculatorNo8);
            Controls.Add(btnCalculatorNo4);
            Controls.Add(btnCalculatorDel);
            Controls.Add(btnCalculatorNo7);
            Controls.Add(btnCalculatorC);
            Controls.Add(btnCalculatorCE);
            Controls.Add(txtResult);
            Controls.Add(txtUserInput);
            Controls.Add(lblCalculator);
            Name = "Calculator";
            Text = "Calculator v1.0";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalculator;
        private TextBox txtUserInput;
        private TextBox txtResult;
        private Button btnCalculatorCE;
        private Button btnCalculatorC;
        private Button btnCalculatorDel;
        private Button btnCalculatorDivision;
        private Button btnCalculatorNo7;
        private Button btnCalculatorNo8;
        private Button btnCalculatorNo9;
        private Button btnCalculatorMultiplied;
        private Button btnCalculatorNo4;
        private Button btnCalculatorNo5;
        private Button btnCalculatorNo6;
        private Button btnCalculatorMinus;
        private Button btnCalculatorNo1;
        private Button btnCalculatorNo2;
        private Button btnCalculatorNo3;
        private Button btnCalculatorPlus;
        private Button btnCalculatorSignChange;
        private Button btnCalculatorNo0;
        private Button btnCalculatorDecimal;
        private Button btnCalculatorEqual;
        private Button button1;
        private Button btnSquare;
        private Button btnRoot;
        private Button btnCalculatorPercentage;
        private Button btnLParentheses;
        private Button btnRParentheses;
    }
}
