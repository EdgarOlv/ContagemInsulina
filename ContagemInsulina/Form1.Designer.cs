namespace ContagemInsulina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultConsulta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.glicemiaAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aplicarInsulina = new System.Windows.Forms.Label();
            this.checkBoxCorrecao = new System.Windows.Forms.CheckBox();
            this.checkBoxAlimentar = new System.Windows.Forms.CheckBox();
            this.checkBoxMalhar = new System.Windows.Forms.CheckBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultConsulta
            // 
            this.resultConsulta.AutoSize = true;
            this.resultConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultConsulta.Location = new System.Drawing.Point(281, 314);
            this.resultConsulta.Name = "resultConsulta";
            this.resultConsulta.Size = new System.Drawing.Size(0, 20);
            this.resultConsulta.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(174, 164);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 37);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // glicemiaAtual
            // 
            this.glicemiaAtual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.glicemiaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glicemiaAtual.Location = new System.Drawing.Point(203, 86);
            this.glicemiaAtual.Name = "glicemiaAtual";
            this.glicemiaAtual.Size = new System.Drawing.Size(160, 22);
            this.glicemiaAtual.TabIndex = 0;
            this.glicemiaAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glicemiaAtual_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Glicêmia atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Calculadora de Insulina";
            // 
            // aplicarInsulina
            // 
            this.aplicarInsulina.AutoSize = true;
            this.aplicarInsulina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplicarInsulina.Location = new System.Drawing.Point(170, 226);
            this.aplicarInsulina.Name = "aplicarInsulina";
            this.aplicarInsulina.Size = new System.Drawing.Size(31, 24);
            this.aplicarInsulina.TabIndex = 20;
            this.aplicarInsulina.Text = "---";
            // 
            // checkBoxCorrecao
            // 
            this.checkBoxCorrecao.AutoSize = true;
            this.checkBoxCorrecao.Location = new System.Drawing.Point(109, 128);
            this.checkBoxCorrecao.Name = "checkBoxCorrecao";
            this.checkBoxCorrecao.Size = new System.Drawing.Size(69, 17);
            this.checkBoxCorrecao.TabIndex = 27;
            this.checkBoxCorrecao.Text = "Correção";
            this.checkBoxCorrecao.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlimentar
            // 
            this.checkBoxAlimentar.AutoSize = true;
            this.checkBoxAlimentar.Location = new System.Drawing.Point(197, 128);
            this.checkBoxAlimentar.Name = "checkBoxAlimentar";
            this.checkBoxAlimentar.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAlimentar.TabIndex = 28;
            this.checkBoxAlimentar.Text = "Alimentar";
            this.checkBoxAlimentar.UseVisualStyleBackColor = true;
            this.checkBoxAlimentar.CheckedChanged += new System.EventHandler(this.checkBoxAlimentar_CheckedChanged);
            // 
            // checkBoxMalhar
            // 
            this.checkBoxMalhar.AutoSize = true;
            this.checkBoxMalhar.Location = new System.Drawing.Point(283, 128);
            this.checkBoxMalhar.Name = "checkBoxMalhar";
            this.checkBoxMalhar.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMalhar.TabIndex = 29;
            this.checkBoxMalhar.Text = "Malhar";
            this.checkBoxMalhar.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(388, 31);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(48, 35);
            this.btnConfig.TabIndex = 30;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(12, 263);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(17, 24);
            this.a.TabIndex = 31;
            this.a.Text = "-";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(416, 263);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(17, 24);
            this.b.TabIndex = 32;
            this.b.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(445, 296);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.checkBoxMalhar);
            this.Controls.Add(this.checkBoxAlimentar);
            this.Controls.Add(this.checkBoxCorrecao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.glicemiaAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aplicarInsulina);
            this.Controls.Add(this.resultConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Insulina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resultConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox glicemiaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aplicarInsulina;
        private System.Windows.Forms.CheckBox checkBoxCorrecao;
        private System.Windows.Forms.CheckBox checkBoxAlimentar;
        private System.Windows.Forms.CheckBox checkBoxMalhar;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
    }
}

