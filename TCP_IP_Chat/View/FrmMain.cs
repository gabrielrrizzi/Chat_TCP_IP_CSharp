using MaterialSkin;
using MaterialSkin.Controls;
using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_IP_Chat.Controller;
using TCP_IP_Chat.ViewController;


namespace TCP_IP_Chat
{
    public partial class FrmMain : MaterialForm
    {
        SimpleTcpClient client;
        string nickname = "";
        public FrmMain()
        {
            InitializeComponent();
            AbrirLogin();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            ControlForms();
        }
        private void Events_DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"{Encoding.UTF8.GetString(e.Data)}";
            });
        }

        private void Events_Disconnected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"Você foi desconectado do servidor.{Environment.NewLine}";
            });
        }

        private void Events_Connected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"Conectado ao servidor.{Environment.NewLine}";
            });
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Gray;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(424242);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            cmsOptions.Show(System.Windows.Forms.Cursor.Position);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desconectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            pbConexao.Image = TCP_IP_Chat.Properties.Resources.icons8_disconnected;
        }

        private void trocarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirLogin();
        }

        private void limparConversaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = "";
        }

        private void cmsOptions_Opening(object sender, CancelEventArgs e)
        {
            if (client != null)
            {
                if (client.IsConnected)
                {
                    ControleDesconectar(true);
                }
                else
                {
                    ControleDesconectar(false);
                }
            }
            else
            {
                ControleDesconectar(false);
            }
        }
        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnviarMensagem();
            }
        }
        private void ControlForms()
        {
            DarkMode.ChangetoDarkMode(this);
            rtbMessages.ReadOnly = true;
            rtbMessages.SelectionProtected = true;
            rtbMessages.BackColor = this.BackColor;
            btnMenu.BackColor = Color.FromArgb(424242);
            txtText.BackColor = this.BackColor;
            pbConexao.BackColor = this.BackColor;
            txtText.Focus();
        }

        private void ConfiguraServidor(string server)
        {
            client = new SimpleTcpClient(server);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
        }
        private void ControlButtons(bool estado)
        {
            btnEnviar.Enabled = estado;
        }


        private void AbrirLogin()
        {
            FrmLogin frmLogin = new FrmLogin(nickname);            
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                if (client != null)
                {
                    client.Disconnect();
                    Task.Delay(2000);
                };
                nickname = frmLogin.nickname;
                Conectar(nickname, frmLogin.server);
                AtualizaLabels(nickname, frmLogin.server);
            }
        }

        private void AtualizaLabels(string nickname, string server)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblServidor.Text = "Servidor: " + server;
            });
        }

        private void Conectar(string nickname, string server)
        {
            try
            {
                ConfiguraServidor(server);
                client.Connect();
                ControlButtons(true);
                pbConexao.Image = TCP_IP_Chat.Properties.Resources.icons8_connected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK);
                pbConexao.Image = TCP_IP_Chat.Properties.Resources.icons8_disconnected;
            }
        }


        private void EnviarMensagem()
        {
            if (VerificaConexao())
            {
                string mensagem = nickname + ": " + txtText.Text + "\n";
                client.Send(mensagem);
                rtbMessages.Text += mensagem;
                txtText.Text = "";
            }
        }
        public bool VerificaConexao()
        {
            try
            {
                if (client != null)
                {
                    if (client.IsConnected)
                    {
                        if (!string.IsNullOrEmpty(txtText.Text))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Você não está conectado a nenhum servidor.", "Atenção!", MessageBoxButtons.OK);
                return false;
            }

        }

        private void ControleDesconectar(bool estado)
        {
            cmsDesconectar.Enabled = estado;
        }       
    }
}
