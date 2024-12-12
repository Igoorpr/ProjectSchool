namespace ProjetoEscola.Forms
{
    partial class FmGerenciarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGerenciarCursos));
            this.rbtodoscursos = new System.Windows.Forms.RadioButton();
            this.txcurso = new System.Windows.Forms.TextBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.dgtcarregarcursos = new System.Windows.Forms.DataGridView();
            this.coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtexcluir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtcarregarcursos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtodoscursos
            // 
            this.rbtodoscursos.AutoSize = true;
            this.rbtodoscursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtodoscursos.Location = new System.Drawing.Point(33, 12);
            this.rbtodoscursos.Name = "rbtodoscursos";
            this.rbtodoscursos.Size = new System.Drawing.Size(129, 20);
            this.rbtodoscursos.TabIndex = 1;
            this.rbtodoscursos.TabStop = true;
            this.rbtodoscursos.Text = "Todos os Cursos";
            this.rbtodoscursos.UseVisualStyleBackColor = true;
            this.rbtodoscursos.CheckedChanged += new System.EventHandler(this.rbtodoscursos_CheckedChanged);
            // 
            // txcurso
            // 
            this.txcurso.Location = new System.Drawing.Point(171, 50);
            this.txcurso.Name = "txcurso";
            this.txcurso.Size = new System.Drawing.Size(118, 20);
            this.txcurso.TabIndex = 2;
            this.txcurso.TextChanged += new System.EventHandler(this.txcurso_TextChanged);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Location = new System.Drawing.Point(301, 50);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(100, 23);
            this.btpesquisar.TabIndex = 3;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // dgtcarregarcursos
            // 
            this.dgtcarregarcursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtcarregarcursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna,
            this.Column1});
            this.dgtcarregarcursos.Location = new System.Drawing.Point(33, 126);
            this.dgtcarregarcursos.Name = "dgtcarregarcursos";
            this.dgtcarregarcursos.Size = new System.Drawing.Size(256, 254);
            this.dgtcarregarcursos.TabIndex = 4;
            this.dgtcarregarcursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtcarregarcursos_CellContentClick);
            // 
            // coluna
            // 
            this.coluna.HeaderText = "Cursos";
            this.coluna.Name = "coluna";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarefas";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar por Nome:";
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.Location = new System.Drawing.Point(301, 87);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(100, 23);
            this.btexcluir.TabIndex = 6;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(301, 126);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(100, 23);
            this.btvoltar.TabIndex = 7;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Excluir Curso:";
            // 
            // txtexcluir
            // 
            this.txtexcluir.Location = new System.Drawing.Point(171, 87);
            this.txtexcluir.Name = "txtexcluir";
            this.txtexcluir.Size = new System.Drawing.Size(118, 20);
            this.txtexcluir.TabIndex = 9;
            this.txtexcluir.TextChanged += new System.EventHandler(this.txtexcluir_TextChanged);
            // 
            // FmGerenciarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(413, 392);
            this.Controls.Add(this.txtexcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtcarregarcursos);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txcurso);
            this.Controls.Add(this.rbtodoscursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmGerenciarCursos";
            this.Text = "Gerenciar Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgtcarregarcursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtodoscursos;
        private System.Windows.Forms.TextBox txcurso;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.DataGridView dgtcarregarcursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtexcluir;
    }
}