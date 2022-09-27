using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WA_Calculator
{
    public partial class Form1 : Form
    {
        char operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            operation = '+';
            //txtC.Text = textBox1.Text + "+" + textBox2.Text;
        }


        private void first(object sender, EventArgs e)
        {

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operation = '-';
            //txtC.Text = textBox1.Text + " - " + textBox2.Text;
        }

        private void btnMultiplicate_Click(object sender, EventArgs e)
        {
            operation = '*';
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = '/';
        }


        private void btnCompute_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case '+': txtC.Text = "+"; txtC.Text = textBox1.Text + "+" + textBox2.Text + " = " + (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString(); break;
                case '-': txtC.Text = "-"; txtC.Text = textBox1.Text + "-" + textBox2.Text + " = " + (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString(); break;
                case '*': txtC.Text = "*"; txtC.Text = textBox1.Text + "*" + textBox2.Text + " = " + (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString(); break;
                case '/': txtC.Text = "/"; txtC.Text = textBox1.Text + "/" + textBox2.Text + " = " + (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString(); break;

            }



            /*if (txtC.Text.Contains("+"))
            { 
                txtC.Text = txtC.Text + " = " + (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
            }
            else if (txtC.Text.Contains("-"))
            {
                txtC.Text = txtC.Text + " = " + (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* this button is of clear or next */
            textBox1.Clear();
            textBox2.Clear();
       
        }
    }
}
