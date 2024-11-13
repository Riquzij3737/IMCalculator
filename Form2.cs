using MMCalculator;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace MMCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = $"Seu IMC é de {Form1.IMC}";
            label2.Text = $"O que é considerado: {Verificação()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private string Verificação()
        {
            int valores = Form1.Verify(Form1.IMC);            
            panel2.Visible = true;

            switch (valores)
            {               

                case 1:
                    panel2.BackColor = Color.Cyan;
                    return "Abaixo do peso";

                case 2:
                    panel2.BackColor = Color.Green;
                    return "Normal";

                case 3:
                    panel2.BackColor = Color.Yellow;
                    return "Obesidade leve";

                case 4:
                    panel2.BackColor = Color.Orange;
                    return "Obesidade moderada";

                case 5:
                    panel2.BackColor = Color.Red;
                    return "Obesidade mórbida";

                case 0:
                    panel2.BackColor = Color.Black;
                    return "Que poha é essa, tá morto?";

                default:
                    return "Ela não te ama, mano. Abandona!";
            }
        }
    }
}
