namespace ContagemInsulina
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnGlicemia = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.totalAplicar = new System.Windows.Forms.Label();
            this.aplicarInsulina = new System.Windows.Forms.Label();
            this.refeicao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxMalhar = new System.Windows.Forms.CheckBox();
            this.checkBoxAlimentar = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrecao = new System.Windows.Forms.CheckBox();
            this.glicemiaAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.salvarConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.carb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.glicemiaAlvo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fs = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(608, 40);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contagem de Insulina";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(473, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 34);
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(519, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 34);
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(565, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 34);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.btnRelatorio);
            this.panelMenu.Controls.Add(this.btnGlicemia);
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(141, 343);
            this.panelMenu.TabIndex = 1;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 179);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(140, 61);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.Text = "           Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnGlicemia
            // 
            this.btnGlicemia.FlatAppearance.BorderSize = 0;
            this.btnGlicemia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGlicemia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlicemia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlicemia.ForeColor = System.Drawing.Color.White;
            this.btnGlicemia.Image = ((System.Drawing.Image)(resources.GetObject("btnGlicemia.Image")));
            this.btnGlicemia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGlicemia.Location = new System.Drawing.Point(0, 42);
            this.btnGlicemia.Name = "btnGlicemia";
            this.btnGlicemia.Size = new System.Drawing.Size(141, 65);
            this.btnGlicemia.TabIndex = 1;
            this.btnGlicemia.Text = "           Glicemia";
            this.btnGlicemia.UseVisualStyleBackColor = true;
            this.btnGlicemia.Click += new System.EventHandler(this.btnGlicemia_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 113);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(141, 60);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "           Config.";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.tabControl1);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(141, 40);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(467, 343);
            this.panelConteudo.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 10);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.totalAplicar);
            this.tabPage1.Controls.Add(this.aplicarInsulina);
            this.tabPage1.Controls.Add(this.refeicao);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.checkBoxMalhar);
            this.tabPage1.Controls.Add(this.checkBoxAlimentar);
            this.tabPage1.Controls.Add(this.checkBoxCorrecao);
            this.tabPage1.Controls.Add(this.glicemiaAtual);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // totalAplicar
            // 
            this.totalAplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalAplicar.AutoSize = true;
            this.totalAplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalAplicar.Location = new System.Drawing.Point(89, 280);
            this.totalAplicar.Name = "totalAplicar";
            this.totalAplicar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalAplicar.Size = new System.Drawing.Size(0, 21);
            this.totalAplicar.TabIndex = 43;
            this.totalAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aplicarInsulina
            // 
            this.aplicarInsulina.AutoSize = true;
            this.aplicarInsulina.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aplicarInsulina.Location = new System.Drawing.Point(127, 252);
            this.aplicarInsulina.Name = "aplicarInsulina";
            this.aplicarInsulina.Size = new System.Drawing.Size(28, 21);
            this.aplicarInsulina.TabIndex = 42;
            this.aplicarInsulina.Text = "---";
            // 
            // refeicao
            // 
            this.refeicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.refeicao.Location = new System.Drawing.Point(202, 137);
            this.refeicao.Name = "refeicao";
            this.refeicao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.refeicao.Size = new System.Drawing.Size(195, 24);
            this.refeicao.TabIndex = 41;
            this.refeicao.Text = "---";
            this.refeicao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(136, 179);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(186, 57);
            this.btnCalcular.TabIndex = 37;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(88, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Refeição atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(36, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Consultar:";
            // 
            // checkBoxMalhar
            // 
            this.checkBoxMalhar.AutoSize = true;
            this.checkBoxMalhar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxMalhar.Location = new System.Drawing.Point(328, 100);
            this.checkBoxMalhar.Name = "checkBoxMalhar";
            this.checkBoxMalhar.Size = new System.Drawing.Size(69, 23);
            this.checkBoxMalhar.TabIndex = 32;
            this.checkBoxMalhar.Text = "Treinar";
            this.checkBoxMalhar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlimentar
            // 
            this.checkBoxAlimentar.AutoSize = true;
            this.checkBoxAlimentar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxAlimentar.Location = new System.Drawing.Point(235, 100);
            this.checkBoxAlimentar.Name = "checkBoxAlimentar";
            this.checkBoxAlimentar.Size = new System.Drawing.Size(87, 23);
            this.checkBoxAlimentar.TabIndex = 31;
            this.checkBoxAlimentar.Text = "Alimentar";
            this.checkBoxAlimentar.UseVisualStyleBackColor = true;
            this.checkBoxAlimentar.CheckedChanged += new System.EventHandler(this.checkBoxAlimentar_CheckedChanged_1);
            // 
            // checkBoxCorrecao
            // 
            this.checkBoxCorrecao.AutoSize = true;
            this.checkBoxCorrecao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBoxCorrecao.Location = new System.Drawing.Point(147, 100);
            this.checkBoxCorrecao.Name = "checkBoxCorrecao";
            this.checkBoxCorrecao.Size = new System.Drawing.Size(83, 23);
            this.checkBoxCorrecao.TabIndex = 30;
            this.checkBoxCorrecao.Text = "Correção";
            this.checkBoxCorrecao.UseVisualStyleBackColor = true;
            // 
            // glicemiaAtual
            // 
            this.glicemiaAtual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.glicemiaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.glicemiaAtual.Location = new System.Drawing.Point(187, 40);
            this.glicemiaAtual.Name = "glicemiaAtual";
            this.glicemiaAtual.Size = new System.Drawing.Size(196, 26);
            this.glicemiaAtual.TabIndex = 19;
            this.glicemiaAtual.Click += new System.EventHandler(this.glicemiaAtual_Click);
            this.glicemiaAtual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glicemiaAtual_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Glicêmia atual:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.salvarConfig);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.carb);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.glicemiaAlvo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.fs);
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(332, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 51);
            this.button2.TabIndex = 46;
            this.button2.Text = "Config. Carboidratos";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // salvarConfig
            // 
            this.salvarConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.salvarConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.salvarConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salvarConfig.Location = new System.Drawing.Point(140, 230);
            this.salvarConfig.Name = "salvarConfig";
            this.salvarConfig.Size = new System.Drawing.Size(186, 63);
            this.salvarConfig.TabIndex = 45;
            this.salvarConfig.Text = "Salvar Configurações";
            this.salvarConfig.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(22, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 44;
            this.button1.Text = "Inserir glicose";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(56, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Relação carboidrato   1/";
            // 
            // carb
            // 
            this.carb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carb.Location = new System.Drawing.Point(280, 155);
            this.carb.Name = "carb";
            this.carb.Size = new System.Drawing.Size(134, 29);
            this.carb.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(56, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Glicêmia alvo:";
            // 
            // glicemiaAlvo
            // 
            this.glicemiaAlvo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.glicemiaAlvo.Location = new System.Drawing.Point(280, 106);
            this.glicemiaAlvo.Name = "glicemiaAlvo";
            this.glicemiaAlvo.Size = new System.Drawing.Size(134, 29);
            this.glicemiaAlvo.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(56, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Fator de Sensibilidade:";
            // 
            // fs
            // 
            this.fs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fs.Location = new System.Drawing.Point(280, 55);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(134, 29);
            this.fs.TabIndex = 36;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(456, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 383);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load_1);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelConteudo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btnGlicemia;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox glicemiaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxMalhar;
        private System.Windows.Forms.CheckBox checkBoxAlimentar;
        private System.Windows.Forms.CheckBox checkBoxCorrecao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalAplicar;
        private System.Windows.Forms.Label aplicarInsulina;
        private System.Windows.Forms.Label refeicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox glicemiaAlvo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button salvarConfig;
    }
}

