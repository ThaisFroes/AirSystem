using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Taskool";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmPrincipal().ShowDialog();

            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //para fechar o form principal
                this.Close();
                //para sair da aplicação
                Application.Exit();
            }
        }

        private void iblRelogio_Tick(object sender, EventArgs e)
        {
            iblRelogio.Text = DateTime.Now.ToString("HH:mm:fff");
        }
    }
}
