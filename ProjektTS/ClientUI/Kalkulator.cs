using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Kalkulator : Form
    {
        CalculatorOperation calculatorOperation;
        public Kalkulator()
        {
            InitializeComponent();
            calculatorOperation = new CalculatorOperation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextResult.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextResult.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextResult.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (TextResult.Text.Length != 0) { TextResult.Text += "0"; }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (TextResult.Text.Length == 0) { TextResult.Text += "0"; }
            TextResult.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            TextResult.Text += "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (TextResult.Text.Length == 0) { TextResult.Text += "0"; }
            TextResult.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (TextResult.Text.Length == 0) { TextResult.Text += "0"; }
            TextResult.Text += "/";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (TextResult.Text.Length == 0) { TextResult.Text += "0"; }
            TextResult.Text += "^";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            TextResult.Text += ".";
        }
    }
}
