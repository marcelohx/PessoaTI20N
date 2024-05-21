using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//importar o MySQL

namespace PessoaTI20N
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=empresaTI20N;Uid=root;password=");
            try
            {
                conexao.Open();//abrir a conexão
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do construtor
        public string inserir(long cpf, string nome, string telefone, string endereco)
        {
            string inserir = $"Insert into pessoa(cpf, nome, telefone, endereco) values" + $"('{cpf}','{nome}','{telefone}','{endereco}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;
        }//Fim do metodo
        public void PreencherVetor()
        {
            string query = "select * from pessoa";
            //instanciar
            this.cpf = new long[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];
            

            //Fazer o comando de seleção do banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Leitor do banco
            MySqlDataReader leitura = sql.ExecuteReader();
            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cpf[i] = Convert.ToInt64(leitura["cpf"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;//Percorrer o vetor
                contador++;//Contar quantos dados eu tenho
            }//Fim do while

            //Encerro a comunicação com o software
            leitura.Close();
        }//Fim do preencher
        //Criar metodo para retornar o contador
        public int QuantidadeDados()
        {
            return contador;
        }//Fim do quantidade de dados
        public string Atualizar(long cpf, string nomeTabela,string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado!";
            return resultado;
        }//Fim do metodo
        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluído!";
            return resultado;
        }//Fim do excluir
    }//Fim da classe
}//Fim do projeto
