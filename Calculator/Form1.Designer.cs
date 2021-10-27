
namespace Calculator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnMemoryRead = new System.Windows.Forms.Button();
            this.btnMemoryPlus = new System.Windows.Forms.Button();
            this.btnMemoryMinus = new System.Windows.Forms.Button();
            this.btnMemorySave = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(12, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(26, 31);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "0";
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(98, 350);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(80, 40);
            this.btnZero.TabIndex = 3;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComma.Location = new System.Drawing.Point(184, 350);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(80, 40);
            this.btnComma.TabIndex = 4;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.PutComma);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(270, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 40);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(270, 304);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(110, 40);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BinaryOperationPressed);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThree.Location = new System.Drawing.Point(184, 304);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 40);
            this.btnThree.TabIndex = 8;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.Location = new System.Drawing.Point(98, 304);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 40);
            this.btnTwo.TabIndex = 7;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOne.Location = new System.Drawing.Point(12, 304);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 40);
            this.btnOne.TabIndex = 6;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(270, 258);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(110, 40);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BinaryOperationPressed);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSix.Location = new System.Drawing.Point(184, 258);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 40);
            this.btnSix.TabIndex = 12;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFive.Location = new System.Drawing.Point(98, 258);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 40);
            this.btnFive.TabIndex = 11;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFour.Location = new System.Drawing.Point(12, 258);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 40);
            this.btnFour.TabIndex = 10;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(270, 212);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(110, 40);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BinaryOperationPressed);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNine.Location = new System.Drawing.Point(184, 212);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 40);
            this.btnNine.TabIndex = 16;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEight.Location = new System.Drawing.Point(98, 212);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 40);
            this.btnEight.TabIndex = 15;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeven.Location = new System.Drawing.Point(12, 212);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 40);
            this.btnSeven.TabIndex = 14;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.NumberPressed);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(270, 166);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(110, 40);
            this.btnDivide.TabIndex = 21;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BinaryOperationPressed);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquareRoot.Location = new System.Drawing.Point(184, 166);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(80, 40);
            this.btnSquareRoot.TabIndex = 20;
            this.btnSquareRoot.Text = "√x";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.UnaryOperationPressed);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquare.Location = new System.Drawing.Point(98, 166);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(80, 40);
            this.btnSquare.TabIndex = 19;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.UnaryOperationPressed);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReverse.Location = new System.Drawing.Point(12, 166);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(80, 40);
            this.btnReverse.TabIndex = 18;
            this.btnReverse.Text = "1/x";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.UnaryOperationPressed);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Enabled = false;
            this.btnMemoryClear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryClear.Location = new System.Drawing.Point(12, 74);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(60, 40);
            this.btnMemoryClear.TabIndex = 22;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.ClearMemory);
            // 
            // btnMemoryRead
            // 
            this.btnMemoryRead.Enabled = false;
            this.btnMemoryRead.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryRead.Location = new System.Drawing.Point(78, 74);
            this.btnMemoryRead.Name = "btnMemoryRead";
            this.btnMemoryRead.Size = new System.Drawing.Size(60, 40);
            this.btnMemoryRead.TabIndex = 23;
            this.btnMemoryRead.Text = "MR";
            this.btnMemoryRead.UseVisualStyleBackColor = true;
            this.btnMemoryRead.Click += new System.EventHandler(this.ReadMemory);
            // 
            // btnMemoryPlus
            // 
            this.btnMemoryPlus.Enabled = false;
            this.btnMemoryPlus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryPlus.Location = new System.Drawing.Point(144, 74);
            this.btnMemoryPlus.Name = "btnMemoryPlus";
            this.btnMemoryPlus.Size = new System.Drawing.Size(77, 40);
            this.btnMemoryPlus.TabIndex = 24;
            this.btnMemoryPlus.Text = "M+";
            this.btnMemoryPlus.UseVisualStyleBackColor = true;
            // 
            // btnMemoryMinus
            // 
            this.btnMemoryMinus.Enabled = false;
            this.btnMemoryMinus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemoryMinus.Location = new System.Drawing.Point(227, 74);
            this.btnMemoryMinus.Name = "btnMemoryMinus";
            this.btnMemoryMinus.Size = new System.Drawing.Size(71, 40);
            this.btnMemoryMinus.TabIndex = 25;
            this.btnMemoryMinus.Text = "M-";
            this.btnMemoryMinus.UseVisualStyleBackColor = true;
            // 
            // btnMemorySave
            // 
            this.btnMemorySave.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemorySave.Location = new System.Drawing.Point(304, 74);
            this.btnMemorySave.Name = "btnMemorySave";
            this.btnMemorySave.Size = new System.Drawing.Size(76, 40);
            this.btnMemorySave.TabIndex = 26;
            this.btnMemorySave.Text = "MS";
            this.btnMemorySave.UseVisualStyleBackColor = true;
            this.btnMemorySave.Click += new System.EventHandler(this.SaveInMemory);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeSign.Location = new System.Drawing.Point(12, 350);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(80, 40);
            this.btnChangeSign.TabIndex = 27;
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.ChangeSign);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(270, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "⌫";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(184, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearEntry.Location = new System.Drawing.Point(98, 120);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(80, 40);
            this.btnClearEntry.TabIndex = 29;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.ClearEntry);
            // 
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReminder.Location = new System.Drawing.Point(12, 120);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(80, 40);
            this.btnReminder.TabIndex = 28;
            this.btnReminder.Text = "%";
            this.btnReminder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 399);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnMemorySave);
            this.Controls.Add(this.btnMemoryMinus);
            this.Controls.Add(this.btnMemoryPlus);
            this.Controls.Add(this.btnMemoryRead);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryRead;
        private System.Windows.Forms.Button btnMemoryPlus;
        private System.Windows.Forms.Button btnMemoryMinus;
        private System.Windows.Forms.Button btnMemorySave;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnReminder;
    }
}

