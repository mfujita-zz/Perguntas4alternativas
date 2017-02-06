using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Pergunta3 : Form
    {
        public Pergunta3()
        {
            InitializeComponent();
        }

        private void Pergunta3_Load(object sender, EventArgs e)
        {
            //Página 37
            lblPergunta3.Text = "É importante estimular as pessoas a compreender os vínculos entre esforço e os resultados e mostrar-lhes claramente de que maneira se beneficiarão desses resultados. \nAs alternativas abaixo apresentam as motivações para trabalhar em níveis ótimo exceto:";
            rb1.Text = "Pensarem que o aumento de seus esforços resultará em melhor desempenho.";
            rb2.Text = "Pensarem que serão recompensadas pelo esforço adicional que fizerem para alcançar aquele desempenho.";
            rb3.Text = "São os benefícios que motivam o trabalho apaziguando o fardo."; // True
            rb4.Text = "Valorizarem aquele recompensa.";
        }

        private void btnResposta3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, ID_JOGADOR) values (@perg, @resp, @ID_JOGADOR)", conexao))
                {
                    if (rb3.Checked)
                    {
                        cmd.Parameters.AddWithValue("perg", lblPergunta3.Text);
                        cmd.Parameters.AddWithValue("resp", rb3.Text);
                        cmd.Parameters.AddWithValue("ID_JOGADOR", 2);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                    Pergunta4 p4 = new Pergunta4();
                    p4.ShowDialog();
                }
            }
        }
    }
}
