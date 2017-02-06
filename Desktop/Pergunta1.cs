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
    public partial class Pergunta1 : Form
    {
        public int idJogador;
        public Pergunta1(int jogador)
        {
            InitializeComponent();
            idJogador = jogador;
        }

        private void FormPergunta1_Load(object sender, EventArgs e)
        {
            lblPergunta1.Text = "As alternativa abaixo motivam as pessoas, mas uma delas não é apropriada. Marque aquela que não é listada no livro do SENAC";
            rb1.Text = "Entre na imagem e permita-se experimentar um sentimento de motivação total.";
            rb2.Text = "Torne essa sua imagem mais brilhante e mais definida.";
            rb3.Text = "Tome uma caixa de cerveja que goste."; // True
            rb4.Text = "Erga a cabeça e coloque os ombros para trás.";
        }

        private void btnResposta1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, id_jogador) values (@PERG, @RESP_CORR, @ID_JOgador)", conexao))
                {
                    if (rb3.Checked)
                    {
                        cmd.Parameters.AddWithValue("PERG", lblPergunta1.Text);
                        cmd.Parameters.AddWithValue("RESP_CORR", rb3.Text);
                        cmd.Parameters.AddWithValue("ID_JOGADOR", idJogador);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                    Pergunta2 p2 = new Pergunta2();
                    p2.Show();
                }
            }
        }
    }
}
