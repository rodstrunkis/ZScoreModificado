namespace ZScoreModificado
{
    partial class ZScoreMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZScoreMod));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblMAD = new System.Windows.Forms.Label();
            this.lblMADValor = new System.Windows.Forms.Label();
            this.lblMediaAmostral = new System.Windows.Forms.Label();
            this.lblMediaAmostralValor = new System.Windows.Forms.Label();
            this.lblQntOutlier = new System.Windows.Forms.Label();
            this.lblQntOutlierValor = new System.Windows.Forms.Label();
            this.oFDPesquisar = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(12, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar:";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(330, 31);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(94, 34);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(193, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // lblMAD
            // 
            this.lblMAD.AutoSize = true;
            this.lblMAD.Location = new System.Drawing.Point(52, 102);
            this.lblMAD.Name = "lblMAD";
            this.lblMAD.Size = new System.Drawing.Size(34, 13);
            this.lblMAD.TabIndex = 3;
            this.lblMAD.Text = "MAD:";
            // 
            // lblMADValor
            // 
            this.lblMADValor.AutoSize = true;
            this.lblMADValor.Location = new System.Drawing.Point(136, 102);
            this.lblMADValor.Name = "lblMADValor";
            this.lblMADValor.Size = new System.Drawing.Size(0, 13);
            this.lblMADValor.TabIndex = 4;
            this.lblMADValor.Visible = false;
            // 
            // lblMediaAmostral
            // 
            this.lblMediaAmostral.AutoSize = true;
            this.lblMediaAmostral.Location = new System.Drawing.Point(52, 131);
            this.lblMediaAmostral.Name = "lblMediaAmostral";
            this.lblMediaAmostral.Size = new System.Drawing.Size(82, 13);
            this.lblMediaAmostral.TabIndex = 5;
            this.lblMediaAmostral.Text = "Média Amostral:";
            // 
            // lblMediaAmostralValor
            // 
            this.lblMediaAmostralValor.AutoSize = true;
            this.lblMediaAmostralValor.Location = new System.Drawing.Point(136, 131);
            this.lblMediaAmostralValor.Name = "lblMediaAmostralValor";
            this.lblMediaAmostralValor.Size = new System.Drawing.Size(0, 13);
            this.lblMediaAmostralValor.TabIndex = 6;
            this.lblMediaAmostralValor.Visible = false;
            // 
            // lblQntOutlier
            // 
            this.lblQntOutlier.AutoSize = true;
            this.lblQntOutlier.Location = new System.Drawing.Point(52, 158);
            this.lblQntOutlier.Name = "lblQntOutlier";
            this.lblQntOutlier.Size = new System.Drawing.Size(66, 13);
            this.lblQntOutlier.TabIndex = 7;
            this.lblQntOutlier.Text = "Qntd Outlier:";
            // 
            // lblQntOutlierValor
            // 
            this.lblQntOutlierValor.AutoSize = true;
            this.lblQntOutlierValor.Location = new System.Drawing.Point(136, 158);
            this.lblQntOutlierValor.Name = "lblQntOutlierValor";
            this.lblQntOutlierValor.Size = new System.Drawing.Size(0, 13);
            this.lblQntOutlierValor.TabIndex = 8;
            this.lblQntOutlierValor.Visible = false;
            // 
            // oFDPesquisar
            // 
            this.oFDPesquisar.DefaultExt = "txt";
            // 
            // ZScoreMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.lblQntOutlierValor);
            this.Controls.Add(this.lblQntOutlier);
            this.Controls.Add(this.lblMediaAmostralValor);
            this.Controls.Add(this.lblMediaAmostral);
            this.Controls.Add(this.lblMADValor);
            this.Controls.Add(this.lblMAD);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZScoreMod";
            this.Text = "Z-Score Modificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblMAD;
        private System.Windows.Forms.Label lblMADValor;
        private System.Windows.Forms.Label lblMediaAmostral;
        private System.Windows.Forms.Label lblMediaAmostralValor;
        private System.Windows.Forms.Label lblQntOutlier;
        private System.Windows.Forms.Label lblQntOutlierValor;
        private System.Windows.Forms.OpenFileDialog oFDPesquisar;
    }
}

