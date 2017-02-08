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
    public partial class Pergunta2 : Form
    {
        public int idJogador;
        public Pergunta2(int jogador)
        {
            InitializeComponent();
            idJogador = jogador;
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
            using (SqlConnection conexao = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_Connection=Yes"))
            //using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, id_jogador) values (@PERG, @RESP,@ID_JOGADOR)", conexao))
                {
                    if (rb1.Checked)
                    {
                        cmd.Parameters.AddWithValue("PERG", lblPergunta2.Text);
                        cmd.Parameters.AddWithValue("RESP", rb1.Text);
                        cmd.Parameters.AddWithValue("ID_JOGADOR", idJogador);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                    Pergunta3 p3 = new Pergunta3(idJogador);
                    p3.Show();
                }
            }
        }
    }
}
