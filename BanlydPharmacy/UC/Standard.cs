using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BanlydPharmacy.UC
{
    public partial class Standard : UserControl
    {
        // Global variables
        bool isOperationPerformed, canCalculateWithOperator, canCalculateWithEqualTo, resetScreenText, isEqualToClicked,
            plusOrMinusPerformed, clearScreenText, isfraction, isSquared, isSqrt, isPercent, isStarted, isACStarted;
        double result, initialCurrentResult, lastNo;
        int countTopText = 0;
        List<string> operators = new List<string>(); // list of operators used which is performed based on the other of clicking
        Stack<double> TopScreenNumbers = new Stack<double>();
        Stack<string> operatorCopy = new Stack<string>();
        // default constructor
        public Standard()
        {
            InitializeComponent();
        }
        //
        protected override void OnLoad(EventArgs e)
        {
            result = initialCurrentResult = lastNo = 0;
            isOperationPerformed = canCalculateWithOperator = canCalculateWithEqualTo = isEqualToClicked = resetScreenText =
                plusOrMinusPerformed = clearScreenText = isfraction = isSquared = isSqrt = isPercent = isStarted = isACStarted = false;
            base.OnLoad(e);
        }
        // Override this function from the forms class to make all keys trigger the KeyPress event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Back)
                OnKeyPress(new KeyPressEventArgs((char)Keys.Back));
            else if (keyData == Keys.Add)
                OnKeyPress(new KeyPressEventArgs((char)Keys.Add));
            else if (keyData == Keys.Subtract)
                OnKeyPress(new KeyPressEventArgs((char)Keys.Subtract));
            else if (keyData == Keys.Multiply)
                OnKeyPress(new KeyPressEventArgs((char)Keys.Multiply));
            else if (keyData == Keys.Divide)
                OnKeyPress(new KeyPressEventArgs((char)Keys.Divide));
            else if (keyData == Keys.Enter)
                OnKeyPress(new KeyPressEventArgs((char)Keys.Enter));
            //
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        private void PerformEqualTo(double currentResult)
        {
            int length, index;
            length = operators.Count;
            index = length - 1;
            if (length > 0)
            {
                switch (operators[index])
                {
                    case "+":
                        CalculateAns("+", currentResult);
                        break;
                    case "-":
                        CalculateAns("-", currentResult);
                        break;
                    case "×":
                        CalculateAns("×", currentResult);
                        break;
                    case "÷":
                        CalculateAns("÷", currentResult);
                        break;
                    default:
                        MessageBox.Show("Select the right operator");
                        break;
                }
            }
        }
        //
        private void CalculateAns(string operation, double currentResult)
        {
            lastNo = currentResult;
            switch (operation)
            {
                case "+":
                    result += currentResult;
                    break;
                case "-":
                    result -= currentResult;
                    break;
                case "×":
                    result *= currentResult;
                    break;
                case "÷":
                    result /= currentResult;
                    break;
                default:
                    break;
            }
            ScreenText_lbl.Text = result.ToString();
        }
        //
        private int ShowTopScreen(List<string> operate, int show)
        {
            int length = 0, index = 0;
            length = operate.Count;
            if (length > 0)
            {
                if (length == 1)
                    index = length - 1;
                else
                    index = length - 2;
                string topText = TopScreenText_lbl.Text, screenText = ScreenText_lbl.Text;
                if (show == 1)
                {
                    if (length == 1)
                    {
                        TopScreenText_lbl.Text += ScreenText_lbl.Text + " " + operators[index] + " ";
                        //
                        if (topText.Contains("negate"))
                            TopScreenText_lbl.Text += " " + operators[index] + " ";
                    }
                    else
                    {
                        if (operators[length - 2] == "+" && screenText[0].ToString() == "-")
                            TopScreenText_lbl.Text = topText.Remove(topText.Length - 2) + "- " + screenText.Remove(0, 1) + " " + operators[index + 1];
                        else if (operators[length - 2] == "-" && ScreenText_lbl.Text[0].ToString() == "-")
                            TopScreenText_lbl.Text = topText.Remove(topText.Length - 2) + "+ " + screenText.Remove(0, 1) + " " + operators[index + 1];
                        else
                            TopScreenText_lbl.Text += ScreenText_lbl.Text + " " + operators[index + 1] + " ";
                        if (topText.Contains("negate"))
                            TopScreenText_lbl.Text += " " + operators[index + 1] + " ";
                    }
                }
                else if (show == 2)
                {
                    if (length == 1)
                        TopScreenText_lbl.Text += " " + operators[index] + " ";
                    else
                    {
                        TopScreenText_lbl.Text += " " + operators[index + 1] + " ";
                    }
                    isPercent = false;
                }
                else if (show == 3)
                {
                    if (length == 1)
                        TopScreenText_lbl.Text = TopScreenText_lbl.Text.Remove(TopScreenText_lbl.Text.Length - 2) + " " + operators[index] + " ";
                    else
                        TopScreenText_lbl.Text = TopScreenText_lbl.Text.Remove(TopScreenText_lbl.Text.Length - 2) + operators[index + 1] + " ";
                }
            }
            return index;
        }
        //
        private void C()
        {
            TopScreenText_lbl.Text = "";
            ScreenText_lbl.Text = "0";
            result = initialCurrentResult = lastNo = 0;
            isOperationPerformed = isEqualToClicked = resetScreenText = canCalculateWithEqualTo = canCalculateWithOperator =
                plusOrMinusPerformed = clearScreenText = isfraction = isSquared = isSqrt = isPercent = isStarted = isACStarted = false;
            operators.Clear(); // clear the list of operators
            TopScreenNumbers.Clear();
            operatorCopy.Clear();
        }
        //
        private void CE()
        {
            ScreenText_lbl.Text = "0";
        }
        //
        private void BackSpace()
        {
            int length = ScreenText_lbl.Text.Length, index = length - 1;
            if (length >= 0)
            {
                ScreenText_lbl.Text = ScreenText_lbl.Text.Remove(index);
                if (ScreenText_lbl.Text.Length == 0 || ScreenText_lbl.Text == "-")
                    ScreenText_lbl.Text = "0";
            }
        }
        //
        private Stack<string> ListToStack_operators(List<string> operators)
        {
            Stack<string> AllOperators = new Stack<string>();
            this.operators = operators;
            foreach (string op in operators)
            {
                AllOperators.Push(op);
            }
            return AllOperators;
        }
        //
        private void AC()
        {
            try
            {
                string Toptext = "";
                if (!isACStarted)
                {
                    this.operatorCopy.Clear(); // clear it first
                    operatorCopy = ListToStack_operators(operators); // fill the stack with the list of operators
                    operatorCopy.Pop(); // remove the top opeartor
                    isACStarted = true; // this makes this block inaccessible
                }
                else
                    operatorCopy.Pop(); // remove the top opeartor
                // perform these switch instructions on the top item after removal
                switch (operatorCopy.Peek())
                {
                    case "+":
                        result -= TopScreenNumbers.Peek();
                        break;
                    case "-":
                        result += TopScreenNumbers.Peek();
                        break;
                    case "×":
                        result /= TopScreenNumbers.Peek();
                        break;
                    case "÷":
                        result *= TopScreenNumbers.Peek();
                        break;
                    default:
                        MessageBox.Show("AC didn't perform");
                        break;
                }
                ScreenText_lbl.Text = result.ToString();
                TopScreenNumbers.Pop();
                for (int i = 1; i <= 4; i++)
                {
                    Toptext = TopScreenText_lbl.Text.Remove(TopScreenText_lbl.Text.Length - i);
                }
                TopScreenText_lbl.Text = Toptext;
            }
            catch { throw new NotImplementedException(); }
        }
        //
        // EVENT HANDLERS
        //
        private void Standard_Load(object sender, EventArgs e)
        {
            TopScreenText_lbl.Text = "";
            ScreenText_lbl.Text = "0";
        }
        //
        private void Memory_lbl_Click(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //
        private void Percent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double resultC = 0;
                if (!isPercent)
                {
                    double percent = double.Parse(ScreenText_lbl.Text);
                    resultC = percent * 100;
                    if (resultC < -100 || resultC > 100)
                        resultC /= 100;
                    ScreenText_lbl.Text = resultC.ToString();
                    countTopText = ("percent(" + percent + ")").Length; // count the topscreen text to be used in showScreen function
                    TopScreenText_lbl.Text += "percent(" + percent + ")";
                }
                else
                {
                    resultC = double.Parse(ScreenText_lbl.Text) * 100;
                    if (resultC < -100 || resultC > 100)
                        resultC /= 100;
                    else
                    {
                        TopScreenText_lbl.Text += "percent(" + TopScreenText_lbl.Text + ")";
                        ScreenText_lbl.Text = resultC.ToString();
                    }
                }
                isPercent = canCalculateWithOperator = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //
        private void SquareRoot_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double sqrt = double.Parse(ScreenText_lbl.Text);
                double resultC = Math.Sqrt(sqrt);
                if (!isSqrt)
                    TopScreenText_lbl.Text += " √(" + sqrt + ")";
                else
                    TopScreenText_lbl.Text += " √(" + TopScreenText_lbl.Text + ")";
                isSqrt = canCalculateWithOperator = true;
                ScreenText_lbl.Text = resultC.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //
        private void Squared_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double square = double.Parse(ScreenText_lbl.Text);
                double resultC = Math.Pow(square, 2);
                if (!isSquared)
                    TopScreenText_lbl.Text += "sqr(" + square + ")";
                else
                    TopScreenText_lbl.Text += "sqr(" + TopScreenText_lbl.Text + ")";
                isSquared = canCalculateWithOperator = true;
                ScreenText_lbl.Text = resultC.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //
        private void Fraction_btn_Click(object sender, EventArgs e)
        {

        }
        //
        private void ClearScreenText_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                if (btn.Text == "CE")
                    CE();
                else if (btn.Text == "AC")
                    AC();
                else if (btn.Name == C_btn.Name)
                    C();
                else if (btn.Name == Delete_btn.Name)
                {
                    if (result != double.Parse(ScreenText_lbl.Text))
                        BackSpace();
                }
            }
            catch (Exception) { }
        }
        //
        private void NumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                double currentNumbers = double.Parse(ScreenText_lbl.Text);
                // The lastIndex necessary becase of the mneumonics and because only single numbers are captured
                int lastIndex = btn.Text.Length - 1;
                // only 16-digit numbers are required
                if (ScreenText_lbl.Text.Length <= 16)
                {
                    if (ScreenText_lbl.Text.Equals("0") || resetScreenText)
                        ScreenText_lbl.Text = "";
                    if (clearScreenText)
                        TopScreenText_lbl.Text = "";
                    // when the decimal point is clicked 
                    if (btn.Name == Decimal_btn.Name)
                    {
                        if (!ScreenText_lbl.Text.Contains("."))
                        {
                            if (ScreenText_lbl.Text == "" || ScreenText_lbl.Text == "0")
                                ScreenText_lbl.Text = "0.";
                            else
                                ScreenText_lbl.Text += ".";
                        }
                    }
                    else
                        ScreenText_lbl.Text += (btn.Text[lastIndex]).ToString();
                }
                canCalculateWithOperator = canCalculateWithEqualTo = true;
                clearScreenText = plusOrMinusPerformed = resetScreenText = isACStarted = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\nSource" + ex.StackTrace, "Error"); }
        }

        //
        private void PlusOrMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(ScreenText_lbl.Text.Trim()), transposedNo;
                transposedNo = number;
                if (number != 0)
                    transposedNo *= -1;
                else if (number == 0)
                    transposedNo = 0;
                ScreenText_lbl.Text = transposedNo.ToString();
                if (isEqualToClicked)
                {
                    if (!plusOrMinusPerformed)
                        TopScreenText_lbl.Text = "negate(" + TopScreenText_lbl.Text + number + ")";
                    else
                        TopScreenText_lbl.Text = "negate(" + TopScreenText_lbl.Text + ")";
                    clearScreenText = true;
                }
                canCalculateWithOperator = canCalculateWithEqualTo = plusOrMinusPerformed = true;
                isACStarted = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\nSource" + ex.StackTrace, "Error"); }
        }
        //
        private void Operator_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                int index = 0;
                // Check if the last operator and the current one are the same
                if (!isStarted)
                    canCalculateWithOperator = true;
                if (canCalculateWithOperator)
                {
                    // This will perform only once. This stops after the canCalculateWithOperator variable is set to false
                    operators.Add(btn.Text);
                    TopScreenNumbers.Push(double.Parse(ScreenText_lbl.Text));
                    if (!isEqualToClicked)
                    {
                        if (!(isSqrt || isSquared || isfraction || isPercent))
                            index = ShowTopScreen(operators, 1);
                        else
                            index = ShowTopScreen(operators, 2);
                        //
                        if (!isOperationPerformed)
                            result = double.Parse(ScreenText_lbl.Text);
                        else
                            CalculateAns(operators[index], double.Parse(ScreenText_lbl.Text));
                    }
                    else
                    {
                        result = double.Parse(ScreenText_lbl.Text);
                        TopScreenText_lbl.Text = result + " " + btn.Text + " ";
                        isEqualToClicked = false;
                    }
                    ScreenText_lbl.Text = result.ToString();
                }
                else
                {
                    // This will perform the operation over and over again when the operation keeps changing on the same number
                    if (operators[operators.Count - 1] != btn.Text)
                    {
                        // This will perform only when different operator is pressed
                        operators.RemoveAt(operators.Count - 1); // remove the last operator
                        operators.Add(btn.Text); // add the new operator
                        ShowTopScreen(operators, 3);
                    }
                }
                isOperationPerformed = resetScreenText = isStarted = true;
                canCalculateWithOperator = isACStarted = isSqrt = isSquared = isfraction = isPercent = false;
            }
            catch (Exception ex) { MessageBox.Show("Message: \n" + ex.Message + "\nSource: \n" + ex.StackTrace, "Exception"); }
        }
        //
        private void Equalto_Click(object sender, EventArgs e)
        {
            try
            {
                TopScreenText_lbl.Text = "";
                if (canCalculateWithEqualTo)
                {
                    initialCurrentResult = double.Parse(ScreenText_lbl.Text);
                    PerformEqualTo(initialCurrentResult);
                }
                else
                    PerformEqualTo(initialCurrentResult);
                isEqualToClicked = resetScreenText = canCalculateWithOperator = isACStarted = true;
                canCalculateWithEqualTo = false;
            }
            catch (Exception ex) { MessageBox.Show("Message: \n" + ex.Message + "\nSource: \n" + ex.StackTrace, "Exception"); }
        }
        //
        private void Standard_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back)
                    BackSpace();
                else if (e.KeyChar == (char)Keys.Add)
                    Plus_btn.PerformClick();
                else if (e.KeyChar == (char)Keys.Subtract)
                    Minus_btn.PerformClick();
                else if (e.KeyChar == (char)Keys.Multiply)
                    Multiply_btn.PerformClick();
                else if (e.KeyChar == (char)Keys.Divide)
                    Divide_btn.PerformClick();
                else if (e.KeyChar == (char)Keys.Enter)
                    Equal_btn.Select();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //
        private void ChangeCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CE_btn.Text == "CE")
                CE_btn.Text = "AC";
            else
                CE_btn.Text = "CE";
        }
    }
}
