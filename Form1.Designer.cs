namespace CalculadoraWinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonDot = new Button();
            button12 = new Button();
            buttonSum = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivision = new Button();
            button17 = new Button();
            ResultField = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 281);
            button1.Name = "button1";
            button1.Size = new Size(71, 58);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += handleAddNumber;
            // 
            // button2
            // 
            button2.Location = new Point(310, 281);
            button2.Name = "button2";
            button2.Size = new Size(71, 58);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += handleAddNumber;
            // 
            // button3
            // 
            button3.Location = new Point(387, 281);
            button3.Name = "button3";
            button3.Size = new Size(71, 58);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += handleAddNumber;
            // 
            // button4
            // 
            button4.Location = new Point(233, 217);
            button4.Name = "button4";
            button4.Size = new Size(71, 58);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += handleAddNumber;
            // 
            // button5
            // 
            button5.Location = new Point(310, 217);
            button5.Name = "button5";
            button5.Size = new Size(71, 58);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += handleAddNumber;
            // 
            // button6
            // 
            button6.Location = new Point(387, 217);
            button6.Name = "button6";
            button6.Size = new Size(71, 58);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += handleAddNumber;
            // 
            // button7
            // 
            button7.Location = new Point(233, 153);
            button7.Name = "button7";
            button7.Size = new Size(71, 58);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += handleAddNumber;
            // 
            // button8
            // 
            button8.Location = new Point(310, 153);
            button8.Name = "button8";
            button8.Size = new Size(71, 58);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += handleAddNumber;
            // 
            // button9
            // 
            button9.Location = new Point(387, 153);
            button9.Name = "button9";
            button9.Size = new Size(71, 58);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += handleAddNumber;
            // 
            // button10
            // 
            button10.Location = new Point(233, 345);
            button10.Name = "button10";
            button10.Size = new Size(71, 58);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += handleAddNumber;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(310, 345);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(71, 58);
            buttonDot.TabIndex = 10;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += handleAddNumber;
            // 
            // button12
            // 
            button12.Location = new Point(387, 345);
            button12.Name = "button12";
            button12.Size = new Size(71, 58);
            button12.TabIndex = 11;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += handleCalculateNumbers;
            // 
            // buttonSum
            // 
            buttonSum.Location = new Point(464, 281);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(71, 122);
            buttonSum.TabIndex = 12;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += handleAddOperation;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(464, 217);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(71, 58);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += handleAddOperation;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(464, 153);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(71, 58);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += handleAddOperation;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(464, 89);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(71, 58);
            buttonDivision.TabIndex = 15;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += handleAddOperation;
            // 
            // button17
            // 
            button17.Location = new Point(233, 89);
            button17.Name = "button17";
            button17.Size = new Size(225, 58);
            button17.TabIndex = 16;
            button17.Text = "Limpar";
            button17.UseVisualStyleBackColor = true;
            button17.Click += handleCleanCalculator;
            // 
            // ResultField
            // 
            ResultField.Location = new Point(233, 41);
            ResultField.Name = "ResultField";
            ResultField.ReadOnly = true;
            ResultField.Size = new Size(302, 27);
            ResultField.TabIndex = 17;
            ResultField.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultField);
            Controls.Add(button17);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSum);
            Controls.Add(button12);
            Controls.Add(buttonDot);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonDot;
        private Button button12;
        private Button buttonSum;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivision;
        private Button button17;
        private TextBox ResultField;
    }
}