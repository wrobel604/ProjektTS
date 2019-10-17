using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class MathOperation : Form
    {
        CalculatorOperation calculatorOperation;
        public MathOperation()
        {
            InitializeComponent();
            calculatorOperation = new CalculatorOperation();
        }

        private void OperacjaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatorOperation.operation = calculatorOperation.operationName[OperacjaBox.SelectedIndex];
        }

        private void NumberX_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (RegexTests.isNumber(textBox.Text) || textBox.Text.Length==0) { textBox.BackColor = Color.White; }else { textBox.BackColor = Color.Red; }
        }
    }
}
