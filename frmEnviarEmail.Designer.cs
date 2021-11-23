
namespace EnviarEmail
{
    partial class frmEnviarEmail
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.lblCaminhoNomeArquivo = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLimpar);
            this.panel1.Controls.Add(this.lblCaminhoNomeArquivo);
            this.panel1.Controls.Add(this.BtnEnviar);
            this.panel1.Controls.Add(this.txtMensagem);
            this.panel1.Controls.Add(this.txtAssunto);
            this.panel1.Controls.Add(this.txtDestinatario);
            this.panel1.Controls.Add(this.txtRemetente);
            this.panel1.Controls.Add(this.lblAnexo);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Controls.Add(this.lblAssunto);
            this.panel1.Controls.Add(this.lblDestinatario);
            this.panel1.Controls.Add(this.lblRemetente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 403);
            this.panel1.TabIndex = 5;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(192, 373);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(57, 23);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // lblCaminhoNomeArquivo
            // 
            this.lblCaminhoNomeArquivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaminhoNomeArquivo.Location = new System.Drawing.Point(58, 329);
            this.lblCaminhoNomeArquivo.Name = "lblCaminhoNomeArquivo";
            this.lblCaminhoNomeArquivo.Size = new System.Drawing.Size(452, 23);
            this.lblCaminhoNomeArquivo.TabIndex = 4;
            this.lblCaminhoNomeArquivo.Click += new System.EventHandler(this.lblCaminhoNomeArquivo_Click);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(255, 373);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 5;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(15, 197);
            this.txtMensagem.MaxLength = 5000;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(495, 107);
            this.txtMensagem.TabIndex = 3;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(15, 141);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(495, 20);
            this.txtAssunto.TabIndex = 2;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(15, 83);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(495, 20);
            this.txtDestinatario.TabIndex = 1;
            // 
            // txtRemetente
            // 
            this.txtRemetente.Location = new System.Drawing.Point(15, 37);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(495, 20);
            this.txtRemetente.TabIndex = 0;
            // 
            // lblAnexo
            // 
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.Location = new System.Drawing.Point(12, 334);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(40, 13);
            this.lblAnexo.TabIndex = 9;
            this.lblAnexo.Text = "Anexo:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 183);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(62, 13);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(12, 125);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(12, 67);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(66, 13);
            this.lblDestinatario.TabIndex = 6;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(12, 20);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(62, 13);
            this.lblRemetente.TabIndex = 5;
            this.lblRemetente.Text = "Remetente:";
            // 
            // frmEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnviarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar E-mail";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEnviarEmail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label lblCaminhoNomeArquivo;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

