namespace ProjetoEscola.Forms
{
    partial class FmEmitirCertificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmEmitirCertificado));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.btemitircertificado = new System.Windows.Forms.Button();
            this.dgtalunos = new System.Windows.Forms.DataGridView();
            this.coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btvoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(25, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos os Alunos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número da Matrícula:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(163, 29);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(118, 20);
            this.txtmatricula.TabIndex = 7;
            // 
            // btemitircertificado
            // 
            this.btemitircertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btemitircertificado.Location = new System.Drawing.Point(370, 29);
            this.btemitircertificado.Name = "btemitircertificado";
            this.btemitircertificado.Size = new System.Drawing.Size(100, 23);
            this.btemitircertificado.TabIndex = 8;
            this.btemitircertificado.Text = "Emitir ";
            this.btemitircertificado.UseVisualStyleBackColor = true;
            this.btemitircertificado.Click += new System.EventHandler(this.btemitircertificado_Click);
            // 
            // dgtalunos
            // 
            this.dgtalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtalunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna,
            this.Column2,
            this.Nota,
            this.Column1});
            this.dgtalunos.Location = new System.Drawing.Point(25, 121);
            this.dgtalunos.Name = "dgtalunos";
            this.dgtalunos.Size = new System.Drawing.Size(445, 206);
            this.dgtalunos.TabIndex = 9;
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
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(370, 75);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(100, 23);
            this.btvoltar.TabIndex = 10;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // FmEmitirCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(499, 339);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.dgtalunos);
            this.Controls.Add(this.btemitircertificado);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmEmitirCertificado";
            this.Text = "Emitir Certificado";
            ((System.ComponentModel.ISupportInitialize)(this.dgtalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Button btemitircertificado;
        private System.Windows.Forms.DataGridView dgtalunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btvoltar;
    }
}