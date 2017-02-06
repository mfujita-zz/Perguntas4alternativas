using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Desktop
{
    public partial class frm_inicial : Form
    {
        public frm_inicial()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("Digite seu nome"))
            {
                MessageBox.Show("Por favor digite seu nome", "Campo não preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection conexao = new SqlConnection("Server=AME0556327W10-1\\SQLEXPRESS; Database=db_PerguntasRespostas; Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_jogador(nome) OUTPUT INSERTED.id_jogador values (@NOME)", conexao))
                    {                        
                        comando.Parameters.AddWithValue("NOME", txtNome.Text);
                        conexao.Open();
                        if (comando.ExecuteNonQuery() == 1)
                        {
                            int idJogador = (int)comando.ExecuteScalar();                            
                            MessageBox.Show("Olá, " + txtNome.Text + ". Vamos começar.", "Boas vindas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Pergunta1 p1 = new Pergunta1(idJogador);
                            p1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Erro no procedimento da conexão.");
                        }
                    }
                }
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";            
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
                txtNome.Text = "Digite seu nome";
        }
    }
}
