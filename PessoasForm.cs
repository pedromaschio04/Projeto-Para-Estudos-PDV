using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class PessoasForm : Form
    {
        MySqlCommand comando = new MySqlCommand(Database.sql, Database.conexao);
        int inativo = 0;
        string nome;
        string cpf;
        string rg;
        string genero;
        string civil;
        string email;
        string profissao;
        string nacionalide;
        string tel;
        string cel;
        int zap;
        string endereco;
        string numero;
        string comp;
        string uf;
        string cep;
        string bairro;
        string cidade;
        string obs;

        public void autoPreencheCampos()
        {
            nomeTextBox.Text = "Joca";
            cpfTextBox.Text = "46782176485";
            rgTextBox.Text = "674567431";
            generoComboBox.Text = "Masculino";
            civilComboBox.Text = "Casado";
            emailTextBox.Text = "joca@gmail.com";
            profissaoTextBox.Text = "Suporte";
            nacionalidadeTextBox.Text = "Brasileiro";
            telefoneMaskedTextBox.Text = "17322456";
            celularMaskedTextBox.Text = "17997146537";
            EnderecoTextBox.Text = "Rua Minas";
            numeroTextBox.Text = "69";
            complementoTextBox.Text = "apt 201";
            ufComboBox.Text = "SP";
            cepMaskedTextBox.Text = "15800250";
            bairroTextBox.Text = "Centro";
            cidadeTextBox.Text = "Catanduva";
            obsRichTextBox.Text = "--EXEMPLO--";
        }
        public void limparCampos()
        {
            nomeTextBox.Text = "";
            cpfTextBox.Text = "";
            rgTextBox.Text = "";
            generoComboBox.Text = "";
            civilComboBox.Text = "";
            emailTextBox.Text = "";
            profissaoTextBox.Text = "";
            nacionalidadeTextBox.Text = "";
            telefoneMaskedTextBox.Text = "";
            celularMaskedTextBox.Text = "";
            EnderecoTextBox.Text = "";
            numeroTextBox.Text = "";
            complementoTextBox.Text = "";
            ufComboBox.Text = "";
            cepMaskedTextBox.Text = "";
            bairroTextBox.Text = "";
            cidadeTextBox.Text = "";
            obsRichTextBox.Text = "";
        }
        public void carregaValores()
        {
            nome = nomeTextBox.Text;
            cpf = cpfTextBox.Text;
            rg = rgTextBox.Text;
            genero = generoComboBox.SelectedItem.ToString();
            civil = civilComboBox.SelectedItem.ToString();
            email = emailTextBox.Text;
            if (inativoCheckBox.Checked)
            {
                inativo = 1;
            }
            else
            {
                inativo = 0;
            }
            profissao = profissaoTextBox.Text;
            nacionalide = nacionalidadeTextBox.Text;
            tel = telefoneMaskedTextBox.Text;
            cel = celularMaskedTextBox.Text;
            if (zapCheckBox.Checked)
            {
                zap = 1;
            }
            else
            {
                zap = 0;
            }
            endereco = EnderecoTextBox.Text;
            numero = numeroTextBox.Text;
            comp = complementoTextBox.Text;
            uf = ufComboBox.Text;
            cep = cepMaskedTextBox.Text;
            bairro = bairroTextBox.Text;
            cidade = cidadeTextBox.Text;
            obs = obsRichTextBox.Text;

        }

        public void excluir()
        {
            try
            {
                Database.conexao.Open();
                Database.sql = "delete from pessoas where pessoa_id = " + Convert.ToInt32(codTextBox.Text) + "";
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Deu Bom");
                Database.conexao.Close();
                limparCampos();
            }

        }
        public PessoasForm()
        {
            InitializeComponent();
        }

        private void adicionarbutton_Click(object sender, EventArgs e)
        {
            carregaValores();
            try
            {
                Database.conexao.Open();
                Database.sql = "insert into pessoas(nome,inativo,cpf,rg,genero,nascimento,estado_civil,profissao,nacionalidade,telefone,celular,wp" +
                               ",email,endereco,numero,complemento,bairro,cidade,uf,cep,observacoes,data_cadastro) " +
                               "Values('" + nome + "'," + inativo + ",'" + cpf + "','" + rg + "','" + genero + "'," + nascimentoDateTimePicker.Text + ",'" + civil + "'," +
                               "'" + profissao + "','" + tel + "','" + cel + "'," + inativo + ",'" + email + "','" + endereco + "','" + endereco + "','" + numero + "','" + comp + "'," +
                               "'" + bairro + "','" + cidade + "','" + uf + "','" + cep + "','" + obs + "',current_date)";
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Deu Bom");
                Database.conexao.Close();
                limparCampos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autoPreencheCampos();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            excluir();
        }
    }
}
