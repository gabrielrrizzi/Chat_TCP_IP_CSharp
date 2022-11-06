namespace TCP_IP_Chat
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNickName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblServer = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "NickName";
            // 
            // txtNickName
            // 
            this.txtNickName.Depth = 0;
            this.txtNickName.Hint = "";
            this.txtNickName.Location = new System.Drawing.Point(12, 96);
            this.txtNickName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.PasswordChar = '\0';
            this.txtNickName.SelectedText = "";
            this.txtNickName.SelectionLength = 0;
            this.txtNickName.SelectionStart = 0;
            this.txtNickName.Size = new System.Drawing.Size(242, 23);
            this.txtNickName.TabIndex = 1;
            this.txtNickName.UseSystemPasswordChar = false;
            this.txtNickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNickName_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.Depth = 0;
            this.btnSair.Location = new System.Drawing.Point(179, 181);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(98, 181);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = true;
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtServer
            // 
            this.txtServer.Depth = 0;
            this.txtServer.Hint = "";
            this.txtServer.Location = new System.Drawing.Point(12, 152);
            this.txtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.Size = new System.Drawing.Size(242, 23);
            this.txtServer.TabIndex = 2;
            this.txtServer.UseSystemPasswordChar = false;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Depth = 0;
            this.lblServer.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblServer.Location = new System.Drawing.Point(8, 130);
            this.lblServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(125, 19);
            this.lblServer.TabIndex = 8;
            this.lblServer.Text = "Servidor (TCP/IP)";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 216);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNickName;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
        private MaterialSkin.Controls.MaterialRaisedButton btnEntrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServer;
        private MaterialSkin.Controls.MaterialLabel lblServer;
    }
}