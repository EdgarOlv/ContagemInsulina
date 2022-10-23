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
            this.label10 = new System.Windows.Forms.Label();
            this.resultConsulta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.glicemiaAlvo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.fs = new System.Windows.Forms.TextBox();
            this.glicemiaAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aplicarInsulina = new System.Windows.Forms.Label();
            this.checkBoxCorrecao = new System.Windows.Forms.CheckBox();
            this.checkBoxAlimentar = new System.Windows.Forms.CheckBox();
            this.checkBoxMalhar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Result Consulta:";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consulta DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Glicêmia alvo:";
            // 
            // glicemiaAlvo
            // 
            this.glicemiaAlvo.Location = new System.Drawing.Point(307, 66);
            this.glicemiaAlvo.Name = "glicemiaAlvo";
            this.glicemiaAlvo.Size = new System.Drawing.Size(26, 20);
            this.glicemiaAlvo.TabIndex = 25;
            this.glicemiaAlvo.Text = "110";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "F.S.:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(170, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 37);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // fs
            // 
            this.fs.Location = new System.Drawing.Point(163, 66);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(26, 20);
            this.fs.TabIndex = 23;
            this.fs.Text = "37";
            // 
            // glicemiaAtual
            // 
            this.glicemiaAtual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.glicemiaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glicemiaAtual.Location = new System.Drawing.Point(199, 110);
            this.glicemiaAtual.Name = "glicemiaAtual";
            this.glicemiaAtual.Size = new System.Drawing.Size(160, 22);
            this.glicemiaAtual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 110);
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
            this.aplicarInsulina.Location = new System.Drawing.Point(172, 256);
            this.aplicarInsulina.Name = "aplicarInsulina";
            this.aplicarInsulina.Size = new System.Drawing.Size(31, 24);
            this.aplicarInsulina.TabIndex = 20;
            this.aplicarInsulina.Text = "---";
            // 
            // checkBoxCorrecao
            // 
            this.checkBoxCorrecao.AutoSize = true;
            this.checkBoxCorrecao.Location = new System.Drawing.Point(105, 152);
            this.checkBoxCorrecao.Name = "checkBoxCorrecao";
            this.checkBoxCorrecao.Size = new System.Drawing.Size(69, 17);
            this.checkBoxCorrecao.TabIndex = 27;
            this.checkBoxCorrecao.Text = "Correção";
            this.checkBoxCorrecao.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlimentar
            // 
            this.checkBoxAlimentar.AutoSize = true;
            this.checkBoxAlimentar.Location = new System.Drawing.Point(193, 152);
            this.checkBoxAlimentar.Name = "checkBoxAlimentar";
            this.checkBoxAlimentar.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAlimentar.TabIndex = 28;
            this.checkBoxAlimentar.Text = "Alimentar";
            this.checkBoxAlimentar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMalhar
            // 
            this.checkBoxMalhar.AutoSize = true;
            this.checkBoxMalhar.Location = new System.Drawing.Point(279, 152);
            this.checkBoxMalhar.Name = "checkBoxMalhar";
            this.checkBoxMalhar.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMalhar.TabIndex = 29;
            this.checkBoxMalhar.Text = "Malhar";
            this.checkBoxMalhar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(445, 349);
            this.Controls.Add(this.checkBoxMalhar);
            this.Controls.Add(this.checkBoxAlimentar);
            this.Controls.Add(this.checkBoxCorrecao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.glicemiaAlvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.fs);
            this.Controls.Add(this.glicemiaAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aplicarInsulina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultConsulta);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Insulina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label resultConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox glicemiaAlvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox fs;
        private System.Windows.Forms.TextBox glicemiaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aplicarInsulina;
        private System.Windows.Forms.CheckBox checkBoxCorrecao;
        private System.Windows.Forms.CheckBox checkBoxAlimentar;
        private System.Windows.Forms.CheckBox checkBoxMalhar;
    }
}

