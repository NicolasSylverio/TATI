namespace Proeficiencia.Presentation
{
    partial class ConsultaAlunos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRa = new System.Windows.Forms.MaskedTextBox();
            this.rdbRa = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRa);
            this.groupBox1.Controls.Add(this.rdbRa);
            this.groupBox1.Controls.Add(this.rdbNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Aluno";
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(330, 40);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(147, 20);
            this.txtRa.TabIndex = 4;
            // 
            // rdbRa
            // 
            this.rdbRa.AutoSize = true;
            this.rdbRa.Location = new System.Drawing.Point(235, 40);
            this.rdbRa.Name = "rdbRa";
            this.rdbRa.Size = new System.Drawing.Size(94, 17);
            this.rdbRa.TabIndex = 3;
            this.rdbRa.TabStop = true;
            this.rdbRa.Text = "Registro Aluno";
            this.rdbRa.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(10, 40);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(510, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(130, 25);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(30, 140);
            this.dgvAluno.MultiSelect = false;
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(670, 290);
            this.dgvAluno.TabIndex = 6;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(30, 450);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(580, 450);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ConsultaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Alunos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbRa;
        private System.Windows.Forms.MaskedTextBox txtRa;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
    }
}