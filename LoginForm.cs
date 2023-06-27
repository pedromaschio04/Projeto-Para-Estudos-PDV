using MySql.Data.MySqlClient;

namespace ProjetoFinal
{
    public partial class LoginForm : Form
    {
        string mensagem;
        bool mostrarSenha = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        public int checaLogin(string user, string senha)
        {
            try
            {
                Database.sql = "select * from usuarios where login ='" + loginTextBox.Text + "' and senha = '" + senhaTextBox.Text + "'";
                MySqlCommand comando = new MySqlCommand(Database.sql, Database.conexao);
                Database.conexao.Open();
                MySqlDataReader rd = comando.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    Usuario.login = rd.GetString(2);
                    Usuario.tipo = rd.GetChar(5);
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.conexao.Close();
            }

            return 0;
        }

        private void logarButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "" || senhaTextBox.Text == "")
            {
                if (loginTextBox.Text == "" && senhaTextBox.Text != "")
                {

                    mensagem = "Preencha o campo de Login!!";
                    MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginTextBox.Focus();

                }

                if (senhaTextBox.Text == "" && loginTextBox.Text != "")
                {

                    mensagem = "Preencha o campo de senha!!";
                    MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    senhaTextBox.Focus();

                }
                if (loginTextBox.Text == "" && senhaTextBox.Text == "")
                {
                    mensagem = "Preencha os campos de login e senha!!";
                    MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (loginTextBox.Text != "" && senhaTextBox.Text != "")
            {
                if (checaLogin(loginTextBox.Text, senhaTextBox.Text) == 1)
                {
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.ShowDialog();
                    loginTextBox.Text = "";
                    senhaTextBox.Text = "";
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (mostrarSenha == false)
            {
                senhaTextBox.PasswordChar = '*';
            }

        }

        private void mostrarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarCheckBox.Checked)
            {
                senhaTextBox.PasswordChar = default;
                mostrarSenha = true;
            }
            else
            {
                senhaTextBox.PasswordChar = '*';
                mostrarSenha = false;
            }

        }

        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            senhaTextBox.Focus();
        }

        private void senhaTextBox_Leave(object sender, EventArgs e)
        {
            logarButton.Focus();
        }
    }
}