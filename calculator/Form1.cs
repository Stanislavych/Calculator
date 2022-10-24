using Calculator.Logic.Implementations;

namespace Calculator
{
    public partial class calculator : Form
    {
        Calculation calculation = new();
        string unary = "";
        string a = "";
        string b = "";
        string operation = "";
        public calculator()
        {
            InitializeComponent();
        }
        
       
        private void Calculator_Load(object sender, EventArgs e)
        {
            labelSign.Text = string.Empty;
            MaximizeBox = false;
        }
        private void OperationChange(string str)
        {
            if (a != string.Empty && b != string.Empty)
            {
                a = calculation.ProcessStatement(unary, a + operation + b);
                if (a[0] == '-')
                {
                    labelSign.Text = unary = "-";
                    a = a.Substring(1);
                }
                else
                {
                    labelSign.Text = unary = string.Empty;
                }
                Display.Text = a;
                operation = str;
                b = string.Empty;
            }
            else
            {
                operation = str;
            }
        }

        private void OperandChange(string str)
        {
            if (operation == string.Empty && a.Length<9)
            {
                a += str;
                Display.Text = a;
            }
            else if (a != string.Empty && operation != string.Empty && b.Length < 9)
            {
                b += str;
                Display.Text = b;
                labelSign.Text = string.Empty;
            }
        }
        private void UnaryChange()
        {
            if (operation == string.Empty)
            {
                if (unary != "-")
                {
                    labelSign.Text= unary = "-";
                }
                else
                {
                    labelSign.Text = unary = string.Empty;
                }
            }
        }
        private void Delete()
        {
            a = string.Empty;
            b = string.Empty;
            operation = string.Empty;
           labelSign.Text= unary = string.Empty;
            Display.Clear();
        }
        private void Equally()
        {
            a = calculation.ProcessStatement(unary, a + operation + b);
            if (a[0] == '-')
            {
                labelSign.Text = unary = "-";
                a = a.Substring(1);
            }
            else
            {
                labelSign.Text = unary = string.Empty;
            }
            Display.Text = a;
            b = string.Empty;
            operation = string.Empty;
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            OperandChange("0");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            OperandChange("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            OperandChange("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            OperandChange("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            OperandChange("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            OperandChange("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            OperandChange("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            OperandChange("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            OperandChange("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            OperandChange("9");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OperationChange("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            OperationChange("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            OperationChange("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            OperationChange("/");
        }

        private void buttonUnary_Click(object sender, EventArgs e)
        {
            UnaryChange();
           
        }
        private void buttonEqually_Click(object sender, EventArgs e)
        {
            Equally();
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}