namespace BasicCaculator
{
    partial class Form1
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
            tableLayoutButton = new TableLayoutPanel();
            buttonDot = new Button();
            buttonDoubleZero = new Button();
            buttonMPlus = new Button();
            buttonMMinus = new Button();
            buttonMRC = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonZero = new Button();
            buttonC = new Button();
            buttonAC = new Button();
            buttonTimes = new Button();
            buttonDevide = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonEqual = new Button();
            numberDisplay = new TextBox();
            tableLayoutButton.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutButton
            // 
            tableLayoutButton.ColumnCount = 5;
            tableLayoutButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutButton.Controls.Add(buttonDot, 0, 4);
            tableLayoutButton.Controls.Add(buttonDoubleZero, 0, 4);
            tableLayoutButton.Controls.Add(buttonMPlus, 0, 0);
            tableLayoutButton.Controls.Add(buttonMMinus, 1, 0);
            tableLayoutButton.Controls.Add(buttonMRC, 2, 0);
            tableLayoutButton.Controls.Add(buttonSeven, 0, 1);
            tableLayoutButton.Controls.Add(buttonEight, 1, 1);
            tableLayoutButton.Controls.Add(buttonNine, 2, 1);
            tableLayoutButton.Controls.Add(buttonFour, 0, 2);
            tableLayoutButton.Controls.Add(buttonFive, 1, 2);
            tableLayoutButton.Controls.Add(buttonSix, 2, 2);
            tableLayoutButton.Controls.Add(buttonOne, 0, 3);
            tableLayoutButton.Controls.Add(buttonTwo, 1, 3);
            tableLayoutButton.Controls.Add(buttonThree, 2, 3);
            tableLayoutButton.Controls.Add(buttonZero, 0, 4);
            tableLayoutButton.Controls.Add(buttonC, 3, 1);
            tableLayoutButton.Controls.Add(buttonAC, 4, 1);
            tableLayoutButton.Controls.Add(buttonTimes, 3, 2);
            tableLayoutButton.Controls.Add(buttonDevide, 4, 2);
            tableLayoutButton.Controls.Add(buttonPlus, 3, 3);
            tableLayoutButton.Controls.Add(buttonMinus, 4, 3);
            tableLayoutButton.Controls.Add(buttonEqual, 4, 4);
            tableLayoutButton.Location = new Point(15, 80);
            tableLayoutButton.Name = "tableLayoutButton";
            tableLayoutButton.RowCount = 5;
            tableLayoutButton.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButton.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButton.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButton.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButton.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutButton.Size = new Size(370, 358);
            tableLayoutButton.TabIndex = 1;
            // 
            // buttonDot
            // 
            buttonDot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDot.BackColor = Color.Black;
            buttonDot.FlatStyle = FlatStyle.Flat;
            buttonDot.ForeColor = Color.White;
            buttonDot.Location = new Point(84, 294);
            buttonDot.Margin = new Padding(10);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(54, 54);
            buttonDot.TabIndex = 14;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += NumberButton_Click;
            // 
            // buttonDoubleZero
            // 
            buttonDoubleZero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDoubleZero.BackColor = Color.Black;
            buttonDoubleZero.FlatStyle = FlatStyle.Flat;
            buttonDoubleZero.ForeColor = Color.White;
            buttonDoubleZero.Location = new Point(10, 294);
            buttonDoubleZero.Margin = new Padding(10);
            buttonDoubleZero.Name = "buttonDoubleZero";
            buttonDoubleZero.Size = new Size(54, 54);
            buttonDoubleZero.TabIndex = 13;
            buttonDoubleZero.Text = "00";
            buttonDoubleZero.UseVisualStyleBackColor = false;
            buttonDoubleZero.Click += NumberButton_Click;
            // 
            // buttonMPlus
            // 
            buttonMPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMPlus.BackColor = Color.Black;
            buttonMPlus.FlatStyle = FlatStyle.Flat;
            buttonMPlus.ForeColor = Color.White;
            buttonMPlus.Location = new Point(10, 10);
            buttonMPlus.Margin = new Padding(10);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.Size = new Size(54, 51);
            buttonMPlus.TabIndex = 0;
            buttonMPlus.Text = "M+";
            buttonMPlus.UseVisualStyleBackColor = false;
            buttonMPlus.Click += ButtonMPlus_Click;
            // 
            // buttonMMinus
            // 
            buttonMMinus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMMinus.BackColor = Color.Black;
            buttonMMinus.FlatStyle = FlatStyle.Flat;
            buttonMMinus.ForeColor = Color.White;
            buttonMMinus.Location = new Point(84, 10);
            buttonMMinus.Margin = new Padding(10);
            buttonMMinus.Name = "buttonMMinus";
            buttonMMinus.Size = new Size(54, 51);
            buttonMMinus.TabIndex = 1;
            buttonMMinus.Text = "M-";
            buttonMMinus.UseVisualStyleBackColor = false;
            buttonMMinus.Click += ButtonMMinus_Click;
            // 
            // buttonMRC
            // 
            buttonMRC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMRC.BackColor = Color.Black;
            buttonMRC.FlatStyle = FlatStyle.Flat;
            buttonMRC.ForeColor = Color.White;
            buttonMRC.Location = new Point(158, 10);
            buttonMRC.Margin = new Padding(10);
            buttonMRC.Name = "buttonMRC";
            buttonMRC.Size = new Size(54, 51);
            buttonMRC.TabIndex = 2;
            buttonMRC.Text = "MRC";
            buttonMRC.UseVisualStyleBackColor = false;
            buttonMRC.Click += ButtonMRC_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSeven.BackColor = Color.Black;
            buttonSeven.FlatStyle = FlatStyle.Flat;
            buttonSeven.ForeColor = Color.White;
            buttonSeven.Location = new Point(10, 81);
            buttonSeven.Margin = new Padding(10);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(54, 51);
            buttonSeven.TabIndex = 3;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += NumberButton_Click;
            // 
            // buttonEight
            // 
            buttonEight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEight.BackColor = Color.Black;
            buttonEight.FlatStyle = FlatStyle.Flat;
            buttonEight.ForeColor = Color.White;
            buttonEight.Location = new Point(84, 81);
            buttonEight.Margin = new Padding(10);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(54, 51);
            buttonEight.TabIndex = 4;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += NumberButton_Click;
            // 
            // buttonNine
            // 
            buttonNine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonNine.BackColor = Color.Black;
            buttonNine.FlatStyle = FlatStyle.Flat;
            buttonNine.ForeColor = Color.White;
            buttonNine.Location = new Point(158, 81);
            buttonNine.Margin = new Padding(10);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(54, 51);
            buttonNine.TabIndex = 5;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += NumberButton_Click;
            // 
            // buttonFour
            // 
            buttonFour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonFour.BackColor = Color.Black;
            buttonFour.FlatStyle = FlatStyle.Flat;
            buttonFour.ForeColor = Color.White;
            buttonFour.Location = new Point(10, 152);
            buttonFour.Margin = new Padding(10);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(54, 51);
            buttonFour.TabIndex = 6;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += NumberButton_Click;
            // 
            // buttonFive
            // 
            buttonFive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonFive.BackColor = Color.Black;
            buttonFive.FlatStyle = FlatStyle.Flat;
            buttonFive.ForeColor = Color.White;
            buttonFive.Location = new Point(84, 152);
            buttonFive.Margin = new Padding(10);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(54, 51);
            buttonFive.TabIndex = 7;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += NumberButton_Click;
            // 
            // buttonSix
            // 
            buttonSix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSix.BackColor = Color.Black;
            buttonSix.FlatStyle = FlatStyle.Flat;
            buttonSix.ForeColor = Color.White;
            buttonSix.Location = new Point(158, 152);
            buttonSix.Margin = new Padding(10);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(54, 51);
            buttonSix.TabIndex = 8;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += NumberButton_Click;
            // 
            // buttonOne
            // 
            buttonOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOne.BackColor = Color.Black;
            buttonOne.FlatStyle = FlatStyle.Flat;
            buttonOne.ForeColor = Color.White;
            buttonOne.Location = new Point(10, 223);
            buttonOne.Margin = new Padding(10);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(54, 51);
            buttonOne.TabIndex = 9;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += NumberButton_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonTwo.BackColor = Color.Black;
            buttonTwo.FlatStyle = FlatStyle.Flat;
            buttonTwo.ForeColor = Color.White;
            buttonTwo.Location = new Point(84, 223);
            buttonTwo.Margin = new Padding(10);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(54, 51);
            buttonTwo.TabIndex = 10;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += NumberButton_Click;
            // 
            // buttonThree
            // 
            buttonThree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonThree.BackColor = Color.Black;
            buttonThree.FlatStyle = FlatStyle.Flat;
            buttonThree.ForeColor = Color.White;
            buttonThree.Location = new Point(158, 223);
            buttonThree.Margin = new Padding(10);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(54, 51);
            buttonThree.TabIndex = 11;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += NumberButton_Click;
            // 
            // buttonZero
            // 
            buttonZero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonZero.BackColor = Color.Black;
            buttonZero.FlatStyle = FlatStyle.Flat;
            buttonZero.ForeColor = Color.White;
            buttonZero.Location = new Point(158, 294);
            buttonZero.Margin = new Padding(10);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(54, 54);
            buttonZero.TabIndex = 12;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += NumberButton_Click;
            // 
            // buttonC
            // 
            buttonC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonC.BackColor = Color.Black;
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.ForeColor = Color.White;
            buttonC.Location = new Point(232, 81);
            buttonC.Margin = new Padding(10);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(54, 51);
            buttonC.TabIndex = 15;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += ButtonC_Click;
            // 
            // buttonAC
            // 
            buttonAC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAC.BackColor = Color.Black;
            buttonAC.FlatStyle = FlatStyle.Flat;
            buttonAC.ForeColor = Color.White;
            buttonAC.Location = new Point(306, 81);
            buttonAC.Margin = new Padding(10);
            buttonAC.Name = "buttonAC";
            buttonAC.Size = new Size(54, 51);
            buttonAC.TabIndex = 16;
            buttonAC.Text = "AC";
            buttonAC.UseVisualStyleBackColor = false;
            buttonAC.Click += ButtonAC_Click;
            // 
            // buttonTimes
            // 
            buttonTimes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonTimes.BackColor = Color.Black;
            buttonTimes.FlatStyle = FlatStyle.Flat;
            buttonTimes.ForeColor = Color.White;
            buttonTimes.Location = new Point(232, 152);
            buttonTimes.Margin = new Padding(10);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(54, 51);
            buttonTimes.TabIndex = 17;
            buttonTimes.Text = "*";
            buttonTimes.UseVisualStyleBackColor = false;
            buttonTimes.Click += OperationButton_Click;
            // 
            // buttonDevide
            // 
            buttonDevide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDevide.BackColor = Color.Black;
            buttonDevide.FlatStyle = FlatStyle.Flat;
            buttonDevide.ForeColor = Color.White;
            buttonDevide.Location = new Point(306, 152);
            buttonDevide.Margin = new Padding(10);
            buttonDevide.Name = "buttonDevide";
            buttonDevide.Size = new Size(54, 51);
            buttonDevide.TabIndex = 18;
            buttonDevide.Text = "÷";
            buttonDevide.UseVisualStyleBackColor = false;
            buttonDevide.Click += OperationButton_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPlus.BackColor = Color.Black;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.ForeColor = Color.White;
            buttonPlus.Location = new Point(232, 223);
            buttonPlus.Margin = new Padding(10);
            buttonPlus.Name = "buttonPlus";
            tableLayoutButton.SetRowSpan(buttonPlus, 2);
            buttonPlus.Size = new Size(54, 125);
            buttonPlus.TabIndex = 19;
            buttonPlus.Tag = "";
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += OperationButton_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMinus.BackColor = Color.Black;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(306, 223);
            buttonMinus.Margin = new Padding(10);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(54, 51);
            buttonMinus.TabIndex = 20;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += OperationButton_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEqual.BackColor = Color.Black;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.ForeColor = Color.White;
            buttonEqual.Location = new Point(306, 294);
            buttonEqual.Margin = new Padding(10);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(54, 54);
            buttonEqual.TabIndex = 21;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += ButtonEqual_Click;
            // 
            // numberDisplay
            // 
            numberDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numberDisplay.BackColor = Color.Black;
            numberDisplay.BorderStyle = BorderStyle.FixedSingle;
            numberDisplay.Enabled = false;
            numberDisplay.Font = new Font("Segoe UI", 12F);
            numberDisplay.ForeColor = Color.White;
            numberDisplay.Location = new Point(15, 44);
            numberDisplay.Margin = new Padding(4);
            numberDisplay.MaxLength = 20;
            numberDisplay.Name = "numberDisplay";
            numberDisplay.Size = new Size(370, 29);
            numberDisplay.TabIndex = 0;
            numberDisplay.Text = "0";
            numberDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(398, 450);
            Controls.Add(tableLayoutButton);
            Controls.Add(numberDisplay);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            tableLayoutButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberDisplay;
        private TableLayoutPanel tableLayoutButton;
        private Button buttonMPlus;
        private Button buttonMMinus;
        private Button buttonMRC;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonDot;
        private Button buttonDoubleZero;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonZero;
        private Button buttonC;
        private Button buttonAC;
        private Button buttonTimes;
        private Button buttonDevide;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonEqual;
    }
}
