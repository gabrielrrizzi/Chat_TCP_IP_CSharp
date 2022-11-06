namespace TCP_IP_Chat
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
            this.cmsOptions = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cmsConectar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLimparConversa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDesconectar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblServidor = new MaterialSkin.Controls.MaterialLabel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.pbConexao = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.cmsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConexao)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOptions
            // 
            this.cmsOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsOptions.Depth = 0;
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsConectar,
            this.cmsLimparConversa,
            this.cmsDesconectar,
            this.cmsSair});
            this.cmsOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(164, 92);
            this.cmsOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOptions_Opening);
            // 
            // cmsConectar
            // 
            this.cmsConectar.Image = global::TCP_IP_Chat.Properties.Resources.icons8_server;
            this.cmsConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsConectar.Name = "cmsConectar";
            this.cmsConectar.Size = new System.Drawing.Size(163, 22);
            this.cmsConectar.Text = "Conectar";
            this.cmsConectar.Click += new System.EventHandler(this.trocarConexãoToolStripMenuItem_Click);
            // 
            // cmsLimparConversa
            // 
            this.cmsLimparConversa.Image = global::TCP_IP_Chat.Properties.Resources.icons8_broom;
            this.cmsLimparConversa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsLimparConversa.Name = "cmsLimparConversa";
            this.cmsLimparConversa.Size = new System.Drawing.Size(163, 22);
            this.cmsLimparConversa.Text = "Limpar Conversa";
            this.cmsLimparConversa.Click += new System.EventHandler(this.limparConversaToolStripMenuItem_Click);
            // 
            // cmsDesconectar
            // 
            this.cmsDesconectar.Image = global::TCP_IP_Chat.Properties.Resources.icons8_broken_link;
            this.cmsDesconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsDesconectar.Name = "cmsDesconectar";
            this.cmsDesconectar.Size = new System.Drawing.Size(163, 22);
            this.cmsDesconectar.Text = "Desconectar";
            this.cmsDesconectar.Click += new System.EventHandler(this.desconectarToolStripMenuItem1_Click);
            // 
            // cmsSair
            // 
            this.cmsSair.Image = global::TCP_IP_Chat.Properties.Resources.icons8_shutdown;
            this.cmsSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsSair.Name = "cmsSair";
            this.cmsSair.Size = new System.Drawing.Size(163, 22);
            this.cmsSair.Text = "Sair";
            this.cmsSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.ForeColor = System.Drawing.Color.White;
            this.rtbMessages.Location = new System.Drawing.Point(12, 107);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(251, 429);
            this.rtbMessages.TabIndex = 4;
            this.rtbMessages.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Depth = 0;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(203, 542);
            this.btnEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Primary = true;
            this.btnEnviar.Size = new System.Drawing.Size(60, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblServidor
            // 
            this.lblServidor.Depth = 0;
            this.lblServidor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServidor.Location = new System.Drawing.Point(8, 77);
            this.lblServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(217, 17);
            this.lblServidor.TabIndex = 6;
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.ForeColor = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(12, 542);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(185, 23);
            this.txtText.TabIndex = 10;
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtText_KeyPress);
            // 
            // pbConexao
            // 
            this.pbConexao.Image = global::TCP_IP_Chat.Properties.Resources.icons8_disconnected;
            this.pbConexao.Location = new System.Drawing.Point(231, 69);
            this.pbConexao.Name = "pbConexao";
            this.pbConexao.Size = new System.Drawing.Size(32, 32);
            this.pbConexao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbConexao.TabIndex = 7;
            this.pbConexao.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::TCP_IP_Chat.Properties.Resources.icons8_menu_24px;
            this.btnMenu.Location = new System.Drawing.Point(241, 31);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 27);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 577);
            this.ContextMenuStrip = this.cmsOptions;
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.pbConexao);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rtbMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskChat";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cmsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConexao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnEnviar;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem cmsDesconectar;
        private System.Windows.Forms.ToolStripMenuItem cmsConectar;
        private System.Windows.Forms.ToolStripMenuItem cmsSair;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsLimparConversa;
        private MaterialSkin.Controls.MaterialLabel lblServidor;
        private System.Windows.Forms.PictureBox pbConexao;
        private System.Windows.Forms.TextBox txtText;
    }
}

