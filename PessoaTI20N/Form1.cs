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
    public partial class Menu : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Menu()
        {
            InitializeComponent();
            cad = new Cadastrar();
            
            atu = new Atualizar();
            exc = new Excluir();
        }//fim do Construtor 

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//fim do botao cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            con = new Consultar();//Consultas atualizadas
            con.ShowDialog();
        }//fim do botao consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//fim do botao atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//fim do botao excluir
    }//fim da classe
}//fim do projeto
