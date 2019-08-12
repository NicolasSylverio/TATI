namespace Proeficiencia.Presentation
{
    partial class ValidarArquivos
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
            this.dtgArquivos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioEnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValidacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuarioValidador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaminhoArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MensagemControle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.rdbValidar = new System.Windows.Forms.RadioButton();
            this.rdbValidados = new System.Windows.Forms.RadioButton();
            this.rdbBloqueados = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservação = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgArquivos
            // 
            this.dtgArquivos.AllowUserToAddRows = false;
            this.dtgArquivos.AllowUserToDeleteRows = false;
            this.dtgArquivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeDocumento,
            this.DataEnvio,
            this.IdUsuarioEnio,
            this.DataValidacao,
            this.IdUsuarioValidador,
            this.CaminhoArquivo,
            this.MensagemControle,
            this.Erro});
            this.dtgArquivos.Location = new System.Drawing.Point(30, 80);
            this.dtgArquivos.MultiSelect = false;
            this.dtgArquivos.Name = "dtgArquivos";
            this.dtgArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArquivos.Size = new System.Drawing.Size(710, 350);
            this.dtgArquivos.TabIndex = 0;
            this.dtgArquivos.TabStop = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // NomeDocumento
            // 
            this.NomeDocumento.DataPropertyName = "NomeDocumento";
            this.NomeDocumento.HeaderText = "Nome Documento";
            this.NomeDocumento.Name = "NomeDocumento";
            this.NomeDocumento.Width = 108;
            // 
            // DataEnvio
            // 
            this.DataEnvio.DataPropertyName = "DataEnvio";
            this.DataEnvio.HeaderText = "Data Envio";
            this.DataEnvio.Name = "DataEnvio";
            this.DataEnvio.Width = 78;
            // 
            // IdUsuarioEnio
            // 
            this.IdUsuarioEnio.DataPropertyName = "IdUsuarioEnvio";
            this.IdUsuarioEnio.HeaderText = "Usuário Envio";
            this.IdUsuarioEnio.Name = "IdUsuarioEnio";
            this.IdUsuarioEnio.Width = 90;
            // 
            // DataValidacao
            // 
            this.DataValidacao.DataPropertyName = "DataValidacao";
            this.DataValidacao.HeaderText = "Data Validação";
            this.DataValidacao.Name = "DataValidacao";
            this.DataValidacao.Width = 96;
            // 
            // IdUsuarioValidador
            // 
            this.IdUsuarioValidador.DataPropertyName = "IdUsuarioValidador";
            this.IdUsuarioValidador.HeaderText = "Usuário Autorizador";
            this.IdUsuarioValidador.Name = "IdUsuarioValidador";
            this.IdUsuarioValidador.Width = 114;
            // 
            // CaminhoArquivo
            // 
            this.CaminhoArquivo.DataPropertyName = "CaminhoArquivo";
            this.CaminhoArquivo.HeaderText = "Caminho Arquivo";
            this.CaminhoArquivo.Name = "CaminhoArquivo";
            this.CaminhoArquivo.Visible = false;
            this.CaminhoArquivo.Width = 103;
            // 
            // MensagemControle
            // 
            this.MensagemControle.DataPropertyName = "MensagemControle";
            this.MensagemControle.HeaderText = "Mensagem Controle";
            this.MensagemControle.Name = "MensagemControle";
            this.MensagemControle.Visible = false;
            this.MensagemControle.Width = 115;
            // 
            // Erro
            // 
            this.Erro.DataPropertyName = "Erro";
            this.Erro.HeaderText = "Bloqueado";
            this.Erro.Name = "Erro";
            this.Erro.Width = 83;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(650, 500);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(30, 500);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(90, 23);
            this.btnBaixar.TabIndex = 3;
            this.btnBaixar.Text = "&Baixar Arquivo";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.BtnBaixar_Click);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(140, 500);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(90, 23);
            this.btnAutorizar.TabIndex = 4;
            this.btnAutorizar.Text = "&Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.BtnAutorizar_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Location = new System.Drawing.Point(250, 500);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(90, 23);
            this.btnBloquear.TabIndex = 6;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.BtnBloquear_Click);
            // 
            // rdbValidar
            // 
            this.rdbValidar.AutoSize = true;
            this.rdbValidar.Location = new System.Drawing.Point(30, 35);
            this.rdbValidar.Name = "rdbValidar";
            this.rdbValidar.Size = new System.Drawing.Size(82, 17);
            this.rdbValidar.TabIndex = 8;
            this.rdbValidar.TabStop = true;
            this.rdbValidar.Text = "Para Validar";
            this.rdbValidar.UseVisualStyleBackColor = true;
            this.rdbValidar.Click += new System.EventHandler(this.RdbValidar_Click);
            // 
            // rdbValidados
            // 
            this.rdbValidados.AutoSize = true;
            this.rdbValidados.Location = new System.Drawing.Point(125, 35);
            this.rdbValidados.Name = "rdbValidados";
            this.rdbValidados.Size = new System.Drawing.Size(71, 17);
            this.rdbValidados.TabIndex = 9;
            this.rdbValidados.TabStop = true;
            this.rdbValidados.Text = "Validados";
            this.rdbValidados.UseVisualStyleBackColor = true;
            this.rdbValidados.Click += new System.EventHandler(this.RdbValidados_Click);
            // 
            // rdbBloqueados
            // 
            this.rdbBloqueados.AutoSize = true;
            this.rdbBloqueados.Location = new System.Drawing.Point(215, 35);
            this.rdbBloqueados.Name = "rdbBloqueados";
            this.rdbBloqueados.Size = new System.Drawing.Size(81, 17);
            this.rdbBloqueados.TabIndex = 10;
            this.rdbBloqueados.TabStop = true;
            this.rdbBloqueados.Text = "Bloqueados";
            this.rdbBloqueados.UseVisualStyleBackColor = true;
            this.rdbBloqueados.Click += new System.EventHandler(this.RdbBloqueados_Click);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(310, 35);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 11;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.Click += new System.EventHandler(this.RdbTodos_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(100, 440);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(600, 40);
            this.txtObservacao.TabIndex = 12;
            // 
            // lblObservação
            // 
            this.lblObservação.AutoSize = true;
            this.lblObservação.Location = new System.Drawing.Point(25, 440);
            this.lblObservação.Name = "lblObservação";
            this.lblObservação.Size = new System.Drawing.Size(68, 13);
            this.lblObservação.TabIndex = 13;
            this.lblObservação.Text = "Observação:";
            // 
            // ValidarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 541);
            this.ControlBox = false;
            this.Controls.Add(this.lblObservação);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.rdbBloqueados);
            this.Controls.Add(this.rdbValidados);
            this.Controls.Add(this.rdbValidar);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtgArquivos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidarArquivos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidarArquivos";
            this.Load += new System.EventHandler(this.ValidarArquivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgArquivos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.RadioButton rdbValidar;
        private System.Windows.Forms.RadioButton rdbValidados;
        private System.Windows.Forms.RadioButton rdbBloqueados;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioEnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataValidacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioValidador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaminhoArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MensagemControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erro;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservação;
    }
}