namespace ProjetoEscola.Forms
{
    partial class FmGerenciarAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGerenciarAlunos));
            this.rbtodosalunos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgtalunos = new System.Windows.Forms.DataGridView();
            this.coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btpesquisarnome = new System.Windows.Forms.Button();
            this.btpesquisarcurso = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtpesquisarcurso = new System.Windows.Forms.TextBox();
            this.btvoltar = new System.Windows.Forms.Button();
            this.txtexcluiraluno = new System.Windows.Forms.TextBox();
            this.btexcluiraluno = new System.Windows.Forms.Button();
            this.btatualizarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtodosalunos
            // 
            this.rbtodosalunos.AutoSize = true;
            this.rbtodosalunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtodosalunos.Location = new System.Drawing.Point(40, 156);
            this.rbtodosalunos.Name = "rbtodosalunos";
            this.rbtodosalunos.Size = new System.Drawing.Size(128, 20);
            this.rbtodosalunos.TabIndex = 2;
            this.rbtodosalunos.TabStop = true;
            this.rbtodosalunos.Text = "Todos os Alunos";
            this.rbtodosalunos.UseVisualStyleBackColor = true;
            this.rbtodosalunos.CheckedChanged += new System.EventHandler(this.rbtodosalunos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar por Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Excluir Aluno Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pesquisar por Curso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Atualizar Nota:";
            // 
            // dgtalunos
            // 
            this.dgtalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtalunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna,
            this.Column2,
            this.Nota,
            this.Column1});
            this.dgtalunos.Location = new System.Drawing.Point(40, 182);
            this.dgtalunos.Name = "dgtalunos";
            this.dgtalunos.Size = new System.Drawing.Size(417, 206);
            this.dgtalunos.TabIndex = 12;
            this.dgtalunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtalunos_CellContentClick);
            // 
            // coluna
            // 
            this.coluna.HeaderText = "Matrícula";
            this.coluna.Name = "coluna";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Curso";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nota";
            this.Column1.Name = "Column1";
            // 
            // btpesquisarnome
            // 
            this.btpesquisarnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisarnome.Location = new System.Drawing.Point(313, 18);
            this.btpesquisarnome.Name = "btpesquisarnome";
            this.btpesquisarnome.Size = new System.Drawing.Size(144, 23);
            this.btpesquisarnome.TabIndex = 13;
            this.btpesquisarnome.Text = "Pesquisar Nome";
            this.btpesquisarnome.UseVisualStyleBackColor = true;
            this.btpesquisarnome.Click += new System.EventHandler(this.btpesquisarnome_Click);
            // 
            // btpesquisarcurso
            // 
            this.btpesquisarcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisarcurso.Location = new System.Drawing.Point(313, 55);
            this.btpesquisarcurso.Name = "btpesquisarcurso";
            this.btpesquisarcurso.Size = new System.Drawing.Size(144, 23);
            this.btpesquisarcurso.TabIndex = 14;
            this.btpesquisarcurso.Text = "Pesquisar Curso";
            this.btpesquisarcurso.UseVisualStyleBackColor = true;
            this.btpesquisarcurso.Click += new System.EventHandler(this.btpesquisarcurso_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(180, 18);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(118, 20);
            this.txtnome.TabIndex = 15;
            // 
            // txtpesquisarcurso
            // 
            this.txtpesquisarcurso.Location = new System.Drawing.Point(180, 55);
            this.txtpesquisarcurso.Name = "txtpesquisarcurso";
            this.txtpesquisarcurso.Size = new System.Drawing.Size(118, 20);
            this.txtpesquisarcurso.TabIndex = 16;
            this.txtpesquisarcurso.TextChanged += new System.EventHandler(this.txtpesquisarcurso_TextChanged);
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(357, 153);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(100, 23);
            this.btvoltar.TabIndex = 17;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // txtexcluiraluno
            // 
            this.txtexcluiraluno.Location = new System.Drawing.Point(180, 121);
            this.txtexcluiraluno.Name = "txtexcluiraluno";
            this.txtexcluiraluno.Size = new System.Drawing.Size(118, 20);
            this.txtexcluiraluno.TabIndex = 18;
            // 
            // btexcluiraluno
            // 
            this.btexcluiraluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluiraluno.Location = new System.Drawing.Point(313, 121);
            this.btexcluiraluno.Name = "btexcluiraluno";
            this.btexcluiraluno.Size = new System.Drawing.Size(144, 23);
            this.btexcluiraluno.TabIndex = 19;
            this.btexcluiraluno.Text = "Excluir Aluno";
            this.btexcluiraluno.UseVisualStyleBackColor = true;
            this.btexcluiraluno.Click += new System.EventHandler(this.btexcluiraluno_Click);
            // 
            // btatualizarNota
            // 
            this.btatualizarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizarNota.Location = new System.Drawing.Point(313, 90);
            this.btatualizarNota.Name = "btatualizarNota";
            this.btatualizarNota.Size = new System.Drawing.Size(144, 23);
            this.btatualizarNota.TabIndex = 20;
            this.btatualizarNota.Text = "Atualizar Nota";
            this.btatualizarNota.UseVisualStyleBackColor = true;
            this.btatualizarNota.Click += new System.EventHandler(this.btatualizarNota_Click);
            // 
            // FmGerenciarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(485, 389);
            this.Controls.Add(this.btatualizarNota);
            this.Controls.Add(this.btexcluiraluno);
            this.Controls.Add(this.txtexcluiraluno);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.txtpesquisarcurso);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btpesquisarcurso);
            this.Controls.Add(this.btpesquisarnome);
            this.Controls.Add(this.dgtalunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtodosalunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmGerenciarAlunos";
            this.Text = "Gerenciar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgtalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtodosalunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgtalunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btpesquisarnome;
        private System.Windows.Forms.Button btpesquisarcurso;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtpesquisarcurso;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.TextBox txtexcluiraluno;
        private System.Windows.Forms.Button btexcluiraluno;
        private System.Windows.Forms.Button btatualizarNota;
    }
}