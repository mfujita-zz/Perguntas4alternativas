using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Pergunta4 : Form
    {
        public Pergunta4()
        {
            InitializeComponent();
        }

        private void Pergunta4_Load(object sender, EventArgs e)
        {
            //Página 42
            lblPergunta4.Text = "Assinale a alternativa que é uma característica do desenvolvimento pessoal: ";
            rb1.Text = "Aprender um assunto novo."; //Assinalar esta
            rb2.Text = "Trabalhar pouco.";
            rb3.Text = "Fazer sempre o mesmo trabalho.";
            rb4.Text = "Ganhar um notebook e celular para levar depois do horário de trabalho.";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            bool valor;
            if (rb1.Checked)
                valor = true;
            else
                valor = false;

            Utilidades.ArmazenaResposta(3, valor);

            Pergunta5 p5 = new Pergunta5();
            p5.Show();
        }
    }
}
