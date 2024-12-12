namespace ProjetoEscola.Forms
{
    partial class FmIncluirAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmIncluirAluno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btcadastraraluno = new System.Windows.Forms.Button();
            this.btgerarmatricula = new System.Windows.Forms.Button();
            this.cbcurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(132, 110);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(106, 20);
            this.txtmatricula.TabIndex = 5;
            this.txtmatricula.TextChanged += new System.EventHandler(this.txtmatricula_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(132, 18);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(106, 20);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // btcadastraraluno
            // 
            this.btcadastraraluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastraraluno.Location = new System.Drawing.Point(132, 182);
            this.btcadastraraluno.Name = "btcadastraraluno";
            this.btcadastraraluno.Size = new System.Drawing.Size(106, 30);
            this.btcadastraraluno.TabIndex = 9;
            this.btcadastraraluno.Text = "Salvar";
            this.btcadastraraluno.UseVisualStyleBackColor = true;
            this.btcadastraraluno.Click += new System.EventHandler(this.btcadastraraluno_Click);
            // 
            // btgerarmatricula
            // 
            this.btgerarmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgerarmatricula.Location = new System.Drawing.Point(174, 136);
            this.btgerarmatricula.Name = "btgerarmatricula";
            this.btgerarmatricula.Size = new System.Drawing.Size(64, 29);
            this.btgerarmatricula.TabIndex = 10;
            this.btgerarmatricula.Text = "Gerar";
            this.btgerarmatricula.UseVisualStyleBackColor = true;
            this.btgerarmatricula.Click += new System.EventHandler(this.btgerarmatricula_Click);
            // 
            // cbcurso
            // 
            this.cbcurso.FormattingEnabled = true;
            this.cbcurso.Location = new System.Drawing.Point(132, 63);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(106, 21);
            this.cbcurso.TabIndex = 11;
            this.cbcurso.Text = "Selecionar Curso";
            this.cbcurso.UseWaitCursor = true;
            this.cbcurso.SelectedIndexChanged += new System.EventHandler(this.cbcurso_SelectedIndexChanged);
            // 
            // FmIncluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(257, 224);
            this.Controls.Add(this.cbcurso);
            this.Controls.Add(this.btgerarmatricula);
            this.Controls.Add(this.btcadastraraluno);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmIncluirAluno";
            this.Text = "Incluir Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btcadastraraluno;
        private System.Windows.Forms.Button btgerarmatricula;
        private System.Windows.Forms.ComboBox cbcurso;
    }
}