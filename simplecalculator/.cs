using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDecimal(tbxA.Text);
            var number2 = Convert.ToDecimal(tbxB.Text);
            var result = number1 + number2;
            MessageBox.Show(result.ToString()); // converts 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDecimal(tbxA.Text);
            var number2 = Convert.ToDecimal(tbxB.Text);
            var result = number1 - number2;
            MessageBox.Show(result.ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDecimal(tbxA.Text);
            var number2 = Convert.ToDecimal(tbxB.Text);
            var result = number1 * number2;
            MessageBox.Show(result.ToString());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDecimal(tbxA.Text);
            var number2 = Convert.ToDecimal(tbxB.Text);
            var result = number1 / number2;
            MessageBox.Show(result.ToString());
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDecimal(tbxA.Text);
            var number2 = Convert.ToDecimal(tbxB.Text);
            var result = number1 % number2;
            MessageBox.Show(result.ToString());
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDecimal(tbxA.Text);
            var number2 = Convert.ToDecimal(tbxB.Text);
            var result = Math.Pow(Convert.ToDouble(number1), Convert.ToDouble(number2));
            MessageBox.Show(result.ToString());
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using this calculator!");
            this.Close();
        }
    }
}
