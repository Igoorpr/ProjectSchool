namespace ProjetoEscola.Forms
{
    partial class FmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCadastrar));
            this.btCadastrarCursos = new System.Windows.Forms.Button();
            this.btCadastrarAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarCursos
            // 
            this.btCadastrarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCursos.Location = new System.Drawing.Point(53, 139);
            this.btCadastrarCursos.Name = "btCadastrarCursos";
            this.btCadastrarCursos.Size = new System.Drawing.Size(185, 54);
            this.btCadastrarCursos.TabIndex = 1;
            this.btCadastrarCursos.Text = "Cursos";
            this.btCadastrarCursos.UseVisualStyleBackColor = true;
            this.btCadastrarCursos.Click += new System.EventHandler(this.btCadastrarCursos_Click);
            // 
            // btCadastrarAlunos
            // 
            this.btCadastrarAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarAlunos.Location = new System.Drawing.Point(53, 45);
            this.btCadastrarAlunos.Name = "btCadastrarAlunos";
            this.btCadastrarAlunos.Size = new System.Drawing.Size(185, 51);
            this.btCadastrarAlunos.TabIndex = 2;
            this.btCadastrarAlunos.Text = "Alunos";
            this.btCadastrarAlunos.UseVisualStyleBackColor = true;
            this.btCadastrarAlunos.Click += new System.EventHandler(this.btCadastrarAlunos_Click);
            // 
            // FmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(299, 230);
            this.Controls.Add(this.btCadastrarAlunos);
            this.Controls.Add(this.btCadastrarCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmCadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.CadastrarAluno_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCadastrarCursos;
        private System.Windows.Forms.Button btCadastrarAlunos;
    }
}