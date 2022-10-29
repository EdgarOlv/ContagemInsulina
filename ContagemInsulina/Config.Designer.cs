namespace ContagemInsulina
{
    partial class Config
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
            this.label9 = new System.Windows.Forms.Label();
            this.glicemiaAlvo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Glicêmia alvo:";
            // 
            // glicemiaAlvo
            // 
            this.glicemiaAlvo.Location = new System.Drawing.Point(133, 59);
            this.glicemiaAlvo.Name = "glicemiaAlvo";
            this.glicemiaAlvo.Size = new System.Drawing.Size(26, 20);
            this.glicemiaAlvo.TabIndex = 29;
            this.glicemiaAlvo.Text = "110";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "F.S.:";
            // 
            // fs
            // 
            this.fs.Location = new System.Drawing.Point(69, 36);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(26, 20);
            this.fs.TabIndex = 27;
            this.fs.Text = "37";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 240);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.glicemiaAlvo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fs);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox glicemiaAlvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fs;
    }
}