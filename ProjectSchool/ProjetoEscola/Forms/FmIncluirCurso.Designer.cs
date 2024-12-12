namespace ProjetoEscola.Forms
{
    partial class FmIncluirCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmIncluirCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttarefas = new System.Windows.Forms.TextBox();
            this.btcadastrarcurso = new System.Windows.Forms.Button();
            this.txtnomecurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarefa:";
            // 
            // txttarefas
            // 
            this.txttarefas.Location = new System.Drawing.Point(164, 106);
            this.txttarefas.Name = "txttarefas";
            this.txttarefas.Size = new System.Drawing.Size(138, 20);
            this.txttarefas.TabIndex = 4;
            this.txttarefas.TextChanged += new System.EventHandler(this.txttarefas_TextChanged);
            // 
            // btcadastrarcurso
            // 
            this.btcadastrarcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrarcurso.Location = new System.Drawing.Point(164, 165);
            this.btcadastrarcurso.Name = "btcadastrarcurso";
            this.btcadastrarcurso.Size = new System.Drawing.Size(138, 29);
            this.btcadastrarcurso.TabIndex = 5;
            this.btcadastrarcurso.Text = "Salvar";
            this.btcadastrarcurso.UseVisualStyleBackColor = true;
            this.btcadastrarcurso.Click += new System.EventHandler(this.btcadastrarcurso_Click);
            // 
            // txtnomecurso
            // 
            this.txtnomecurso.Location = new System.Drawing.Point(164, 52);
            this.txtnomecurso.Name = "txtnomecurso";
            this.txtnomecurso.Size = new System.Drawing.Size(138, 20);
            this.txtnomecurso.TabIndex = 6;
            this.txtnomecurso.TextChanged += new System.EventHandler(this.txtnomecurso_TextChanged);
            // 
            // FmIncluirCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(319, 215);
            this.Controls.Add(this.txtnomecurso);
            this.Controls.Add(this.btcadastrarcurso);
            this.Controls.Add(this.txttarefas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmIncluirCurso";
            this.Text = "Incluir Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttarefas;
        private System.Windows.Forms.Button btcadastrarcurso;
        private System.Windows.Forms.TextBox txtnomecurso;
    }
}