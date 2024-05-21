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
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();

            ConfigurarGrid();//Estruturar o Grid
            NomesDados();//Dar os nomes as colunas
            bd.PreencherVetor();//Consulto o banco de dados
            AdicionarDados();//Inserir linhas na tela
        }//Fim do construtor

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do dataGrid
        public void NomesDados()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }//Fim do metodo
        public void AdicionarDados()
        {
            for(int i=0;i < bd.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereco[i]); 
            }
        }//Fim do metodo
        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//usuario não adiciona linhas
            dataGridView1 .AllowUserToDeleteRows = false;//Usuario não deleta linhas
            dataGridView1.AllowUserToResizeColumns = false;//Usuario não adiciona colunas
            dataGridView1.AllowUserToResizeRows = false;//usuario não modifica linhas
            dataGridView1.ColumnCount = 4;
        }//Fim do metodo
    }//Fim da classe
}//Fim do projeto
