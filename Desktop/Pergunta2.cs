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
    public partial class Pergunta2 : Form
    {
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {
            //Página 30
            lblPergunta2.Text = "Um passo importante para começar as mudanças na sua vida é acreditar em você mesmo. Todas as alternativas abaixo referem-se a descobrir o que te motiva, exceto:";
            rb1.Text = "Fazer somente o que gosta."; // Errada
            rb2.Text = "Saiba quais são as prioridades da sua vida.";
            rb3.Text = "Elabore um modo de equilibrar suas prioridades.";
            rb4.Text = "Use seus valores para dirigir sua vida.";
        }

        private void btnResposta2_Click(object sender, EventArgs e)
        {
            bool valor;
            if (rb1.Checked)
                valor = true;
            else
                valor = false;

            Utilidades.ArmazenaResposta(1, valor);

            Pergunta3 p3 = new Pergunta3();
            p3.Show();
        }
    }
}
