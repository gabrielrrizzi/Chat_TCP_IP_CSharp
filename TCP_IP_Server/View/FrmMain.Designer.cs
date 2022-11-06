namespace TCP_IP_Server.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.cmsControlServidor = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cmsFecharServidor = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.btnStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblUsuarios = new MaterialSkin.Controls.MaterialLabel();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.pbServer = new System.Windows.Forms.PictureBox();
            this.cmsControlServidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.ContextMenuStrip = this.cmsControlServidor;
            this.rtbMessages.ForeColor = System.Drawing.Color.White;
            this.rtbMessages.Location = new System.Drawing.Point(12, 96);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.ShortcutsEnabled = false;
            this.rtbMessages.Size = new System.Drawing.Size(242, 433);
            this.rtbMessages.TabIndex = 3;
            this.rtbMessages.Text = "";
            // 
            // cmsControlServidor
            // 
            this.cmsControlServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsControlServidor.Depth = 0;
            this.cmsControlServidor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFecharServidor});
            this.cmsControlServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsControlServidor.Name = "cmsControlServidor";
            this.cmsControlServidor.Size = new System.Drawing.Size(156, 26);
            // 
            // cmsFecharServidor
            // 
            this.cmsFecharServidor.Enabled = false;
            this.cmsFecharServidor.Name = "cmsFecharServidor";
            this.cmsFecharServidor.Size = new System.Drawing.Size(155, 22);
            this.cmsFecharServidor.Text = "Fechar Servidor";
            this.cmsFecharServidor.Click += new System.EventHandler(this.fecharServidorToolStripMenuItem_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtText.ContextMenuStrip = this.cmsControlServidor;
            this.txtText.Depth = 0;
            this.txtText.Hint = "";
            this.txtText.Location = new System.Drawing.Point(12, 549);
            this.txtText.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.Size = new System.Drawing.Size(242, 23);
            this.txtText.TabIndex = 4;
            this.txtText.UseSystemPasswordChar = false;
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtText_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Depth = 0;
            this.btnEnviar.Location = new System.Drawing.Point(260, 549);
            this.btnEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Primary = true;
            this.btnEnviar.Size = new System.Drawing.Size(114, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.Location = new System.Drawing.Point(260, 96);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(233, 433);
            this.lbUsuarios.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Depth = 0;
            this.btnStart.Location = new System.Drawing.Point(380, 549);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = true;
            this.btnStart.Size = new System.Drawing.Size(113, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuarios.ContextMenuStrip = this.cmsControlServidor;
            this.lblUsuarios.Depth = 0;
            this.lblUsuarios.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuarios.Location = new System.Drawing.Point(260, 70);
            this.lblUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(233, 25);
            this.lblUsuarios.TabIndex = 9;
            this.lblUsuarios.Text = "Usuários Conectados";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServer
            // 
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServer.ContextMenuStrip = this.cmsControlServidor;
            this.txtServer.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtServer.ForeColor = System.Drawing.Color.White;
            this.txtServer.Location = new System.Drawing.Point(12, 70);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(242, 25);
            this.txtServer.TabIndex = 10;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::TCP_IP_Server.Properties.Resources.icons8_100_;
            this.pbStatus.Location = new System.Drawing.Point(74, 27);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(32, 32);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStatus.TabIndex = 12;
            this.pbStatus.TabStop = false;
            // 
            // pbServer
            // 
            this.pbServer.Image = global::TCP_IP_Server.Properties.Resources.icons8_server;
            this.pbServer.Location = new System.Drawing.Point(460, 27);
            this.pbServer.Name = "pbServer";
            this.pbServer.Size = new System.Drawing.Size(32, 32);
            this.pbServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbServer.TabIndex = 11;
            this.pbServer.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 577);
            this.ContextMenuStrip = this.cmsControlServidor;
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.pbServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.rtbMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cmsControlServidor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessages;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtText;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnviar;
        private System.Windows.Forms.ListBox lbUsuarios;
        private MaterialSkin.Controls.MaterialRaisedButton btnStart;
        private MaterialSkin.Controls.MaterialLabel lblUsuarios;
        private System.Windows.Forms.TextBox txtServer;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsControlServidor;
        private System.Windows.Forms.ToolStripMenuItem cmsFecharServidor;
        private System.Windows.Forms.PictureBox pbServer;
        private System.Windows.Forms.PictureBox pbStatus;
    }
}