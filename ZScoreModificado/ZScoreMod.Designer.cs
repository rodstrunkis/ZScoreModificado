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
            this.lblQntOutlier = new System.Windows.Forms.Label();
            this.lblQntOutlierValor = new System.Windows.Forms.Label();
            this.oFDPesquisar = new System.Windows.Forms.OpenFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.cplotView = new OxyPlot.WindowsForms.PlotView();
            this.dataGridViewOutlier = new System.Windows.Forms.DataGridView();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLimiar = new System.Windows.Forms.Label();
            this.txtLimiar = new System.Windows.Forms.TextBox();
            this.lblQntDiasValor = new System.Windows.Forms.Label();
            this.lblValorQntDia = new System.Windows.Forms.Label();
            this.lblValorQntMedicoes = new System.Windows.Forms.Label();
            this.lblMedicoes = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutlier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(768, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar:";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(208, 43);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(94, 14);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(668, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // lblQntOutlier
            // 
            this.lblQntOutlier.AutoSize = true;
            this.lblQntOutlier.Location = new System.Drawing.Point(543, 48);
            this.lblQntOutlier.Name = "lblQntOutlier";
            this.lblQntOutlier.Size = new System.Drawing.Size(66, 13);
            this.lblQntOutlier.TabIndex = 7;
            this.lblQntOutlier.Text = "Qntd Outlier:";
            // 
            // lblQntOutlierValor
            // 
            this.lblQntOutlierValor.AutoSize = true;
            this.lblQntOutlierValor.Location = new System.Drawing.Point(615, 48);
            this.lblQntOutlierValor.Name = "lblQntOutlierValor";
            this.lblQntOutlierValor.Size = new System.Drawing.Size(0, 13);
            this.lblQntOutlierValor.TabIndex = 8;
            this.lblQntOutlierValor.Visible = false;
            // 
            // oFDPesquisar
            // 
            this.oFDPesquisar.DefaultExt = "txt";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(1038, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cplotView
            // 
            this.cplotView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cplotView.Location = new System.Drawing.Point(13, 80);
            this.cplotView.Name = "cplotView";
            this.cplotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.cplotView.Size = new System.Drawing.Size(834, 316);
            this.cplotView.TabIndex = 10;
            this.cplotView.Text = "SandBox";
            this.cplotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.cplotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cplotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // dataGridViewOutlier
            // 
            this.dataGridViewOutlier.AllowUserToAddRows = false;
            this.dataGridViewOutlier.AllowUserToDeleteRows = false;
            this.dataGridViewOutlier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutlier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutlier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pos,
            this.Item});
            this.dataGridViewOutlier.Location = new System.Drawing.Point(853, 80);
            this.dataGridViewOutlier.Name = "dataGridViewOutlier";
            this.dataGridViewOutlier.ReadOnly = true;
            this.dataGridViewOutlier.Size = new System.Drawing.Size(260, 316);
            this.dataGridViewOutlier.TabIndex = 11;
            // 
            // Pos
            // 
            this.Pos.HeaderText = "Posição";
            this.Pos.Name = "Pos";
            this.Pos.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.HeaderText = "Item Outlier";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // lblLimiar
            // 
            this.lblLimiar.AutoSize = true;
            this.lblLimiar.Location = new System.Drawing.Point(51, 48);
            this.lblLimiar.Name = "lblLimiar";
            this.lblLimiar.Size = new System.Drawing.Size(37, 13);
            this.lblLimiar.TabIndex = 12;
            this.lblLimiar.Text = "Limiar:";
            // 
            // txtLimiar
            // 
            this.txtLimiar.Location = new System.Drawing.Point(94, 45);
            this.txtLimiar.Name = "txtLimiar";
            this.txtLimiar.Size = new System.Drawing.Size(100, 20);
            this.txtLimiar.TabIndex = 13;
            // 
            // lblQntDiasValor
            // 
            this.lblQntDiasValor.AutoSize = true;
            this.lblQntDiasValor.Location = new System.Drawing.Point(376, 48);
            this.lblQntDiasValor.Name = "lblQntDiasValor";
            this.lblQntDiasValor.Size = new System.Drawing.Size(0, 13);
            this.lblQntDiasValor.TabIndex = 15;
            this.lblQntDiasValor.Visible = false;
            // 
            // lblValorQntDia
            // 
            this.lblValorQntDia.AutoSize = true;
            this.lblValorQntDia.Location = new System.Drawing.Point(313, 48);
            this.lblValorQntDia.Name = "lblValorQntDia";
            this.lblValorQntDia.Size = new System.Drawing.Size(57, 13);
            this.lblValorQntDia.TabIndex = 14;
            this.lblValorQntDia.Text = "Qntd Dias:";
            // 
            // lblValorQntMedicoes
            // 
            this.lblValorQntMedicoes.AutoSize = true;
            this.lblValorQntMedicoes.Location = new System.Drawing.Point(500, 48);
            this.lblValorQntMedicoes.Name = "lblValorQntMedicoes";
            this.lblValorQntMedicoes.Size = new System.Drawing.Size(0, 13);
            this.lblValorQntMedicoes.TabIndex = 17;
            this.lblValorQntMedicoes.Visible = false;
            // 
            // lblMedicoes
            // 
            this.lblMedicoes.AutoSize = true;
            this.lblMedicoes.Location = new System.Drawing.Point(412, 48);
            this.lblMedicoes.Name = "lblMedicoes";
            this.lblMedicoes.Size = new System.Drawing.Size(82, 13);
            this.lblMedicoes.TabIndex = 16;
            this.lblMedicoes.Text = "Qntd Medições:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(51, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(40, 13);
            this.lblPath.TabIndex = 18;
            this.lblPath.Text = "Busca:";
            // 
            // ZScoreMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 408);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblValorQntMedicoes);
            this.Controls.Add(this.lblMedicoes);
            this.Controls.Add(this.lblQntDiasValor);
            this.Controls.Add(this.lblValorQntDia);
            this.Controls.Add(this.txtLimiar);
            this.Controls.Add(this.lblLimiar);
            this.Controls.Add(this.dataGridViewOutlier);
            this.Controls.Add(this.cplotView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblQntOutlierValor);
            this.Controls.Add(this.lblQntOutlier);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZScoreMod";
            this.Text = "Z-Score Modificado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutlier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblQntOutlier;
        private System.Windows.Forms.Label lblQntOutlierValor;
        private System.Windows.Forms.OpenFileDialog oFDPesquisar;
        private System.Windows.Forms.Button btnSair;
        private OxyPlot.WindowsForms.PlotView cplotView;
        private System.Windows.Forms.DataGridView dataGridViewOutlier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.Label lblLimiar;
        private System.Windows.Forms.TextBox txtLimiar;
        private System.Windows.Forms.Label lblQntDiasValor;
        private System.Windows.Forms.Label lblValorQntDia;
        private System.Windows.Forms.Label lblValorQntMedicoes;
        private System.Windows.Forms.Label lblMedicoes;
        private System.Windows.Forms.Label lblPath;
    }
}

