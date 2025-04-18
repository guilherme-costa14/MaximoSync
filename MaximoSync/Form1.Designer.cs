namespace MaximoSync
{
    partial class Form1
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
            System.Windows.Forms.Label tempoMinutosLabel;
            System.Windows.Forms.Label urlLinkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtUrlLink = new System.Windows.Forms.TextBox();
            this.btnSincronizar = new System.Windows.Forms.Button();
            tempoMinutosLabel = new System.Windows.Forms.Label();
            urlLinkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempoMinutosLabel
            // 
            tempoMinutosLabel.AutoSize = true;
            tempoMinutosLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempoMinutosLabel.Location = new System.Drawing.Point(37, 69);
            tempoMinutosLabel.Name = "tempoMinutosLabel";
            tempoMinutosLabel.Size = new System.Drawing.Size(87, 17);
            tempoMinutosLabel.TabIndex = 1;
            tempoMinutosLabel.Text = "Tempo (min):";
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(130, 66);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(158, 24);
            this.txtTempo.TabIndex = 2;
            // 
            // urlLinkLabel
            // 
            urlLinkLabel.AutoSize = true;
            urlLinkLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            urlLinkLabel.Location = new System.Drawing.Point(88, 30);
            urlLinkLabel.Name = "urlLinkLabel";
            urlLinkLabel.Size = new System.Drawing.Size(36, 17);
            urlLinkLabel.TabIndex = 3;
            urlLinkLabel.Text = "URL:";
            // 
            // txtUrlLink
            // 
            this.txtUrlLink.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlLink.Location = new System.Drawing.Point(130, 27);
            this.txtUrlLink.Name = "txtUrlLink";
            this.txtUrlLink.Size = new System.Drawing.Size(158, 24);
            this.txtUrlLink.TabIndex = 4;
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSincronizar.Location = new System.Drawing.Point(130, 107);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(100, 30);
            this.btnSincronizar.TabIndex = 5;
            this.btnSincronizar.Text = "Sincronizar";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 160);
            this.Controls.Add(this.btnSincronizar);
            this.Controls.Add(urlLinkLabel);
            this.Controls.Add(this.txtUrlLink);
            this.Controls.Add(tempoMinutosLabel);
            this.Controls.Add(this.txtTempo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MaximoSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtUrlLink;
        private System.Windows.Forms.Button btnSincronizar;
    }
}

