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
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo excluir

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                long cpf = Convert.ToInt64(textBox1.Text);//Coletando o cpf
                                                          //chamar o metodo
                MessageBox.Show(bd.Excluir(cpf, "pessoa"));
                //limpar o campo
                textBox1.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do botao excluir

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botao cancelar
    }//Fim da classe
}//Fim do projeto
