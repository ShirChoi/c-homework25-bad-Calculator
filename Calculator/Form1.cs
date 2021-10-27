using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private delegate decimal BinaryOperation(decimal operand1, decimal operand2);
        private delegate decimal UnaryOperation(decimal operand);
        private bool _afterComma = false;
        private BinaryOperation _binaryOperationChosen;
        private UnaryOperation  _unaryOperationChosen;
        private string _firstValue = "0";
        private string _savedNumber = null;

        private bool isBufferFilled => _savedNumber != null;
        private bool isBinOperationChosen => _binaryOperationChosen != null;
        private bool isUnOperationChosen => _unaryOperationChosen != null;

        private decimal Addition(decimal num1, decimal num2) => num1 + num2;
        private decimal Subtraction(decimal num1, decimal num2) => num1 - num2;
        private decimal Multiplication(decimal num1, decimal num2) => num1 * num2;
        private decimal Division(decimal num1, decimal num2) => num1 / num2;
        private decimal Reverse(decimal num) => 1 / num;
        private decimal Square(decimal num) => num * num;
        // крч если num > double.max то всё сломается
        private decimal SquareRoot(decimal num) => (decimal)Math.Sqrt((double)num); 
        private string NumberAsText {
            get {
                return lblOutput.Text;
            }

            set {
                lblOutput.Text = value;
                _afterComma = lblOutput.Text.Contains(',');
            }
        }

        private void BinaryOperationPressed(object sender, EventArgs e) {
            Button pressedButton = sender as Button;

            /*if(OperationChosen) {
                ExecuteBinaryOperation(_firstValue, NumberAsText, _operation);
                _operation = null;
            }*/

            _binaryOperationChosen = pressedButton.Text switch {
                "+" => Addition,
                "-" => Subtraction,
                "X" => Multiplication,
                "÷" => Division,
                _   => throw new Exception("Undefined operation")
            };

            _firstValue = NumberAsText;
            NumberAsText = "0";
        }

        private void UnaryOperationPressed(object sender, EventArgs e) {
            Button buttonPressed = sender as Button;
            
            _unaryOperationChosen = buttonPressed.Text switch {
                "1/x" => Reverse,
                "x²" => Square,
                "√x" => SquareRoot,
                _ => throw new Exception()
            };
            
            _binaryOperationChosen = null;

            Calculate(btnCalculate, e);
        }

        private void Calculate(object sender, EventArgs e) {
            try {
                if(isBinOperationChosen)
                    _firstValue = ExecuteBinaryOperation(_firstValue, NumberAsText, _binaryOperationChosen).ToString();
                else if(isUnOperationChosen)
                    _firstValue = ExecuteUnaryOperation(NumberAsText, _unaryOperationChosen).ToString();
                
                _unaryOperationChosen = null;
                _binaryOperationChosen = null;
                NumberAsText = _firstValue;
            } catch(DivideByZeroException) {
                NumberAsText = "Нельзя делить на ноль";
                _binaryOperationChosen = null;
                _firstValue = "0";
            } catch(OverflowException) { // если корень от отрицательного числа брать
                
                NumberAsText = "Числовое переполнение";
                
                _binaryOperationChosen = null;
                _unaryOperationChosen = null;
                _firstValue = "0";
            }
        }

        private void NumberPressed(object sender, EventArgs e) {
            Button pressedButton = sender as Button;

            int numberPressed = int.Parse(pressedButton.Text);

            if(NumberAsText == "0" || NumberAsText == "Cannot divide by zero") {
                if(numberPressed != 0)
                    NumberAsText = numberPressed.ToString();
                return;
            }

            NumberAsText += numberPressed.ToString();
        }

        private void Delete(object sender, EventArgs e) {

            if(NumberAsText.Length == 1) {
                NumberAsText = "0";

                return;
            }

            if(NumberAsText.Last() == ',')
                _afterComma = false;

            NumberAsText = NumberAsText.Remove(NumberAsText.Length - 1);
        }

        private void PutComma(object sender, EventArgs e) {
            bool isNumber = decimal.TryParse(NumberAsText, out decimal num);
            if(_afterComma)
                return;
            if(!isNumber)
                NumberAsText = "0";

            NumberAsText += ',';
            _afterComma = true;
        }

        private void ChangeSign(object sender, EventArgs e) {
            if(NumberAsText == "0")
                return;

            if(NumberAsText[0] == '-') {
                NumberAsText = NumberAsText.Remove(0, 1);

                return;
            }

            NumberAsText = '-' + NumberAsText;
        }

        private void ClearEntry(object sender, EventArgs e) {
            NumberAsText = "0";
            _afterComma = false;
        }


        private decimal ExecuteBinaryOperation(string num1, string num2, BinaryOperation operation) {
            bool isNum1 = decimal.TryParse(num1, out decimal val1);
            if(!isNum1)
                val1 = 0;

            bool isNum2 = decimal.TryParse(num2, out decimal val2);
            if(!isNum2)
                val2 = 0;

            return operation(val1, val2);
           
        }

        private decimal ExecuteUnaryOperation(string num, UnaryOperation operation) {
            bool isNum = decimal.TryParse(num, out decimal val);

            if(!isNum)
                val = 0;

            return operation(val);
        }

        private void Clear(object sender, EventArgs e) {
            _firstValue = "0";
            NumberAsText = "0";
            _binaryOperationChosen = null;
            _unaryOperationChosen = null;
            _afterComma = false;
        }

        private void SaveInMemory(object sender, EventArgs e) {
            bool isNum = decimal.TryParse(NumberAsText, out decimal num);
            btnMemoryClear.Enabled = true;
            btnMemoryMinus.Enabled = true;
            btnMemoryPlus.Enabled = true;
            btnMemoryRead.Enabled = true;

            _savedNumber = isNum ? NumberAsText : "0";
        }

        private void ClearMemory(object sender, EventArgs e) {
            btnMemoryClear.Enabled = false;
            btnMemoryMinus.Enabled = false;
            btnMemoryPlus.Enabled = false;
            btnMemoryRead.Enabled = false;
            _savedNumber = null;
        }

        private void ReadMemory(object sender, EventArgs e) {
            NumberAsText = _savedNumber;
        }
    }
}