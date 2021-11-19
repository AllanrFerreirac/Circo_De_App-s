namespace CircoDeApp
{
    partial class FrmPrincipal
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
            this.lblBuscaCEP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbxCEP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscaCEP
            // 
            this.lblBuscaCEP.AutoSize = true;
            this.lblBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCEP.Location = new System.Drawing.Point(46, 185);
            this.lblBuscaCEP.Name = "lblBuscaCEP";
            this.lblBuscaCEP.Size = new System.Drawing.Size(114, 24);
            this.lblBuscaCEP.TabIndex = 0;
            this.lblBuscaCEP.Text = "Busca CEP";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(612, 545);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 55);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbxCEP
            // 
            this.pbxCEP.Image = global::CircoDeApp.Properties.Resources.cep;
            this.pbxCEP.Location = new System.Drawing.Point(24, 32);
            this.pbxCEP.Name = "pbxCEP";
            this.pbxCEP.Size = new System.Drawing.Size(157, 150);
            this.pbxCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCEP.TabIndex = 2;
            this.pbxCEP.TabStop = false;
            this.pbxCEP.Click += new System.EventHandler(this.pbxCEP_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 612);
            this.Controls.Add(this.pbxCEP);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBuscaCEP);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de App\'s";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscaCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbxCEP;
    }
}

