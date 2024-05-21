using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI20N
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo CPF
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do nome
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do telefone
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Endereço
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados do banco
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string telefone = textBox3.Text;
                string endereco = textBox4.Text;
                //Cadastrar
                MessageBox.Show(bd.inserir(cpf, nome, telefone, endereco));//Insere dados no BD
                                                                           //Limpar a tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do botao cadastrar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//THIS = Apontar esta janela e CLOSE = fechar
        }//Fim do botao cancelar
    }//Fim da classe
}//Fim do projeto
