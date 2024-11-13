using MMCalculator;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace  MMCalculator
{
    public partial class Form1 : Form
    {
        public static float IMC;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float altura = float.Parse(textBox1.Text);
            float peso = float.Parse(textBox2.Text);

            calculo(peso, altura);

            Form2 form = new Form2();
            form.ShowDialog();
        }

        public static void calculo(float peso, float altura)
        {
            if (peso <= 0 || altura <= 0)
            {
                MessageBox.Show("Erro, valores inseridos são inválidos!");
            }
            else
            {
                
                IMC = peso / (altura * altura);
            }
        }

        public static int Verify(float imc)
        {
            if (imc < 20)
            {
                return 1;
            }
            else if (imc >= 20 && imc <= 24.9)
            {
                return 2;
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                return 3;
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                return 4;
            }
            else if (imc >= 40)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
    }
}
