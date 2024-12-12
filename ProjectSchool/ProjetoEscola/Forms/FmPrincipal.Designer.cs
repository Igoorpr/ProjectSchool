namespace ProjetoEscola
{
    partial class FmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPrincipal));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btgerenciar = new System.Windows.Forms.Button();
            this.btemitircertificado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            resources.ApplyResources(this.btCadastrar, "btCadastrar");
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btgerenciar
            // 
            resources.ApplyResources(this.btgerenciar, "btgerenciar");
            this.btgerenciar.Name = "btgerenciar";
            this.btgerenciar.UseVisualStyleBackColor = true;
            this.btgerenciar.Click += new System.EventHandler(this.btgerenciar_Click);
            // 
            // btemitircertificado
            // 
            resources.ApplyResources(this.btemitircertificado, "btemitircertificado");
            this.btemitircertificado.Name = "btemitircertificado";
            this.btemitircertificado.UseVisualStyleBackColor = true;
            this.btemitircertificado.Click += new System.EventHandler(this.btemitircertificado_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btsalvar
            // 
            resources.ApplyResources(this.btsalvar, "btsalvar");
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // FmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btemitircertificado);
            this.Controls.Add(this.btgerenciar);
            this.Controls.Add(this.btCadastrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "FmPrincipal";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btgerenciar;
        private System.Windows.Forms.Button btemitircertificado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsalvar;
    }
}

