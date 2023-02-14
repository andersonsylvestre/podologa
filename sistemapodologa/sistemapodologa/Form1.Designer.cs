namespace sistemapodologa
{
    partial class Podologia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podologia));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfiguração = new System.Windows.Forms.Button();
            this.btnAgnedamentos = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnConfiguração);
            this.panelMenu.Controls.Add(this.btnAgnedamentos);
            this.panelMenu.Controls.Add(this.btnCadastro);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelMenu.Size = new System.Drawing.Size(368, 731);
            this.panelMenu.TabIndex = 0;
            // 
            // btnConfiguração
            // 
            this.btnConfiguração.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfiguração.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguração.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguração.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguração.Location = new System.Drawing.Point(36, 407);
            this.btnConfiguração.Name = "btnConfiguração";
            this.btnConfiguração.Size = new System.Drawing.Size(293, 77);
            this.btnConfiguração.TabIndex = 2;
            this.btnConfiguração.Text = "Configurações";
            this.btnConfiguração.UseVisualStyleBackColor = true;
            // 
            // btnAgnedamentos
            // 
            this.btnAgnedamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgnedamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgnedamentos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgnedamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgnedamentos.Location = new System.Drawing.Point(36, 297);
            this.btnAgnedamentos.Name = "btnAgnedamentos";
            this.btnAgnedamentos.Size = new System.Drawing.Size(293, 77);
            this.btnAgnedamentos.TabIndex = 1;
            this.btnAgnedamentos.Text = "Agendamentos";
            this.btnAgnedamentos.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastro.Location = new System.Drawing.Point(36, 186);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(293, 77);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(36, 591);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(293, 77);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Podologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 785);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Podologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podologia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnCadastro;
        private Button btnConfiguração;
        private Button btnAgnedamentos;
        private Button btnSair;
    }
}