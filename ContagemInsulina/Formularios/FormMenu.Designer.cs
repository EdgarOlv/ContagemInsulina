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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.labelMediaGlicemia = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.btnAcionar = new System.Windows.Forms.Button();
            this.btnAbrirCarboidratos = new System.Windows.Forms.Button();
            this.salvarConfig = new System.Windows.Forms.Button();
            this.btnInserirGlicose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.carb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.glicemiaAlvo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fs = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateFinishFilter = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateStartFilter = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewAnalise = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInsulinaUsada = new System.Windows.Forms.Label();
            this.labelMediaGlicose = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalise)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelCabecalho.Controls.Add(this.labelMediaGlicemia);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(608, 40);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // labelMediaGlicemia
            // 
            this.labelMediaGlicemia.AutoSize = true;
            this.labelMediaGlicemia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaGlicemia.ForeColor = System.Drawing.Color.White;
            this.labelMediaGlicemia.Location = new System.Drawing.Point(51, 6);
            this.labelMediaGlicemia.Name = "labelMediaGlicemia";
            this.labelMediaGlicemia.Size = new System.Drawing.Size(228, 30);
            this.labelMediaGlicemia.TabIndex = 1;
            this.labelMediaGlicemia.Text = "Contagem de Insulina";
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
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 5);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 9);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // totalAplicar
            // 
            this.totalAplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalAplicar.AutoSize = true;
            this.totalAplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalAplicar.Location = new System.Drawing.Point(89, 283);
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
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.btnAcionar);
            this.tabPage2.Controls.Add(this.btnAbrirCarboidratos);
            this.tabPage2.Controls.Add(this.salvarConfig);
            this.tabPage2.Controls.Add(this.btnInserirGlicose);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.carb);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.glicemiaAlvo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.fs);
            this.tabPage2.Location = new System.Drawing.Point(4, 9);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(106, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 21);
            this.label15.TabIndex = 48;
            this.label15.Text = "---";
            // 
            // btnAcionar
            // 
            this.btnAcionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAcionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcionar.Location = new System.Drawing.Point(6, 10);
            this.btnAcionar.Name = "btnAcionar";
            this.btnAcionar.Size = new System.Drawing.Size(85, 39);
            this.btnAcionar.TabIndex = 47;
            this.btnAcionar.Text = "Acionar";
            this.btnAcionar.UseVisualStyleBackColor = false;
            // 
            // btnAbrirCarboidratos
            // 
            this.btnAbrirCarboidratos.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAbrirCarboidratos.FlatAppearance.BorderSize = 0;
            this.btnAbrirCarboidratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCarboidratos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirCarboidratos.Location = new System.Drawing.Point(332, 236);
            this.btnAbrirCarboidratos.Name = "btnAbrirCarboidratos";
            this.btnAbrirCarboidratos.Size = new System.Drawing.Size(108, 51);
            this.btnAbrirCarboidratos.TabIndex = 46;
            this.btnAbrirCarboidratos.Text = "Config. Carboidratos";
            this.btnAbrirCarboidratos.UseVisualStyleBackColor = false;
            this.btnAbrirCarboidratos.Click += new System.EventHandler(this.btnAbrirCarboidratos_Click);
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
            this.salvarConfig.Click += new System.EventHandler(this.salvarConfig_Click);
            // 
            // btnInserirGlicose
            // 
            this.btnInserirGlicose.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInserirGlicose.FlatAppearance.BorderSize = 0;
            this.btnInserirGlicose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirGlicose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserirGlicose.Location = new System.Drawing.Point(22, 236);
            this.btnInserirGlicose.Name = "btnInserirGlicose";
            this.btnInserirGlicose.Size = new System.Drawing.Size(112, 51);
            this.btnInserirGlicose.TabIndex = 44;
            this.btnInserirGlicose.Text = "Inserir glicose";
            this.btnInserirGlicose.UseVisualStyleBackColor = false;
            this.btnInserirGlicose.Click += new System.EventHandler(this.btnInserirGlicose_Click);
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
            this.tabPage3.Controls.Add(this.dateFinishFilter);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dateStartFilter);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 9);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(456, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateFinishFilter
            // 
            this.dateFinishFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinishFilter.Location = new System.Drawing.Point(342, 7);
            this.dateFinishFilter.Name = "dateFinishFilter";
            this.dateFinishFilter.Size = new System.Drawing.Size(83, 20);
            this.dateFinishFilter.TabIndex = 6;
            this.dateFinishFilter.ValueChanged += new System.EventHandler(this.dateFinishFilter_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Até";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(189, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "De";
            // 
            // dateStartFilter
            // 
            this.dateStartFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartFilter.Location = new System.Drawing.Point(220, 6);
            this.dateStartFilter.Name = "dateStartFilter";
            this.dateStartFilter.Size = new System.Drawing.Size(83, 20);
            this.dateStartFilter.TabIndex = 3;
            this.dateStartFilter.ValueChanged += new System.EventHandler(this.dateStartFilter_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Módulo de Relatórios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(6, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(447, 297);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(439, 271);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Relatório";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(439, 271);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Gráfico";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.LabelAngle = 45;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(414, 266);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewAnalise);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(439, 271);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Análise";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAnalise
            // 
            this.dataGridViewAnalise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalise.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewAnalise.Name = "dataGridViewAnalise";
            this.dataGridViewAnalise.Size = new System.Drawing.Size(423, 259);
            this.dataGridViewAnalise.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.labelInsulinaUsada);
            this.tabPage7.Controls.Add(this.labelMediaGlicose);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(439, 271);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Analise Geral";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Controlado";
            // 
            // labelInsulinaUsada
            // 
            this.labelInsulinaUsada.AutoSize = true;
            this.labelInsulinaUsada.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelInsulinaUsada.Location = new System.Drawing.Point(270, 114);
            this.labelInsulinaUsada.Name = "labelInsulinaUsada";
            this.labelInsulinaUsada.Size = new System.Drawing.Size(73, 25);
            this.labelInsulinaUsada.TabIndex = 26;
            this.labelInsulinaUsada.Text = "300 U.I.";
            // 
            // labelMediaGlicose
            // 
            this.labelMediaGlicose.AutoSize = true;
            this.labelMediaGlicose.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelMediaGlicose.Location = new System.Drawing.Point(43, 114);
            this.labelMediaGlicose.Name = "labelMediaGlicose";
            this.labelMediaGlicose.Size = new System.Drawing.Size(92, 25);
            this.labelMediaGlicose.TabIndex = 25;
            this.labelMediaGlicose.Text = "200mg/dl";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(132, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Status:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(205, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Qtd de insulina utilizada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(14, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Média da glicemia";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contagem de Insulina";
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
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalise)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label labelMediaGlicemia;
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
        private System.Windows.Forms.Button btnInserirGlicose;
        private System.Windows.Forms.Button btnAbrirCarboidratos;
        private System.Windows.Forms.Button salvarConfig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateFinishFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateStartFilter;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewAnalise;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelInsulinaUsada;
        private System.Windows.Forms.Label labelMediaGlicose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAcionar;
    }
}

