namespace ContagemInsulina
{
    partial class Alimentos
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
            this.alimento1 = new System.Windows.Forms.Button();
            this.alimento2 = new System.Windows.Forms.Button();
            this.alimento6 = new System.Windows.Forms.Button();
            this.alimento3 = new System.Windows.Forms.Button();
            this.alimento4 = new System.Windows.Forms.Button();
            this.alimento5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alimento1
            // 
            this.alimento1.Location = new System.Drawing.Point(24, 25);
            this.alimento1.Name = "alimento1";
            this.alimento1.Size = new System.Drawing.Size(102, 36);
            this.alimento1.TabIndex = 0;
            this.alimento1.Text = "Café da manhã";
            this.alimento1.UseVisualStyleBackColor = true;
            this.alimento1.Click += new System.EventHandler(this.alimento1_Click);
            // 
            // alimento2
            // 
            this.alimento2.Location = new System.Drawing.Point(132, 25);
            this.alimento2.Name = "alimento2";
            this.alimento2.Size = new System.Drawing.Size(102, 36);
            this.alimento2.TabIndex = 1;
            this.alimento2.Text = "Lanche da manhã";
            this.alimento2.UseVisualStyleBackColor = true;
            this.alimento2.Click += new System.EventHandler(this.alimento2_Click);
            // 
            // alimento6
            // 
            this.alimento6.Location = new System.Drawing.Point(240, 77);
            this.alimento6.Name = "alimento6";
            this.alimento6.Size = new System.Drawing.Size(102, 36);
            this.alimento6.TabIndex = 2;
            this.alimento6.Text = "Lanche da noite";
            this.alimento6.UseVisualStyleBackColor = true;
            this.alimento6.Click += new System.EventHandler(this.alimento6_Click);
            // 
            // alimento3
            // 
            this.alimento3.Location = new System.Drawing.Point(240, 25);
            this.alimento3.Name = "alimento3";
            this.alimento3.Size = new System.Drawing.Size(102, 36);
            this.alimento3.TabIndex = 2;
            this.alimento3.Text = "Almoço";
            this.alimento3.UseVisualStyleBackColor = true;
            this.alimento3.Click += new System.EventHandler(this.alimento3_Click);
            // 
            // alimento4
            // 
            this.alimento4.Location = new System.Drawing.Point(24, 77);
            this.alimento4.Name = "alimento4";
            this.alimento4.Size = new System.Drawing.Size(102, 36);
            this.alimento4.TabIndex = 2;
            this.alimento4.Text = "Lanche da tarde";
            this.alimento4.UseVisualStyleBackColor = true;
            this.alimento4.Click += new System.EventHandler(this.alimento4_Click);
            // 
            // alimento5
            // 
            this.alimento5.Location = new System.Drawing.Point(132, 77);
            this.alimento5.Name = "alimento5";
            this.alimento5.Size = new System.Drawing.Size(102, 36);
            this.alimento5.TabIndex = 2;
            this.alimento5.Text = "Jantar";
            this.alimento5.UseVisualStyleBackColor = true;
            this.alimento5.Click += new System.EventHandler(this.alimento5_Click);
            // 
            // Alimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 144);
            this.Controls.Add(this.alimento3);
            this.Controls.Add(this.alimento4);
            this.Controls.Add(this.alimento5);
            this.Controls.Add(this.alimento6);
            this.Controls.Add(this.alimento2);
            this.Controls.Add(this.alimento1);
            this.Name = "Alimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alimentos";
            this.Load += new System.EventHandler(this.Alimentos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button alimento1;
        private System.Windows.Forms.Button alimento2;
        private System.Windows.Forms.Button alimento6;
        private System.Windows.Forms.Button alimento3;
        private System.Windows.Forms.Button alimento4;
        private System.Windows.Forms.Button alimento5;
    }
}