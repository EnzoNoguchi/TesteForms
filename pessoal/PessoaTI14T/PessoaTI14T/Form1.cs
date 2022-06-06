using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI14T
{
    public partial class Form1 : Form
    {


        DAOPessoa pessoa;



        public Form1()
        {
            InitializeComponent();
            pessoa = new DAOPessoa();//abrindo a conexao com o banco de dados
        }//Fim do Construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }






        //============================================================== BOTÕES ===============================================================








        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //int codigo = Convert.ToInt32(textBox1.Text);//coletando o dado do campo codigo
           
                string tratamentoCPF = maskedTextBox1.Text.Replace(",", "");
                tratamentoCPF = tratamentoCPF.Replace("-", "");
                long cpf = Convert.ToInt64(tratamentoCPF);//coletando o dado do campo cpf
                string nome = textBox3.Text;//coletando o dado do campo nome
                string telefone = maskedTextBox2.Text;//coletando o dado do campo telefone
                string endereco = textBox5.Text;//coletando o dado do campo endereco

                //chamar o metodo de inserir que foi criado na classe DAOPessoa
                pessoa.Inserir(cpf, nome, telefone, endereco);//inserir ao banco de dados do formulario
            }catch(Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }//fim do botao cadastrar



        private void button2_Click(object sender, EventArgs e)
        {

        }//fim do botao Consultar



        private void button3_Click(object sender, EventArgs e)
        {

        }//fim do botao atualizar





        private void button4_Click(object sender, EventArgs e)
        {

        }//fim do botao excluir











        //============================================================== TEXT BOX ===============================================================





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//textbox de codigo

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//maskedbox de cpf

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }//text box de nome

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//masked box de telefone

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//text box de endreço

        private void label1_Click_1(object sender, EventArgs e)
        {

        }






        //=============================================================================================================================


    }//fim da classe
}//fim do projeto
