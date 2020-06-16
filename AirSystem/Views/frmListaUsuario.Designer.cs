namespace AirSystem.Views
{
    partial class frmListaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaUsuario));
            this.TituloDadosUsuario = new System.Windows.Forms.Label();
            this.TituloNome = new System.Windows.Forms.Label();
            this.TituloSobrenome = new System.Windows.Forms.Label();
            this.TituloEndereco = new System.Windows.Forms.Label();
            this.tituloNascimento = new System.Windows.Forms.Label();
            this.TituloUsuario = new System.Windows.Forms.Label();
            this.TituloSenha = new System.Windows.Forms.Label();
            this.TituloConfirmarSenha = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.TituloNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBox1nome = new System.Windows.Forms.TextBox();
            this.btnID = new System.Windows.Forms.Button();
            this.button1Nome = new System.Windows.Forms.Button();
            this.button1Sobrenome = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloDadosUsuario
            // 
            this.TituloDadosUsuario.AutoSize = true;
            this.TituloDadosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloDadosUsuario.Location = new System.Drawing.Point(596, 24);
            this.TituloDadosUsuario.Name = "TituloDadosUsuario";
            this.TituloDadosUsuario.Size = new System.Drawing.Size(134, 20);
            this.TituloDadosUsuario.TabIndex = 0;
            this.TituloDadosUsuario.Text = "Dados do usuário";
            // 
            // TituloNome
            // 
            this.TituloNome.AutoSize = true;
            this.TituloNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNome.Location = new System.Drawing.Point(443, 172);
            this.TituloNome.Name = "TituloNome";
            this.TituloNome.Size = new System.Drawing.Size(45, 16);
            this.TituloNome.TabIndex = 1;
            this.TituloNome.Text = "Nome";
            // 
            // TituloSobrenome
            // 
            this.TituloSobrenome.AutoSize = true;
            this.TituloSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloSobrenome.Location = new System.Drawing.Point(443, 198);
            this.TituloSobrenome.Name = "TituloSobrenome";
            this.TituloSobrenome.Size = new System.Drawing.Size(79, 16);
            this.TituloSobrenome.TabIndex = 2;
            this.TituloSobrenome.Text = "Sobrenome";
            // 
            // TituloEndereco
            // 
            this.TituloEndereco.AutoSize = true;
            this.TituloEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEndereco.Location = new System.Drawing.Point(443, 224);
            this.TituloEndereco.Name = "TituloEndereco";
            this.TituloEndereco.Size = new System.Drawing.Size(67, 16);
            this.TituloEndereco.TabIndex = 3;
            this.TituloEndereco.Text = "Endereço";
            // 
            // tituloNascimento
            // 
            this.tituloNascimento.AutoSize = true;
            this.tituloNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloNascimento.Location = new System.Drawing.Point(443, 276);
            this.tituloNascimento.Name = "tituloNascimento";
            this.tituloNascimento.Size = new System.Drawing.Size(128, 16);
            this.tituloNascimento.TabIndex = 4;
            this.tituloNascimento.Text = "Data de nascimento";
            this.tituloNascimento.Click += new System.EventHandler(this.tituloNascimento_Click);
            // 
            // TituloUsuario
            // 
            this.TituloUsuario.AutoSize = true;
            this.TituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloUsuario.Location = new System.Drawing.Point(443, 302);
            this.TituloUsuario.Name = "TituloUsuario";
            this.TituloUsuario.Size = new System.Drawing.Size(55, 16);
            this.TituloUsuario.TabIndex = 5;
            this.TituloUsuario.Text = "Usuário";
            // 
            // TituloSenha
            // 
            this.TituloSenha.AutoSize = true;
            this.TituloSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloSenha.Location = new System.Drawing.Point(443, 328);
            this.TituloSenha.Name = "TituloSenha";
            this.TituloSenha.Size = new System.Drawing.Size(47, 16);
            this.TituloSenha.TabIndex = 6;
            this.TituloSenha.Text = "Senha";
            // 
            // TituloConfirmarSenha
            // 
            this.TituloConfirmarSenha.AutoSize = true;
            this.TituloConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloConfirmarSenha.Location = new System.Drawing.Point(443, 353);
            this.TituloConfirmarSenha.Name = "TituloConfirmarSenha";
            this.TituloConfirmarSenha.Size = new System.Drawing.Size(105, 16);
            this.TituloConfirmarSenha.TabIndex = 7;
            this.TituloConfirmarSenha.Text = "Confirmar senha";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(573, 168);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(573, 194);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(200, 20);
            this.textBoxSobrenome.TabIndex = 9;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(573, 220);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(200, 20);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(573, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(573, 298);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(573, 324);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(200, 20);
            this.textBoxSenha.TabIndex = 13;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(573, 349);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.PasswordChar = '*';
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(200, 20);
            this.textBoxConfirmarSenha.TabIndex = 14;
            this.textBoxConfirmarSenha.TextChanged += new System.EventHandler(this.textBoxConfirmarSenha_TextChanged);
            // 
            // TituloNum
            // 
            this.TituloNum.AutoSize = true;
            this.TituloNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloNum.Location = new System.Drawing.Point(443, 250);
            this.TituloNum.Name = "TituloNum";
            this.TituloNum.Size = new System.Drawing.Size(22, 16);
            this.TituloNum.TabIndex = 15;
            this.TituloNum.Text = "N°";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(573, 246);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(200, 20);
            this.textBoxNum.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(573, 64);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 34);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(673, 64);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 34);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(455, 412);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 26);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(536, 412);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 26);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(617, 412);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 26);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeleta
            // 
            this.btnDeleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleta.Location = new System.Drawing.Point(698, 412);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(75, 26);
            this.btnDeleta.TabIndex = 23;
            this.btnDeleta.Text = "Deletar";
            this.btnDeleta.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 389);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 16);
            this.labelNome.TabIndex = 24;
            this.labelNome.Text = "Nome";
            // 
            // textBox1nome
            // 
            this.textBox1nome.Location = new System.Drawing.Point(64, 389);
            this.textBox1nome.Name = "textBox1nome";
            this.textBox1nome.Size = new System.Drawing.Size(221, 20);
            this.textBox1nome.TabIndex = 25;
            this.textBox1nome.TextChanged += new System.EventHandler(this.textBox1nome_TextChanged);
            // 
            // btnID
            // 
            this.btnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(-2, -1);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(112, 23);
            this.btnID.TabIndex = 26;
            this.btnID.Text = "ID";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // button1Nome
            // 
            this.button1Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Nome.Location = new System.Drawing.Point(108, -1);
            this.button1Nome.Name = "button1Nome";
            this.button1Nome.Size = new System.Drawing.Size(120, 23);
            this.button1Nome.TabIndex = 27;
            this.button1Nome.Text = "Nome";
            this.button1Nome.UseVisualStyleBackColor = true;
            // 
            // button1Sobrenome
            // 
            this.button1Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Sobrenome.Location = new System.Drawing.Point(227, -1);
            this.button1Sobrenome.Name = "button1Sobrenome";
            this.button1Sobrenome.Size = new System.Drawing.Size(125, 23);
            this.button1Sobrenome.TabIndex = 28;
            this.button1Sobrenome.Text = "Sobrenome";
            this.button1Sobrenome.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(-2, 24);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(354, 345);
            this.dgvUsuarios.TabIndex = 29;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(359, 355);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 30;
            this.lblContador.Text = "label1";
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.button1Sobrenome);
            this.Controls.Add(this.button1Nome);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.textBox1nome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.TituloNum);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.TituloConfirmarSenha);
            this.Controls.Add(this.TituloSenha);
            this.Controls.Add(this.TituloUsuario);
            this.Controls.Add(this.tituloNascimento);
            this.Controls.Add(this.TituloEndereco);
            this.Controls.Add(this.TituloSobrenome);
            this.Controls.Add(this.TituloNome);
            this.Controls.Add(this.TituloDadosUsuario);
            this.Name = "frmListaUsuario";
            this.Text = "Listar Usuarios - Air System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloDadosUsuario;
        private System.Windows.Forms.Label TituloNome;
        private System.Windows.Forms.Label TituloSobrenome;
        private System.Windows.Forms.Label TituloEndereco;
        private System.Windows.Forms.Label tituloNascimento;
        private System.Windows.Forms.Label TituloUsuario;
        private System.Windows.Forms.Label TituloSenha;
        private System.Windows.Forms.Label TituloConfirmarSenha;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label TituloNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBox1nome;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button button1Nome;
        private System.Windows.Forms.Button button1Sobrenome;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblContador;
    }
}