namespace TestLink
{
    partial class Form1
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
            this.tstBtn = new System.Windows.Forms.Button();
            this.lbl_nameService = new System.Windows.Forms.Label();
            this.txtBx_serviceName = new System.Windows.Forms.TextBox();
            this.lbl_server = new System.Windows.Forms.Label();
            this.txtBx_server = new System.Windows.Forms.TextBox();
            this.txtBx_port = new System.Windows.Forms.TextBox();
            this.txtBx_user = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtBx_pass = new System.Windows.Forms.TextBox();
            this.rdBtn_native = new System.Windows.Forms.RadioButton();
            this.rdBtn_devart = new System.Windows.Forms.RadioButton();
            this.txtBx_sid = new System.Windows.Forms.TextBox();
            this.txtBx_qtd = new System.Windows.Forms.TextBox();
            this.lbl_sid = new System.Windows.Forms.Label();
            this.lbl_qtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tstBtn
            // 
            this.tstBtn.Location = new System.Drawing.Point(377, 193);
            this.tstBtn.Name = "tstBtn";
            this.tstBtn.Size = new System.Drawing.Size(75, 23);
            this.tstBtn.TabIndex = 0;
            this.tstBtn.Text = "Testar";
            this.tstBtn.UseVisualStyleBackColor = true;
            this.tstBtn.Click += new System.EventHandler(this.tstBtn_Click);
            // 
            // lbl_nameService
            // 
            this.lbl_nameService.AutoSize = true;
            this.lbl_nameService.Location = new System.Drawing.Point(16, 12);
            this.lbl_nameService.Name = "lbl_nameService";
            this.lbl_nameService.Size = new System.Drawing.Size(95, 13);
            this.lbl_nameService.TabIndex = 1;
            this.lbl_nameService.Text = "Nome do Serviço: ";
            // 
            // txtBx_serviceName
            // 
            this.txtBx_serviceName.Location = new System.Drawing.Point(115, 5);
            this.txtBx_serviceName.Name = "txtBx_serviceName";
            this.txtBx_serviceName.Size = new System.Drawing.Size(337, 20);
            this.txtBx_serviceName.TabIndex = 2;
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(16, 65);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(52, 13);
            this.lbl_server.TabIndex = 3;
            this.lbl_server.Text = "Servidor: ";
            // 
            // txtBx_server
            // 
            this.txtBx_server.Location = new System.Drawing.Point(115, 58);
            this.txtBx_server.Name = "txtBx_server";
            this.txtBx_server.Size = new System.Drawing.Size(337, 20);
            this.txtBx_server.TabIndex = 4;
            // 
            // txtBx_port
            // 
            this.txtBx_port.Location = new System.Drawing.Point(115, 84);
            this.txtBx_port.Name = "txtBx_port";
            this.txtBx_port.Size = new System.Drawing.Size(337, 20);
            this.txtBx_port.TabIndex = 5;
            // 
            // txtBx_user
            // 
            this.txtBx_user.Location = new System.Drawing.Point(115, 110);
            this.txtBx_user.Name = "txtBx_user";
            this.txtBx_user.Size = new System.Drawing.Size(337, 20);
            this.txtBx_user.TabIndex = 6;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(16, 91);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(32, 13);
            this.lbl_port.TabIndex = 8;
            this.lbl_port.Text = "Porta";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(16, 117);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 9;
            this.lbl_user.Text = "Usuário";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(16, 143);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(38, 13);
            this.lbl_pass.TabIndex = 10;
            this.lbl_pass.Text = "Senha";
            // 
            // txtBx_pass
            // 
            this.txtBx_pass.Location = new System.Drawing.Point(115, 136);
            this.txtBx_pass.Name = "txtBx_pass";
            this.txtBx_pass.PasswordChar = '*';
            this.txtBx_pass.Size = new System.Drawing.Size(337, 20);
            this.txtBx_pass.TabIndex = 11;
            // 
            // rdBtn_native
            // 
            this.rdBtn_native.AutoSize = true;
            this.rdBtn_native.Checked = true;
            this.rdBtn_native.Location = new System.Drawing.Point(143, 193);
            this.rdBtn_native.Name = "rdBtn_native";
            this.rdBtn_native.Size = new System.Drawing.Size(56, 17);
            this.rdBtn_native.TabIndex = 12;
            this.rdBtn_native.TabStop = true;
            this.rdBtn_native.Text = "Nativo";
            this.rdBtn_native.UseVisualStyleBackColor = true;
            // 
            // rdBtn_devart
            // 
            this.rdBtn_devart.AutoSize = true;
            this.rdBtn_devart.Location = new System.Drawing.Point(235, 193);
            this.rdBtn_devart.Name = "rdBtn_devart";
            this.rdBtn_devart.Size = new System.Drawing.Size(57, 17);
            this.rdBtn_devart.TabIndex = 13;
            this.rdBtn_devart.Text = "Devart";
            this.rdBtn_devart.UseVisualStyleBackColor = true;
            // 
            // txtBx_sid
            // 
            this.txtBx_sid.Location = new System.Drawing.Point(115, 32);
            this.txtBx_sid.Name = "txtBx_sid";
            this.txtBx_sid.Size = new System.Drawing.Size(337, 20);
            this.txtBx_sid.TabIndex = 14;
            // 
            // txtBx_qtd
            // 
            this.txtBx_qtd.Location = new System.Drawing.Point(115, 163);
            this.txtBx_qtd.Name = "txtBx_qtd";
            this.txtBx_qtd.Size = new System.Drawing.Size(337, 20);
            this.txtBx_qtd.TabIndex = 15;
            // 
            // lbl_sid
            // 
            this.lbl_sid.AutoSize = true;
            this.lbl_sid.Location = new System.Drawing.Point(16, 39);
            this.lbl_sid.Name = "lbl_sid";
            this.lbl_sid.Size = new System.Drawing.Size(31, 13);
            this.lbl_sid.TabIndex = 16;
            this.lbl_sid.Text = "SID: ";
            // 
            // lbl_qtde
            // 
            this.lbl_qtde.AutoSize = true;
            this.lbl_qtde.Location = new System.Drawing.Point(16, 170);
            this.lbl_qtde.Name = "lbl_qtde";
            this.lbl_qtde.Size = new System.Drawing.Size(86, 13);
            this.lbl_qtde.TabIndex = 17;
            this.lbl_qtde.Text = "Qtde de Testes: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 228);
            this.Controls.Add(this.lbl_qtde);
            this.Controls.Add(this.lbl_sid);
            this.Controls.Add(this.txtBx_qtd);
            this.Controls.Add(this.txtBx_sid);
            this.Controls.Add(this.rdBtn_devart);
            this.Controls.Add(this.rdBtn_native);
            this.Controls.Add(this.txtBx_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.txtBx_user);
            this.Controls.Add(this.txtBx_port);
            this.Controls.Add(this.txtBx_server);
            this.Controls.Add(this.lbl_server);
            this.Controls.Add(this.txtBx_serviceName);
            this.Controls.Add(this.lbl_nameService);
            this.Controls.Add(this.tstBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tstBtn;
        private System.Windows.Forms.Label lbl_nameService;
        private System.Windows.Forms.TextBox txtBx_serviceName;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.TextBox txtBx_server;
        private System.Windows.Forms.TextBox txtBx_port;
        private System.Windows.Forms.TextBox txtBx_user;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtBx_pass;
        private System.Windows.Forms.RadioButton rdBtn_native;
        private System.Windows.Forms.RadioButton rdBtn_devart;
        private System.Windows.Forms.TextBox txtBx_sid;
        private System.Windows.Forms.TextBox txtBx_qtd;
        private System.Windows.Forms.Label lbl_sid;
        private System.Windows.Forms.Label lbl_qtde;
    }
}

