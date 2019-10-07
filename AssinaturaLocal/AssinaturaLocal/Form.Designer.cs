namespace AssinaturaLocal
{
    partial class Form
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
            this.rtxtXmlAssinar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJCert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtXmlAssinado = new System.Windows.Forms.RichTextBox();
            this.btnAssinar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxtXmlAssinar
            // 
            this.rtxtXmlAssinar.Location = new System.Drawing.Point(12, 94);
            this.rtxtXmlAssinar.Name = "rtxtXmlAssinar";
            this.rtxtXmlAssinar.Size = new System.Drawing.Size(309, 96);
            this.rtxtXmlAssinar.TabIndex = 2;
            this.rtxtXmlAssinar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xml para Assinar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ do Certificado:";
            // 
            // txtCNPJCert
            // 
            this.txtCNPJCert.Location = new System.Drawing.Point(124, 13);
            this.txtCNPJCert.Name = "txtCNPJCert";
            this.txtCNPJCert.Size = new System.Drawing.Size(197, 20);
            this.txtCNPJCert.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xml Assinado:";
            // 
            // rtxtXmlAssinado
            // 
            this.rtxtXmlAssinado.Location = new System.Drawing.Point(12, 275);
            this.rtxtXmlAssinado.Name = "rtxtXmlAssinado";
            this.rtxtXmlAssinado.Size = new System.Drawing.Size(309, 136);
            this.rtxtXmlAssinado.TabIndex = 4;
            this.rtxtXmlAssinado.Text = "";
            // 
            // btnAssinar
            // 
            this.btnAssinar.Location = new System.Drawing.Point(91, 201);
            this.btnAssinar.Name = "btnAssinar";
            this.btnAssinar.Size = new System.Drawing.Size(151, 45);
            this.btnAssinar.TabIndex = 3;
            this.btnAssinar.Text = "Assinar";
            this.btnAssinar.UseVisualStyleBackColor = true;
            this.btnAssinar.Click += new System.EventHandler(this.btnAssinar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tag para Assinar:";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(124, 43);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(197, 20);
            this.txtTag.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 423);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAssinar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtXmlAssinado);
            this.Controls.Add(this.txtCNPJCert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtXmlAssinar);
            this.Name = "Form";
            this.Text = "Assinatura Local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtXmlAssinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNPJCert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtXmlAssinado;
        private System.Windows.Forms.Button btnAssinar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTag;
    }
}

