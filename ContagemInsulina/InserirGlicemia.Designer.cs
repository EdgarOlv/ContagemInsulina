namespace ContagemInsulina
{
    partial class InserirGlicemia
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserirGlicemia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorGlicemia = new System.Windows.Forms.TextBox();
            this.dataGlicemia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Inserir Glicêmia";
            // 
            // btnInserirGlicemia
            // 
            this.btnInserirGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirGlicemia.Location = new System.Drawing.Point(130, 171);
            this.btnInserirGlicemia.Name = "btnInserirGlicemia";
            this.btnInserirGlicemia.Size = new System.Drawing.Size(137, 37);
            this.btnInserirGlicemia.TabIndex = 37;
            this.btnInserirGlicemia.Text = "Inserir registro";
            this.btnInserirGlicemia.UseVisualStyleBackColor = true;
            this.btnInserirGlicemia.Click += new System.EventHandler(this.btnInserirGlicemia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Data da coleta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Valor da glicêmia:";
            // 
            // valorGlicemia
            // 
            this.valorGlicemia.Location = new System.Drawing.Point(167, 74);
            this.valorGlicemia.Name = "valorGlicemia";
            this.valorGlicemia.Size = new System.Drawing.Size(87, 20);
            this.valorGlicemia.TabIndex = 33;
            // 
            // dataGlicemia
            // 
            this.dataGlicemia.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dataGlicemia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataGlicemia.Location = new System.Drawing.Point(154, 107);
            this.dataGlicemia.Name = "dataGlicemia";
            this.dataGlicemia.Size = new System.Drawing.Size(151, 20);
            this.dataGlicemia.TabIndex = 39;
            // 
            // InserirGlicemia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(391, 238);
            this.Controls.Add(this.dataGlicemia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserirGlicemia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorGlicemia);
            this.Name = "InserirGlicemia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserirGlicemia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserirGlicemia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorGlicemia;
        private System.Windows.Forms.DateTimePicker dataGlicemia;
    }
}