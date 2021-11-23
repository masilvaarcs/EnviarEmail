using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace EnviarEmail
{
    public partial class frmEnviarEmail : Form
    {
        public frmEnviarEmail()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void EnviarEmail()
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("masilva.arcs@gmail.com", "qgfmayjkjndeeuat"); //Prg_prg567bo13579

            MailMessage mail = new MailMessage
            {
                Sender = new System.Net.Mail.MailAddress("masilva.arcs@gmail.com", "ENCODE-Enviador de E-mails"),
                From = new MailAddress(txtRemetente.Text.Trim(),  "Encode Soluções")
            };
            mail.To.Add(new MailAddress(txtDestinatario.Text.Trim(), "Destinatário"));

            mail.Subject = txtAssunto.Text.Trim();

            mail.Body = txtMensagem.Text.Trim();

            if (lblCaminhoNomeArquivo.Text != string.Empty)
            {
                try
                {
                    mail.Attachments.Add(new Attachment(lblCaminhoNomeArquivo.Text));
                }
                catch (System.Exception erro)
                {

                    MessageBox.Show("Erro ao anexar o arquivo ( " + erro.Source + " - " + erro.Message + ")",
                                    "Erro para enviar o e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnEnviar.Enabled = true;
                    return;
                }
            }

            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.High;

            DialogResult confirmarEnvio = MessageBox.Show("O email será enviado... Confirma?", "Envio de E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmarEnvio == DialogResult.No)
            {
                return;
            }
            
            try
            {
                client.Send(mail);
            }
            catch (System.Exception erro)
            {
                //trata erro
                MessageBox.Show("Erro ao conectar e enviar o e-mail ( " + erro.Source + " - " + erro.Message + ")",
                                "Erro enviando e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnEnviar.Enabled = true;
                return;
            }
            finally
            {
                MessageBox.Show("E-mail enviado com Sucesso!", "Envio de E-mails", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEnviar.Enabled=false;
                LimparCampos();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {

            DialogResult limparCampos;
            if (BtnEnviar.Enabled)
            {
                limparCampos = MessageBox.Show("Todos os campos serão reiniciados, confirma?", "Limpeza de Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                limparCampos = DialogResult.Yes;
            }

            if (limparCampos == DialogResult.Yes)
            {
                txtRemetente.Text = string.Empty;
                txtDestinatario.Text = string.Empty;
                txtAssunto.Text = string.Empty;
                txtMensagem.Text = string.Empty;
                lblCaminhoNomeArquivo.Text = string.Empty;
                BtnEnviar.Enabled = true;
                txtRemetente.Focus();
            }
        }

        private void lblCaminhoNomeArquivo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCaminhoNomeArquivo.Text))
            {
                DialogResult trocaPasta = MessageBox.Show("O caminho já foi configurado anteriormente. Deseja mesmo selecionar um novo??", "Configurando Pasta de Currículos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (trocaPasta != DialogResult.Yes)
                    return;
            }
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblCaminhoNomeArquivo.Text = dialog.FileName;
                Properties.Settings.Default.caminhoArq = lblCaminhoNomeArquivo.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void frmEnviarEmail_Load(object sender, EventArgs e)
        {
            lblCaminhoNomeArquivo.Text = Properties.Settings.Default.caminhoArq;
        }
    }
}
