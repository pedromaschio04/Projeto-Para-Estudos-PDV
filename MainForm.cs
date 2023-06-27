using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoasForm pf = new PessoasForm();
            pf.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void mostrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario = '" + Usuario.login + "'\n tipo = '" + Usuario.tipo + "'");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Usuario.tipo != 'A')
            {
                cadastroToolStripMenuItem.Enabled = false;  
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
