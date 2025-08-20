namespace Temperatura
{
    partial class Form1
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
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificarClima = new System.Windows.Forms.Button();
            this.pibClima = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibClima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(341, 60);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 0;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(309, 104);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(184, 37);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manipulação de PictureBox";
            // 
            // btnVerificarClima
            // 
            this.btnVerificarClima.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarClima.Location = new System.Drawing.Point(274, 157);
            this.btnVerificarClima.Name = "btnVerificarClima";
            this.btnVerificarClima.Size = new System.Drawing.Size(268, 43);
            this.btnVerificarClima.TabIndex = 3;
            this.btnVerificarClima.Text = "Verificar Clima ";
            this.btnVerificarClima.UseVisualStyleBackColor = true;
            this.btnVerificarClima.Click += new System.EventHandler(this.btnVerificarClima_Click);
            // 
            // pibClima
            // 
            this.pibClima.Location = new System.Drawing.Point(274, 224);
            this.pibClima.Name = "pibClima";
            this.pibClima.Size = new System.Drawing.Size(268, 174);
            this.pibClima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibClima.TabIndex = 4;
            this.pibClima.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(246, 428);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pibClima);
            this.Controls.Add(this.btnVerificarClima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.txtTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pibClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificarClima;
        private System.Windows.Forms.PictureBox pibClima;
        private System.Windows.Forms.Label lblData;
    }
}

