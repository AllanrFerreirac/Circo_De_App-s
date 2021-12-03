namespace CircodeAppsTDS06
{
    partial class FrmCarro
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
            this.btmCalclar = new System.Windows.Forms.Button();
            this.lblAlcool = new System.Windows.Forms.Label();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.blGasbest = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmCalclar
            // 
            this.btmCalclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCalclar.Location = new System.Drawing.Point(277, 52);
            this.btmCalclar.Name = "btmCalclar";
            this.btmCalclar.Size = new System.Drawing.Size(75, 23);
            this.btmCalclar.TabIndex = 0;
            this.btmCalclar.Text = "Calcular";
            this.btmCalclar.UseVisualStyleBackColor = true;
            // 
            // lblAlcool
            // 
            this.lblAlcool.AutoSize = true;
            this.lblAlcool.Location = new System.Drawing.Point(12, 27);
            this.lblAlcool.Name = "lblAlcool";
            this.lblAlcool.Size = new System.Drawing.Size(82, 13);
            this.lblAlcool.TabIndex = 1;
            this.lblAlcool.Text = "Preço do Álcool";
            // 
            // txtAlcool
            // 
            this.txtAlcool.Location = new System.Drawing.Point(15, 52);
            this.txtAlcool.Name = "txtAlcool";
            this.txtAlcool.Size = new System.Drawing.Size(121, 20);
            this.txtAlcool.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(277, 90);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(15, 115);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(121, 20);
            this.txtGasolina.TabIndex = 5;
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Location = new System.Drawing.Point(12, 90);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(94, 13);
            this.lblGasolina.TabIndex = 4;
            this.lblGasolina.Text = "Preço da Gasolina";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(15, 182);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(121, 20);
            this.txtDistancia.TabIndex = 7;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(12, 157);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(130, 13);
            this.lblDistancia.TabIndex = 6;
            this.lblDistancia.Text = "Distancia a percorrer (KM)";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(15, 253);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(121, 20);
            this.txtConsumo.TabIndex = 9;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(12, 228);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(130, 13);
            this.lblConsumo.TabIndex = 8;
            this.lblConsumo.Text = "Consumo médio por KM/L";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(225, 189);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(66, 13);
            this.lblCombustivel.TabIndex = 10;
            this.lblCombustivel.Text = "Combustível";
            // 
            // blGasbest
            // 
            this.blGasbest.AutoSize = true;
            this.blGasbest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blGasbest.Location = new System.Drawing.Point(225, 228);
            this.blGasbest.Name = "blGasbest";
            this.blGasbest.Size = new System.Drawing.Size(66, 24);
            this.blGasbest.TabIndex = 11;
            this.blGasbest.Text = "label6";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(225, 295);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(85, 13);
            this.lblGasto.TabIndex = 12;
            this.lblGasto.Text = "Gasto a Realizar";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(225, 335);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 24);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "label8";
            // 
            // FrmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 409);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.blGasbest);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAlcool);
            this.Controls.Add(this.lblAlcool);
            this.Controls.Add(this.btmCalclar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmCalclar;
        private System.Windows.Forms.Label lblAlcool;
        private System.Windows.Forms.TextBox txtAlcool;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label blGasbest;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblPrice;
    }
}