using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_IP_Server.ViewController;
using SimpleTcp;

namespace TCP_IP_Server.View
{
    public partial class FrmMain : MaterialForm
    {
        SimpleTcpServer server;
        string _servidor;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _servidor = ServerConfig.ConfiguracoesServidor();          
            ControlForms();
            ControlButtons(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IniciarServidor();
        }
       
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            UsuarioDesconectado(e);
        }
       
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            NovoUsuarioConectado(e);
        }       

        private void Events_DataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ReceberMensagem(e);
            });
        }
       
        private void fecharServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharServidor();
        }      

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnviarMensagem();
            }
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            EnviarMensagem();
        }
        private void IniciarServidor()
        {
            try
            {
                ConfiguraServidor();
                server.Start();
                cmsFecharServidor.Enabled = true;
                rtbMessages.Text += $"Servidor iniciado com sucesso!{Environment.NewLine}";
                pbStatus.Image = TCP_IP_Server.Properties.Resources.icons8_100_;
                ControlButtons(true);
                txtText.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rtbMessages.Text += $"Tivemos erros ao iniciar o servidor :({Environment.NewLine}";
            }
        }
        private void ReceberMensagem(DataReceivedFromClientEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string mensagemRecebida = $"{Encoding.UTF8.GetString(e.Data)}";
                rtbMessages.Text += mensagemRecebida;
                AtualizaUsuario(mensagemRecebida, e.IpPort);
                EnviarMensagemTodosUsuarios(mensagemRecebida, e.IpPort);
            });
        }

        private void UsuarioDesconectado(ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                int index = lbUsuarios.FindString(e.IpPort);
                rtbMessages.Text += $"{lbUsuarios.Items[index]} desconectou.{Environment.NewLine}";
                lbUsuarios.Items.RemoveAt(index);
            });

        }

        private void NovoUsuarioConectado(ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                rtbMessages.Text += $"{e.IpPort} conectou.{Environment.NewLine}";
                lbUsuarios.Items.Add(e.IpPort);
            });
        }
        private void ControlForms()
        {
            DarkMode.ChangetoDarkMode(this);
            txtServer.Text = _servidor;
            rtbMessages.ReadOnly = true;
            rtbMessages.SelectionProtected = true;
            rtbMessages.BackColor = this.BackColor;
            rtbMessages.ForeColor = Color.White;
            lbUsuarios.BackColor = this.BackColor;
            lbUsuarios.ForeColor = Color.White;
            txtServer.BackColor = this.BackColor;
            btnEnviar.Enabled = false;
            pbServer.BackColor = Color.FromArgb(424242);
            pbStatus.BackColor = Color.FromArgb(424242);
            pbStatus.Image = TCP_IP_Server.Properties.Resources.icons8_0_percent;
        }

        private void ControlButtons(bool estado)
        {
            if (estado == true) { btnStart.Enabled = false; }
            else { btnStart.Enabled = true; }
            btnEnviar.Enabled = estado;
        }

        public void EnviarMensagem()
        {
            if (VerificaServidor())
            {
                string mensagem = $"Servidor: {txtText.Text}{Environment.NewLine}";
                string[] _usuario = lbUsuarios.SelectedItem.ToString().Split('(');
                string destino = _usuario[0].Trim();
                server.Send(destino, mensagem);
                rtbMessages.Text += mensagem;
                txtText.Text = "";
            }
        }

        public void EnviarMensagemTodosUsuarios(string mensagem, string ipPort)
        {
            if (server.IsListening)
            {
                foreach (string usuario in lbUsuarios.Items)
                {
                    string[] _usuario = usuario.Split('(');
                    if (!ipPort.Equals(_usuario[0].Trim()))
                    {
                        server.Send(_usuario[0].Trim(), mensagem);
                    }
                }

            }
        }

        public bool VerificaServidor()
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtText.Text) && lbUsuarios.SelectedItem != null)
                {
                    return true;
                }
            }
            return false;
        }

        public void ConfiguraServidor()
        {
            server = new SimpleTcpServer(txtServer.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }
        private void AtualizaUsuario(string mensagemRecebida, string ipPort)
        {
            string[] usuario = mensagemRecebida.Split(':');
            int index = lbUsuarios.FindString(ipPort);
            if (!lbUsuarios.Items[index].ToString().Contains("("))
            {
                lbUsuarios.Items[index] = lbUsuarios.Items[index].ToString() + " (" + usuario[0].Replace(":", ",") + ")";
            }
        }
        private void FecharServidor()
        {
            DesconectarTodos();
            server.Stop();            
            pbStatus.Image = TCP_IP_Server.Properties.Resources.icons8_0_percent;
            lbUsuarios.Items.Clear();
            rtbMessages.Text += $"Servidor parado!{Environment.NewLine}";
            btnStart.Enabled = true;
        }

        private void DesconectarTodos()
        {
            string[] usuarios = server.GetClients().ToArray();
            foreach(string usuario in usuarios)
            {
                server.DisconnectClient(usuario);
            }
        }
    }
}
