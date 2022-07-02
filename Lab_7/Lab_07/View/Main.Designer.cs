
namespace Lab_07.View
{
    partial class Main
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
            this.lblValorcompra = new System.Windows.Forms.Label();
            this.lblValordinheiro = new System.Windows.Forms.Label();
            this.lblValortroco = new System.Windows.Forms.Label();
            this.lblMoedastroco = new System.Windows.Forms.Label();
            this.lblMoeda100 = new System.Windows.Forms.Label();
            this.lblMoedas001 = new System.Windows.Forms.Label();
            this.lblMoedas050 = new System.Windows.Forms.Label();
            this.lblMoedas025 = new System.Windows.Forms.Label();
            this.lblMoedas010 = new System.Windows.Forms.Label();
            this.lblMoedas005 = new System.Windows.Forms.Label();
            this.lblResultado050 = new System.Windows.Forms.Label();
            this.lblResultado010 = new System.Windows.Forms.Label();
            this.lblResultado001 = new System.Windows.Forms.Label();
            this.lblResultado025 = new System.Windows.Forms.Label();
            this.lblResultado005 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultado100 = new System.Windows.Forms.Label();
            this.tbxValorcompra = new System.Windows.Forms.TextBox();
            this.tbxValordinheiro = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorcompra
            // 
            this.lblValorcompra.AutoSize = true;
            this.lblValorcompra.Location = new System.Drawing.Point(15, 31);
            this.lblValorcompra.Name = "lblValorcompra";
            this.lblValorcompra.Size = new System.Drawing.Size(95, 15);
            this.lblValorcompra.TabIndex = 0;
            this.lblValorcompra.Text = "Valor da Compra";
            this.lblValorcompra.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValordinheiro
            // 
            this.lblValordinheiro.AutoSize = true;
            this.lblValordinheiro.Location = new System.Drawing.Point(15, 77);
            this.lblValordinheiro.Name = "lblValordinheiro";
            this.lblValordinheiro.Size = new System.Drawing.Size(131, 15);
            this.lblValordinheiro.TabIndex = 1;
            this.lblValordinheiro.Text = "Valor Pago em Dinheiro";
            // 
            // lblValortroco
            // 
            this.lblValortroco.AutoSize = true;
            this.lblValortroco.Location = new System.Drawing.Point(15, 119);
            this.lblValortroco.Name = "lblValortroco";
            this.lblValortroco.Size = new System.Drawing.Size(82, 15);
            this.lblValortroco.TabIndex = 2;
            this.lblValortroco.Text = "Valor do Troco";
            this.lblValortroco.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMoedastroco
            // 
            this.lblMoedastroco.AutoSize = true;
            this.lblMoedastroco.Location = new System.Drawing.Point(431, 29);
            this.lblMoedastroco.Name = "lblMoedastroco";
            this.lblMoedastroco.Size = new System.Drawing.Size(116, 15);
            this.lblMoedastroco.TabIndex = 3;
            this.lblMoedastroco.Text = "Moedas para o troco";
            this.lblMoedastroco.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMoeda100
            // 
            this.lblMoeda100.AutoSize = true;
            this.lblMoeda100.Location = new System.Drawing.Point(442, 75);
            this.lblMoeda100.Name = "lblMoeda100";
            this.lblMoeda100.Size = new System.Drawing.Size(105, 15);
            this.lblMoeda100.TabIndex = 4;
            this.lblMoeda100.Text = "Moedas de R$ 1,00";
            // 
            // lblMoedas001
            // 
            this.lblMoedas001.AutoSize = true;
            this.lblMoedas001.Location = new System.Drawing.Point(442, 308);
            this.lblMoedas001.Name = "lblMoedas001";
            this.lblMoedas001.Size = new System.Drawing.Size(105, 15);
            this.lblMoedas001.TabIndex = 5;
            this.lblMoedas001.Text = "Moedas de R$ 0,01";
            this.lblMoedas001.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblMoedas050
            // 
            this.lblMoedas050.AutoSize = true;
            this.lblMoedas050.Location = new System.Drawing.Point(442, 119);
            this.lblMoedas050.Name = "lblMoedas050";
            this.lblMoedas050.Size = new System.Drawing.Size(105, 15);
            this.lblMoedas050.TabIndex = 6;
            this.lblMoedas050.Text = "Moedas de R$ 0,50";
            this.lblMoedas050.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMoedas025
            // 
            this.lblMoedas025.AutoSize = true;
            this.lblMoedas025.Location = new System.Drawing.Point(442, 160);
            this.lblMoedas025.Name = "lblMoedas025";
            this.lblMoedas025.Size = new System.Drawing.Size(105, 15);
            this.lblMoedas025.TabIndex = 7;
            this.lblMoedas025.Text = "Moedas de R$ 0,25";
            // 
            // lblMoedas010
            // 
            this.lblMoedas010.AutoSize = true;
            this.lblMoedas010.Location = new System.Drawing.Point(442, 203);
            this.lblMoedas010.Name = "lblMoedas010";
            this.lblMoedas010.Size = new System.Drawing.Size(105, 15);
            this.lblMoedas010.TabIndex = 8;
            this.lblMoedas010.Text = "Moedas de R$ 0,10";
            // 
            // lblMoedas005
            // 
            this.lblMoedas005.AutoSize = true;
            this.lblMoedas005.Location = new System.Drawing.Point(442, 250);
            this.lblMoedas005.Name = "lblMoedas005";
            this.lblMoedas005.Size = new System.Drawing.Size(105, 15);
            this.lblMoedas005.TabIndex = 9;
            this.lblMoedas005.Text = "Moedas de R$ 0,05";
            // 
            // lblResultado050
            // 
            this.lblResultado050.AutoSize = true;
            this.lblResultado050.Location = new System.Drawing.Point(408, 119);
            this.lblResultado050.Name = "lblResultado050";
            this.lblResultado050.Size = new System.Drawing.Size(13, 15);
            this.lblResultado050.TabIndex = 10;
            this.lblResultado050.Text = "0";
            // 
            // lblResultado010
            // 
            this.lblResultado010.AutoSize = true;
            this.lblResultado010.Location = new System.Drawing.Point(408, 203);
            this.lblResultado010.Name = "lblResultado010";
            this.lblResultado010.Size = new System.Drawing.Size(13, 15);
            this.lblResultado010.TabIndex = 11;
            this.lblResultado010.Text = "0";
            // 
            // lblResultado001
            // 
            this.lblResultado001.AutoSize = true;
            this.lblResultado001.Location = new System.Drawing.Point(408, 308);
            this.lblResultado001.Name = "lblResultado001";
            this.lblResultado001.Size = new System.Drawing.Size(13, 15);
            this.lblResultado001.TabIndex = 12;
            this.lblResultado001.Text = "0";
            // 
            // lblResultado025
            // 
            this.lblResultado025.AutoSize = true;
            this.lblResultado025.Location = new System.Drawing.Point(408, 160);
            this.lblResultado025.Name = "lblResultado025";
            this.lblResultado025.Size = new System.Drawing.Size(13, 15);
            this.lblResultado025.TabIndex = 13;
            this.lblResultado025.Text = "0";
            // 
            // lblResultado005
            // 
            this.lblResultado005.AutoSize = true;
            this.lblResultado005.Location = new System.Drawing.Point(408, 250);
            this.lblResultado005.Name = "lblResultado005";
            this.lblResultado005.Size = new System.Drawing.Size(13, 15);
            this.lblResultado005.TabIndex = 14;
            this.lblResultado005.Text = "0";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(133, 119);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 15);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "0";
            // 
            // lblResultado100
            // 
            this.lblResultado100.AutoSize = true;
            this.lblResultado100.Location = new System.Drawing.Point(408, 75);
            this.lblResultado100.Name = "lblResultado100";
            this.lblResultado100.Size = new System.Drawing.Size(13, 15);
            this.lblResultado100.TabIndex = 16;
            this.lblResultado100.Text = "0";
            // 
            // tbxValorcompra
            // 
            this.tbxValorcompra.Location = new System.Drawing.Point(167, 28);
            this.tbxValorcompra.Name = "tbxValorcompra";
            this.tbxValorcompra.Size = new System.Drawing.Size(176, 23);
            this.tbxValorcompra.TabIndex = 17;
            // 
            // tbxValordinheiro
            // 
            this.tbxValordinheiro.Location = new System.Drawing.Point(167, 74);
            this.tbxValordinheiro.Name = "tbxValordinheiro";
            this.tbxValordinheiro.Size = new System.Drawing.Size(176, 23);
            this.tbxValordinheiro.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(15, 168);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(328, 207);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxValordinheiro);
            this.Controls.Add(this.tbxValorcompra);
            this.Controls.Add(this.lblResultado100);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblResultado005);
            this.Controls.Add(this.lblResultado025);
            this.Controls.Add(this.lblResultado001);
            this.Controls.Add(this.lblResultado010);
            this.Controls.Add(this.lblResultado050);
            this.Controls.Add(this.lblMoedas005);
            this.Controls.Add(this.lblMoedas010);
            this.Controls.Add(this.lblMoedas025);
            this.Controls.Add(this.lblMoedas050);
            this.Controls.Add(this.lblMoedas001);
            this.Controls.Add(this.lblMoeda100);
            this.Controls.Add(this.lblMoedastroco);
            this.Controls.Add(this.lblValortroco);
            this.Controls.Add(this.lblValordinheiro);
            this.Controls.Add(this.lblValorcompra);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorcompra;
        private System.Windows.Forms.Label lblValordinheiro;
        private System.Windows.Forms.Label lblValortroco;
        private System.Windows.Forms.Label lblMoedastroco;
        private System.Windows.Forms.Label lblMoeda100;
        private System.Windows.Forms.Label lblMoedas001;
        private System.Windows.Forms.Label lblMoedas050;
        private System.Windows.Forms.Label lblMoedas025;
        private System.Windows.Forms.Label lblMoedas010;
        private System.Windows.Forms.Label lblMoedas005;
        private System.Windows.Forms.Label lblResultado050;
        private System.Windows.Forms.Label lblResultado010;
        private System.Windows.Forms.Label lblResultado001;
        private System.Windows.Forms.Label lblResultado025;
        private System.Windows.Forms.Label lblResultado005;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultado100;
        private System.Windows.Forms.TextBox tbxValorcompra;
        private System.Windows.Forms.TextBox tbxValordinheiro;
        private System.Windows.Forms.Button btnCalcular;
    }
}