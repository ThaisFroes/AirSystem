using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AirSystem.Repositories;

namespace AirSystem.Views
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;

        public frmCadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.usuario = usuario;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                tbxNome.Text = usuario.Nome;
                tbxSobrenome.Text = usuario.Sobrenome;
                tbxEndereco.Text = usuario.Endereco;
                tbxUsuario.Text = usuario.usuario;
                tbxSenha.Text = usuario.Senha;
                tbxConfirmarSenha.Text = usuario.ConfirmarSenha;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        Nome = tbxNome.Text,
                        Sobrenome = tbxSobrenome.Text,
                        Endereco = tbxEndereco.Text,
                        usuario = tbxUsuario.Text,
                        Senha = "1234",
                        ConfirmarSenha = tbxConfirmarSenha.Text
                    };

                    repository.adicionar(usuario);
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                else
                {
                    this.usuario.Nome = tbxNome.Text;
                    this.usuario.Sobrenome = tbxSobrenome.Text;
                    this.usuario.Endereco = tbxEndereco.Text;
                    this.usuario.usuario = tbxUsuario.Text;
                    this.usuario.Senha = tbxSenha.Text;
                    this.usuario.ConfirmarSenha = tbxConfirmarSenha.Text;

                    repository.editar(usuario);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
        bool isValidUsuario;
        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            //cria um padrão regex
            string pattern = "[a-z]{3,}[.][a-z]{3,}[@][a-z]{3,}[.][a-z]{2,3}";
            //seta uma propriedade com a verificação do regex
            isValidUsuario = Regex.IsMatch(tbxUsuario.Text, pattern);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de Imagens(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void tbxNumero_TextChanged(object sender, EventArgs e)
        {

        }
        private void TituloEndereco_Click(object sender, EventArgs e)
        {

        }

        private void TituloNascimento_Click(object sender, EventArgs e)
        {

        }

        
    }
}
