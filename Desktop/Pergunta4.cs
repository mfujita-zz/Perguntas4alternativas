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
    public partial class Pergunta4 : Form
    {
        public int idJogador;
        public Pergunta4(int jogador)
        {
            InitializeComponent();
            idJogador = jogador;
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
            using (SqlConnection conexao = new SqlConnection("Server=SAMSUNG-SERIE-9\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_Connection=Yes"))
            //using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("insert into tb_Perguntas (pergunta, resposta_correta, ID_JOGADOR) values (@perg, @resp, @ID_JOGADOR)", conexao))
                {
                    if (rb1.Checked)
                    {
                        cmd.Parameters.AddWithValue("perg", lblPergunta4.Text);
                        cmd.Parameters.AddWithValue("resp", rb1.Text);
                        cmd.Parameters.AddWithValue("ID_JOGADOR", idJogador);
                        conexao.Open();
                        cmd.ExecuteNonQuery(); 
                    }
                    Pergunta5 p5 = new Pergunta5(idJogador);
                    p5.ShowDialog();
                }
            }
        }
    }
}
