namespace Proeficiencia.Presentation
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarArquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarArquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunoToolStripMenuItem,
            this.arquivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            this.cadastroDeAlunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraToolStripMenuItem,
            this.manutençãoAlunosToolStripMenuItem,
            this.consultaAlunosToolStripMenuItem});
            this.cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            this.cadastroDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadastroDeAlunoToolStripMenuItem.Text = "Alunos";
            // 
            // cadastraToolStripMenuItem
            // 
            this.cadastraToolStripMenuItem.Name = "cadastraToolStripMenuItem";
            this.cadastraToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastraToolStripMenuItem.Text = "Cadastro";
            this.cadastraToolStripMenuItem.Click += new System.EventHandler(this.CadastraToolStripMenuItem_Click);
            // 
            // manutençãoAlunosToolStripMenuItem
            // 
            this.manutençãoAlunosToolStripMenuItem.Name = "manutençãoAlunosToolStripMenuItem";
            this.manutençãoAlunosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.manutençãoAlunosToolStripMenuItem.Text = "Manutenção Alunos";
            this.manutençãoAlunosToolStripMenuItem.Click += new System.EventHandler(this.ManutençãoAlunosToolStripMenuItem_Click);
            // 
            // consultaAlunosToolStripMenuItem
            // 
            this.consultaAlunosToolStripMenuItem.Name = "consultaAlunosToolStripMenuItem";
            this.consultaAlunosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaAlunosToolStripMenuItem.Text = "Consulta Alunos";
            this.consultaAlunosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaAlunosToolStripMenuItem_Click);
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarArquivosToolStripMenuItem,
            this.validarArquivosToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // enviarArquivosToolStripMenuItem
            // 
            this.enviarArquivosToolStripMenuItem.Name = "enviarArquivosToolStripMenuItem";
            this.enviarArquivosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.enviarArquivosToolStripMenuItem.Text = "Enviar Arquivos";
            this.enviarArquivosToolStripMenuItem.Click += new System.EventHandler(this.EnviarArquivosToolStripMenuItem_Click);
            // 
            // validarArquivosToolStripMenuItem
            // 
            this.validarArquivosToolStripMenuItem.Name = "validarArquivosToolStripMenuItem";
            this.validarArquivosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.validarArquivosToolStripMenuItem.Text = "Validar Arquivos";
            this.validarArquivosToolStripMenuItem.Click += new System.EventHandler(this.ValidarArquivosToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultarToolStripMenuItem.Text = "Consulta Arquivos";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.ConsultarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarArquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarArquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAlunosToolStripMenuItem;
    }
}