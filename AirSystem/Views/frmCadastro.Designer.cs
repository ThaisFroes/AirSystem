namespace AirSystem.Views
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.TituloNome = new System.Windows.Forms.Label();
            this.TituloSobrenome = new System.Windows.Forms.Label();
            this.TituloEndereco = new System.Windows.Forms.Label();
            this.TituloNascimento = new System.Windows.Forms.Label();
            this.TituloUsuario = new System.Windows.Forms.Label();
            this.TituloSenha = new System.Windows.Forms.Label();
            this.TituloConfirmarSenha = new System.Windows.Forms.Label();
            this.TituloNum = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(207, 384);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 45);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.Location = new System.Drawing.Point(600, 306);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(131, 22);
            this.checkBoxAdmin.TabIndex = 1;
            this.checkBoxAdmin.Text = "É administrador";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(586, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(63, 34);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(684, 222);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 34);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // TituloNome
            // 
            this.TituloNome.AutoSize = true;
            this.TituloNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNome.Location = new System.Drawing.Point(34, 66);
            this.TituloNome.Name = "TituloNome";
            this.TituloNome.Size = new System.Drawing.Size(45, 16);
            this.TituloNome.TabIndex = 4;
            this.TituloNome.Text = "Nome";
            // 
            // TituloSobrenome
            // 
            this.TituloSobrenome.AutoSize = true;
            this.TituloSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloSobrenome.Location = new System.Drawing.Point(34, 106);
            this.TituloSobrenome.Name = "TituloSobrenome";
            this.TituloSobrenome.Size = new System.Drawing.Size(79, 16);
            this.TituloSobrenome.TabIndex = 5;
            this.TituloSobrenome.Text = "Sobrenome";
            // 
            // TituloEndereco
            // 
            this.TituloEndereco.AutoSize = true;
            this.TituloEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEndereco.Location = new System.Drawing.Point(34, 150);
            this.TituloEndereco.Name = "TituloEndereco";
            this.TituloEndereco.Size = new System.Drawing.Size(67, 16);
            this.TituloEndereco.TabIndex = 6;
            this.TituloEndereco.Text = "Endereço";
            this.TituloEndereco.Click += new System.EventHandler(this.TituloEndereco_Click);
            // 
            // TituloNascimento
            // 
            this.TituloNascimento.AutoSize = true;
            this.TituloNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNascimento.Location = new System.Drawing.Point(32, 189);
            this.TituloNascimento.Name = "TituloNascimento";
            this.TituloNascimento.Size = new System.Drawing.Size(131, 16);
            this.TituloNascimento.TabIndex = 7;
            this.TituloNascimento.Text = "Data de Nascimento";
            this.TituloNascimento.Click += new System.EventHandler(this.TituloNascimento_Click);
            // 
            // TituloUsuario
            // 
            this.TituloUsuario.AutoSize = true;
            this.TituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloUsuario.Location = new System.Drawing.Point(34, 222);
            this.TituloUsuario.Name = "TituloUsuario";
            this.TituloUsuario.Size = new System.Drawing.Size(55, 16);
            this.TituloUsuario.TabIndex = 8;
            this.TituloUsuario.Text = "Usuário";
            // 
            // TituloSenha
            // 
            this.TituloSenha.AutoSize = true;
            this.TituloSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloSenha.Location = new System.Drawing.Point(32, 261);
            this.TituloSenha.Name = "TituloSenha";
            this.TituloSenha.Size = new System.Drawing.Size(47, 16);
            this.TituloSenha.TabIndex = 9;
            this.TituloSenha.Text = "Senha";
            // 
            // TituloConfirmarSenha
            // 
            this.TituloConfirmarSenha.AutoSize = true;
            this.TituloConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloConfirmarSenha.Location = new System.Drawing.Point(34, 306);
            this.TituloConfirmarSenha.Name = "TituloConfirmarSenha";
            this.TituloConfirmarSenha.Size = new System.Drawing.Size(105, 16);
            this.TituloConfirmarSenha.TabIndex = 10;
            this.TituloConfirmarSenha.Text = "Confirmar senha";
            // 
            // TituloNum
            // 
            this.TituloNum.AutoSize = true;
            this.TituloNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNum.Location = new System.Drawing.Point(392, 109);
            this.TituloNum.Name = "TituloNum";
            this.TituloNum.Size = new System.Drawing.Size(23, 16);
            this.TituloNum.TabIndex = 11;
            this.TituloNum.Text = "Nº";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(158, 66);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(215, 20);
            this.tbxNome.TabIndex = 12;
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Location = new System.Drawing.Point(158, 105);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(215, 20);
            this.tbxSobrenome.TabIndex = 13;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(158, 150);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(215, 20);
            this.tbxEndereco.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(158, 222);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(215, 20);
            this.tbxUsuario.TabIndex = 16;
            this.tbxUsuario.TextChanged += new System.EventHandler(this.tbxUsuario_TextChanged);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(158, 261);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(215, 20);
            this.tbxSenha.TabIndex = 17;
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(158, 306);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.PasswordChar = '*';
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(215, 20);
            this.tbxConfirmarSenha.TabIndex = 18;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(421, 105);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 20);
            this.tbxNumero.TabIndex = 19;
            this.tbxNumero.TextChanged += new System.EventHandler(this.tbxNumero_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxConfirmarSenha);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.TituloNum);
            this.Controls.Add(this.TituloConfirmarSenha);
            this.Controls.Add(this.TituloSenha);
            this.Controls.Add(this.TituloUsuario);
            this.Controls.Add(this.TituloNascimento);
            this.Controls.Add(this.TituloEndereco);
            this.Controls.Add(this.TituloSobrenome);
            this.Controls.Add(this.TituloNome);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCadastro";
            this.Text = "Novo Usuário - AirSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label TituloNome;
        private System.Windows.Forms.Label TituloSobrenome;
        private System.Windows.Forms.Label TituloEndereco;
        private System.Windows.Forms.Label TituloNascimento;
        private System.Windows.Forms.Label TituloUsuario;
        private System.Windows.Forms.Label TituloSenha;
        private System.Windows.Forms.Label TituloConfirmarSenha;
        private System.Windows.Forms.Label TituloNum;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxConfirmarSenha;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}