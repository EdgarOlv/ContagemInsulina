using ContagemInsulina.Classes;
using ContagemInsulina.DB;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace ContagemInsulina
{
    public partial class FormMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        List<Configuracao> configs;
        public bool setRelatorio = false;
        public bool startRelatorio = true;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public FormMenu()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
            checkBoxAlimentar.Checked = true;

            dateStartFilter.Value = DateTime.Now.AddDays(-10);
            dateFinishFilter.Value = DateTime.Now.AddDays(1);
        }
        /*
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }
        */
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnGlicemia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            setRelatorio = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            configs = new List<Configuracao>();
            Configuracao configuracao = new Configuracao();
            configs =  configuracao.Load_config();

            configs.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        fs.Text = Convert.ToString(objeto.valor);
                        break;

                    case 2: //Alvo
                        glicemiaAlvo.Text = Convert.ToString(objeto.valor);
                        break;

                    case 3: //Carboidrato
                        carb.Text = Convert.ToString(objeto.valor);
                        break;
                }
            });
            setRelatorio = false;
            //Criar classe config nova e popular campos

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            // ----------- Relatorio

            tabControl1.SelectedIndex = 2;
            DataTable dt = new DataTable();
            dt = Conexao.GetGlicemias(dateStartFilter.Value, dateFinishFilter.Value);
            dataGridView1.DataSource = dt;

            // ----------- Grafico

            chart1.DataSource = dt;
            chart1.Series[0].YValueMembers = "valor";
            chart1.Series[0].XValueMember = "data";
            chart1.DataBind();
            setRelatorio = true;

            // ----------- Analise

            dataGridViewAnalise.Rows.Clear();

            TimeSpan date = Convert.ToDateTime(dateFinishFilter.Value) - Convert.ToDateTime(dateStartFilter.Value);

            int totalDias = date.Days;

            dataGridViewAnalise.ColumnCount = totalDias;

            DateTime dataInicial = dateStartFilter.Value;
            for (int i = 0; i < totalDias; i++)
            {
                dataGridViewAnalise.Columns[i].Name = dataInicial.AddDays(i).ToString("dd/MM/yyyy");
            }

            // Define os momentos do dia que deseja exibir
            List<string> momentosDoDia = new List<string> { "7h - 9h", "9h - 11h", "11h - 14h",
                "14h - 17h", "17h - 20h", "20h - 23h" };

            //TODO: Criar classe para armazenar horarios, para poder ser alterado, chamado aq

            // Cria as linhas da DataGridView para cada momento do dia
            foreach (string momento in momentosDoDia)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewAnalise);
                row.Cells[0].Value = momento;

                dataGridViewAnalise.RowHeadersWidth = 100;
                row.HeaderCell.Value = momento;

                // Preenche as células com os valores de glicemia correspondentes para cada dia
                for (int i = 0; i < totalDias; i++)
                {
                    DateTime data = dataInicial.AddDays(i);
                    int valorGlicemia = 0;
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        DateTime dataRegistro = (DateTime)dataRow["data"];
                        if (dataRegistro.Date == data.Date)
                        {
                        int hora = dataRegistro.Hour;
                            if ((hora >= 7 && hora < 9 && momento == "7h - 9h") ||
                                (hora >= 9 && hora < 11 && momento == "9h - 11h") ||
                                (hora >= 11 && hora < 14 && momento == "11h - 14h") ||
                                (hora >= 14 && hora < 17 && momento == "14h - 17h") ||
                                (hora >= 17 && hora < 20 && momento == "17h - 20h") ||
                                (hora >= 20 && hora < 23 && momento == "20h - 23h"))
                            {
                                valorGlicemia = Convert.ToInt32(dataRow["valor"]);
                                break;
                            }
                        }
                    }
                    row.Cells[i].Value = valorGlicemia;
                }
                dataGridViewAnalise.Rows.Add(row);
            }

            // ----------- Analise Geral

            int glucoseSum = 0;
            int insulinSum = 0;
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                glucoseSum += Convert.ToInt32(row["valor"]);
                insulinSum += Convert.ToInt32(row["insulina_aplicada"]);
                count++;
            }
            double glucoseAverage = glucoseSum / count;
            int insulinTotal = insulinSum;

            labelMediaGlicose.Text = glucoseAverage.ToString();
            labelInsulinaUsada.Text = insulinTotal.ToString();  

        }

        //===============================================================================

        int valorfs = 0;
        int valorglicemiaAlvo = 0;
        int valorRelacaoCarb = 0;
        String glicemiaAnterior = "";
        private object sender;
        private EventArgs e;
        int contador = 0;
        DBFirebase firebase = new DBFirebase();

        public static class campoTextoAlimento
        {
            public static string nomeAlimento { get; set; }

        }

        internal static int qtdCarboidrato { get; set; }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            IniciarCampoFoco(sender, e);
            AnaliseHorario();
            CarregarConfiguracoes();
            CarregarAlimentos();
            CarregaDadosNuvemAsync();
        }

        private async Task CarregaDadosNuvemAsync()
        {
            /*
            List<GlicemiaClean> glicemias = await firebase.GetGlicemias();

            if (glicemias != null)
            {
                foreach (GlicemiaClean glicemia in glicemias)
                {
                    // Faça o que precisar com cada objeto de glicemia
                }
            }
            */

        }

        private void IniciarCampoFoco(object sender, EventArgs e)
        {
            btnConfig_Click(sender, e);
            btnGlicemia_Click(sender, e);
        }

        public void AnaliseHorario()
        {
            TimeSpan horario = new TimeSpan(00, 00, 00);
            TimeSpan horario2 = new TimeSpan(09, 00, 00);
            TimeSpan horario3 = new TimeSpan(11, 00, 00);
            TimeSpan horario4 = new TimeSpan(14, 00, 00);
            TimeSpan horario5 = new TimeSpan(17, 00, 00);
            TimeSpan horario6 = new TimeSpan(21, 00, 00);

            TimeSpan horaAtual = DateTime.Now.TimeOfDay;
            Alimentos alimento = new Alimentos(this);

            if (horaAtual >= horario && horaAtual <= horario2)
            {
                alimento.alimento1_Click(sender, e);
            }
            if (horaAtual >= horario2 && horaAtual <= horario3)
            {
                alimento.alimento2_Click(sender, e);
            }
            if (horaAtual >= horario3 && horaAtual <= horario4)
            {
                alimento.alimento3_Click(sender, e);
            }
            if (horaAtual >= horario4 && horaAtual <= horario5)
            {
                alimento.alimento4_Click(sender, e);
            }
            if (horaAtual >= horario5 && horaAtual <= horario6)
            {
                alimento.alimento5_Click(sender, e);
            }
            if (horaAtual >= horario6)
            {
                alimento.alimento6_Click(sender, e);
            }
        }

        private void CarregarConfiguracoes()
        {
            List<Configuracao> ListConfig = Conexao.GetConfigAll();

            ListConfig.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        valorfs = Convert.ToInt32(objeto.valor);
                        break;

                    case 2: //Alvo
                        valorglicemiaAlvo = Convert.ToInt32(objeto.valor);
                        break;

                    case 3: //Alvo
                        valorRelacaoCarb = Convert.ToInt32(objeto.valor);
                        break;
                }
            });
        }

        private void CarregarAlimentos()
        {
            if (campoTextoAlimento.nomeAlimento != "")
            {
                refeicao.Text = campoTextoAlimento.nomeAlimento;
            }
        }

        private void glicemiaAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalcular_Click_1(sender, e);
            }
        }

        public void ExibirNomeAlimento()
        {
            refeicao.Text = campoTextoAlimento.nomeAlimento;
        }

        private void checkBoxAlimentar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxAlimentar.Checked && contador != 0)
            {
                Alimentos formAlimentos = new Alimentos(this);
                formAlimentos.ShowDialog();
            }
            contador = 1;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            CalcularAcaoGlicemia(1);
        }

        private void glicemiaAtual_Click(object sender, EventArgs e)
        {
            glicemiaAtual.Text = "";
            glicemiaAtual.ForeColor = Color.Black;
        }

        private void CalcularAcaoGlicemia(int usaDB)
        {
            int valorGlicemia = 0;
            float qtdCorrecao = 0;
            float qtdAlimentacao = 0;

            try
            {
                valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);

                if (glicemiaAtual.Text != "" || valorGlicemia > 0)
                {

                    aplicarInsulina.Text = string.Format("Aplicar");
                    var checkMalhar = checkBoxMalhar.Checked;

                    Glicemia glicemia = new Glicemia(valorGlicemia);

                    if (checkBoxCorrecao.Checked)
                    {

                        qtdCorrecao = (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;

                        aplicarInsulina.Text += string.Format(" Correção {0:0.0}UI ", qtdCorrecao);

                        if (checkMalhar) qtdCorrecao = qtdCorrecao / 2;

                    }

                    if (checkBoxAlimentar.Checked)
                    {
                        qtdAlimentacao += (float)qtdCarboidrato / valorRelacaoCarb;

                        aplicarInsulina.Text += string.Format(" Alimento {0:0.0}UI ", qtdAlimentacao);

                    }

                    totalAplicar.Text = string.Format(" Aplicar: {0:0.0}UI ", qtdCorrecao + qtdAlimentacao);
                    glicemia.Valor_aplicado = Convert.ToInt32(qtdCorrecao + qtdAlimentacao);

                    if (usaDB == 1)
                    {
                        Conexao.Add(glicemia);
                        //DBGSheets.InsertGlicemiaNuvem(glicemia);
                        //InsertGlicemiasFB(glicemia);
                        firebase.AddGlicemy(glicemia);
                    }

                    if (checkMalhar)
                    {
                        TreinoGym treino = new TreinoGym();

                        totalAplicar.Text += string.Format(" e ");
                        totalAplicar.Text += treino.oQueFazer(Convert.ToInt32(glicemiaAtual.Text));

                    }

                    glicemiaAtual.Text = string.Format(" Ultima glicemia: {0} ", valorGlicemia);
                    glicemiaAtual.ForeColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("Insira a glicêmia!");
                }
            }
            catch
            {
                MessageBox.Show("Insira a glicêmia corretamente!");
            }
        }

        protected async void getGlicemiasFB()
        {
            var contatos = await firebase.GetContatos();

        }

        protected async void InsertGlicemiasFB(Glicemia glicemia)
        {
            await firebase.AddContato(glicemia.valor,glicemia.valor_aplicado ,glicemia.data ,glicemia.obs );

            MessageBox.Show("Success", "Glicemia incluído com sucesso em Nuvem");
         

        }

        //=============================== CONFIGURAÇÕES

        private void btnAbrirCarboidratos_Click(object sender, EventArgs e)
        {
            EditAlimentos editAli = new EditAlimentos();
            editAli.ShowDialog();
        }

        private void btnInserirGlicose_Click(object sender, EventArgs e)
        {
            InserirGlicemia novaGli = new InserirGlicemia();
            novaGli.ShowDialog();
        }

        private void salvarConfig_Click(object sender, EventArgs e)
        {
            configs.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(fs.Text));
                        break;

                    case 2: //Alvo
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(glicemiaAlvo.Text));
                        break;

                    case 3: //Carboidrato
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(carb.Text));
                        break;
                }
            });
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateFinishFilter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (setRelatorio)
                {
                    btnConfig_Click(sender, e);

                    btnRelatorio_Click(sender, e);
                }
            }
            catch
            {

            }
            
        }

        private void dateStartFilter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (setRelatorio)
                {
                    btnConfig_Click(sender, e);

                    btnRelatorio_Click(sender, e);
                }
            }
            catch
            {

            }
        }

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.chart1,
                                            pos.X, pos.Y - 15);


                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 4 &&
                            Math.Abs(pos.Y - pointYPixel) < 4)
                        {
                            tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.chart1,
                                            pos.X, pos.Y - 15);
                        }
                    }
                }
            }
        }

        private void btnAcionar_Click(object sender, EventArgs e)
        {
            //ReconhecimentoVoz rc = new ReconhecimentoVoz();
            //rc.buttonAtivarReconhecimento_Click(sender, e); 
            var glicemia = new Glicemia(100,5, DateTime.Now,"teste");

        }
    }
}
