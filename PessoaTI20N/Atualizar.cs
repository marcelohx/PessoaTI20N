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
    public partial class Atualizar : Form
    {
        DAO bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do CPF

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do dado

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                long cpf = Convert.ToInt64(textBox1.Text);
                string campo = textBox3.Text;
                string dado = textBox2.Text;
                //Atualizar dados
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));
                //limpar os campos
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do botao atualizar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botao Cancelar
    }//Fim do metodo
}//Fim do projeto
