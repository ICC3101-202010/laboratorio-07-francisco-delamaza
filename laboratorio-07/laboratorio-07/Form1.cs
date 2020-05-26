using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_07
{
    public partial class Calculadora : Form
    {
        string pie = "0";
        int hola = 0;
        Double valor = 0;
        int este= 0;
        Double valor2 = 0;
        string operationPerformed = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "1";
        }
       

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            
            operationPerformed = button14.Text;
            valor = Double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "+";
            este = textBox1.Text.Count();
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            operationPerformed = button15.Text;
            valor = Double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "x";
            este = textBox1.Text.Count();


        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            operationPerformed = button17.Text;
            valor = Double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "÷";
            este = textBox1.Text.Count();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            este = textBox1.Text.Count();
            operationPerformed = button18.Text;
            valor = Double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "-";
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hola = textBox1.Text.Count();
            valor2 = Double.Parse(textBox1.Text.Substring(este));
            switch (operationPerformed)
            {

                case "+":
                    textBox1.Text = (valor + valor2).ToString()+"estoy sumando";
                    break;
                case "-":
                    textBox1.Text = (valor - valor2).ToString();
                    break;
                case "X":
                    textBox1.Text = (valor * valor2).ToString();
                    break;
                case "÷":
                    textBox1.Text = (valor / valor2).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
