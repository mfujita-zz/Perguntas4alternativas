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
    public partial class Pergunta5 : Form
    {
        public int idJogador;
        public Pergunta5(int jogador )
        {
            InitializeComponent();
            idJogador = jogador;
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
            //using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_connection=Yes"))
            using (SqlConnection conexao = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_Connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, ID_JOGADOR) values (@perg,@resp, @ID_JOGADOR)", conexao))
                {
                    if (rb2.Checked)
                    {
                        cmd.Parameters.AddWithValue("perg", lblPergunta5.Text);
                        cmd.Parameters.AddWithValue("resp", rb2.Text);
                        cmd.Parameters.AddWithValue("ID_JOGADOR", idJogador);
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Você acertou  respostas!", "Resultados");
                    Application.Exit();
                }
            }
        }
    }
}
