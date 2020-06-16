using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmListaUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        
        public frmListaUsuario()
        {
            InitializeComponent();
        }
        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            carregaLista();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dgvUsuarios.Rows[e.RowIndex];
            //guarda nas variáveis os conteúdos das células
            int Id = Convert.ToInt32(linha.Cells[0].Value.ToString());
            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();
            string endereco = linha.Cells[3].Value.ToString();
            int numero = Convert.ToInt32(linha.Cells[4].Value.ToString());
            DateTime nascimento = Convert.ToDateTime(linha.Cells[5].Value.ToString());
            string uuarios = linha.Cells[6].Value.ToString();
            string senha = linha.Cells[7].Value.ToString();
            string confirmarSenha = linha.Cells[8].Value.ToString();
            //esse campo precisa ser convertido pois é numérico
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            Usuario usuario = new Usuario
            {
                
                Nome = nome,
                Sobrenome = sobrenome,
                Endereco = endereco,
                Numero = numero,
                Nascimento = nascimento,
                Usuarios = uuarios,
                Senha = senha,
                ConfirmarSenha = confirmarSenha

            };
            //Chama o formulário de cadastro passando a classe usuario

            new frmCadastro(usuario).ShowDialog();
            //chama o método para carregar o datagrid
            carregaLista();
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvUsuarios.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }
        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dgvUsuarios.RowCount} itens de {repository.buscarTodos().Count}";
        }

        private void textBox1nome_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;

            dgvUsuarios.DataSource = repository.buscarTodos().FindAll(x =>
                x.Nome.ToUpper().Contains(textBox1nome.Text.ToUpper()) ||
                x.Sobrenome.ToUpper().Contains(textBox1nome.Text.ToUpper()) ||
                x.ID.ToUpper().Contains(textBox1nome.Text.ToUpper())
            );

            alterarContador();

        }
        private void tituloNascimento_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void btnID_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
