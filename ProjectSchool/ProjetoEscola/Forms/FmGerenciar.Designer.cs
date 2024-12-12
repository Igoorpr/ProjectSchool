namespace ProjetoEscola.Forms
{
    partial class FmGerenciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGerenciar));
            this.btAlunos = new System.Windows.Forms.Button();
            this.btCursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAlunos
            // 
            this.btAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlunos.Location = new System.Drawing.Point(72, 38);
            this.btAlunos.Name = "btAlunos";
            this.btAlunos.Size = new System.Drawing.Size(126, 33);
            this.btAlunos.TabIndex = 0;
            this.btAlunos.Text = "Alunos";
            this.btAlunos.UseVisualStyleBackColor = true;
            this.btAlunos.Click += new System.EventHandler(this.btAlunos_Click);
            // 
            // btCursos
            // 
            this.btCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCursos.Location = new System.Drawing.Point(72, 102);
            this.btCursos.Name = "btCursos";
            this.btCursos.Size = new System.Drawing.Size(126, 33);
            this.btCursos.TabIndex = 1;
            this.btCursos.Text = "Cursos";
            this.btCursos.UseVisualStyleBackColor = true;
            this.btCursos.Click += new System.EventHandler(this.bnExcluirCursos_Click);
            // 
            // FmGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(266, 174);
            this.Controls.Add(this.btCursos);
            this.Controls.Add(this.btAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmGerenciar";
            this.Text = "Gerenciar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAlunos;
        private System.Windows.Forms.Button btCursos;
    }
}