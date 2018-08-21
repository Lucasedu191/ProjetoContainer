namespace Projetomódulo02Container
{
    partial class frmSplitcontainer
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
            this.sptConteudo = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlImagem = new System.Windows.Forms.Panel();
            this.lsbImagens = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sptConteudo)).BeginInit();
            this.sptConteudo.Panel1.SuspendLayout();
            this.sptConteudo.Panel2.SuspendLayout();
            this.sptConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sptConteudo
            // 
            this.sptConteudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sptConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptConteudo.Location = new System.Drawing.Point(0, 0);
            this.sptConteudo.Name = "sptConteudo";
            // 
            // sptConteudo.Panel1
            // 
            this.sptConteudo.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sptConteudo.Panel1.Controls.Add(this.lsbImagens);
            // 
            // sptConteudo.Panel2
            // 
            this.sptConteudo.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sptConteudo.Panel2.Controls.Add(this.splitContainer2);
            this.sptConteudo.Size = new System.Drawing.Size(800, 450);
            this.sptConteudo.SplitterDistance = 206;
            this.sptConteudo.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlImagem);
            this.splitContainer2.Size = new System.Drawing.Size(586, 446);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnlImagem
            // 
            this.pnlImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagem.Location = new System.Drawing.Point(0, 0);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(586, 284);
            this.pnlImagem.TabIndex = 0;
            // 
            // lsbImagens
            // 
            this.lsbImagens.BackColor = System.Drawing.Color.DimGray;
            this.lsbImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbImagens.FormattingEnabled = true;
            this.lsbImagens.Location = new System.Drawing.Point(0, 0);
            this.lsbImagens.Name = "lsbImagens";
            this.lsbImagens.Size = new System.Drawing.Size(202, 446);
            this.lsbImagens.TabIndex = 0;
            // 
            // frmSplitcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sptConteudo);
            this.Name = "frmSplitcontainer";
            this.Text = "frmSplitcontainer";
            this.sptConteudo.Panel1.ResumeLayout(false);
            this.sptConteudo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptConteudo)).EndInit();
            this.sptConteudo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptConteudo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lsbImagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlImagem;
    }
}