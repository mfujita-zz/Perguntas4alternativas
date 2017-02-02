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
    public partial class Pergunta5 : Form
    {
        public Pergunta5()
        {
            InitializeComponent();
        }

        private void Pergunta5_Load(object sender, EventArgs e)
        {
            //Página 69
            lblPergunta5.Text = "Há várias maneiras de recompensar e é essencial compreender quais são os motivadores de alguém antes de decidir qual recompensa é apropriada para aquela pessoa. \nAs alternativas abaixo apresentam uma recompensa e sua aplicação. Qual não está correta?";
            rb1.Text = "Empréstimos. Empréstimos para aquisição de pacotes turísticos ou outros.";
            rb2.Text = "Ticket Alimentação. Compras de produtos em supermercado incluindo bebidas e fumos."; //True
            rb3.Text = "Treinamento/Desenvolvimento. Treinamento pessoal ou profissional.";
            rb4.Text = "Reconhecimento. Nota escrita à mão, menção no jornal da empresa, um simples \"obrigado\"";
        }

        private void bntResposta5_Click(object sender, EventArgs e)
        {
            bool valor;
            if (rb2.Checked)
                valor = true;
            else
                valor = false;

            Utilidades.ArmazenaResposta(4, valor);

            MessageBox.Show("Você acertou " + Utilidades.DevolveResposta() + " respostas!", "Resultados");
            Application.Exit();
        }
    }
}
