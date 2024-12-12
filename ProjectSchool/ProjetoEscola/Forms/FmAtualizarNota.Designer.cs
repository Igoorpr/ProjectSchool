namespace ProjetoEscola.Forms
{
    partial class FmAtualizarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAtualizarNota));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.btatualizarnota = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número da matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nota:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(188, 31);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(118, 20);
            this.txtmatricula.TabIndex = 16;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(188, 74);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(118, 20);
            this.txtnota.TabIndex = 17;
            // 
            // btatualizarnota
            // 
            this.btatualizarnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizarnota.Location = new System.Drawing.Point(188, 113);
            this.btatualizarnota.Name = "btatualizarnota";
            this.btatualizarnota.Size = new System.Drawing.Size(118, 23);
            this.btatualizarnota.TabIndex = 18;
            this.btatualizarnota.Text = "Atualizar";
            this.btatualizarnota.UseVisualStyleBackColor = true;
            this.btatualizarnota.Click += new System.EventHandler(this.btatualizarnota_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(64, 113);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(118, 23);
            this.btvoltar.TabIndex = 19;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // FmAtualizarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(332, 162);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btatualizarnota);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmAtualizarNota";
            this.Text = "Atualizar Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Button btatualizarnota;
        private System.Windows.Forms.Button btvoltar;
    }
}