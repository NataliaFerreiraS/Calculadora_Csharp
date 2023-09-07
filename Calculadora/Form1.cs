using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
   

    public partial class calculadoraIndex : Form
    {

        decimal vlr1 = 0, vlr2 = 0;
        string operacao = "";

        public calculadoraIndex()
        {
            InitializeComponent();
        }


        private void calculadoraIndex_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnmenosmais_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            

            operacao = "MAISMENOS";

            txtOperacao.Text = "+/-";
          
            if (operacao == "MAISMENOS")
            {
                textResult.Text = Convert.ToString(vlr1 * (-1));
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "0";
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            vlr2 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textResult.Text = Convert.ToString(vlr1 + vlr2 );
            }
            if (operacao == "SUB")
            {
                textResult.Text = Convert.ToString(vlr1 - vlr2);
            }
            if (operacao == "VEZES")
            {
                textResult.Text = Convert.ToString(vlr1 * vlr2);
            }
            if (operacao == "DIV")
            {
                textResult.Text = Convert.ToString(vlr1 / vlr2);
            }
            if (operacao == "PORC")
            {
                textResult.Text = Convert.ToString((vlr1/100) * vlr2);
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "3";
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture) ;

            textResult.Text = "";

            operacao = "SOMA";

            txtOperacao.Text = "+";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "6";
        }


        private void btnMenos_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            textResult.Text = "";

            operacao = "SUB";

            txtOperacao.Text = "-";
        }

        private void btnvezes_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            textResult.Text = "";

            operacao = "VEZES";

            txtOperacao.Text = "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "7";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            textResult.Text = "";

            operacao = "DIV";

            txtOperacao.Text = "/";
        }

        private void btnporcen_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            textResult.Text = "";

            operacao = "PORC";

            txtOperacao.Text = "%";
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
            txtOperacao.Text = "";
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMover_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            vlr1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);

            string currentText = textResult.Text;

            if (!string.IsNullOrEmpty(currentText))
            {
                currentText = currentText.Substring(0, currentText.Length - 1);
                textResult.Text = currentText;
            }
        }

                
    }
}
