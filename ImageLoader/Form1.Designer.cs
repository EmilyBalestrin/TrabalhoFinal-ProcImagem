namespace TrabalhoFinal
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnImg1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbImg1 = new System.Windows.Forms.PictureBox();
            this.pbImgResultado = new System.Windows.Forms.PictureBox();
            this.numBrilho = new System.Windows.Forms.NumericUpDown();
            this.btnAumentarBrilho = new System.Windows.Forms.Button();
            this.btnDiminuirBrilho = new System.Windows.Forms.Button();
            this.btnConverterCinza = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pbImg2 = new System.Windows.Forms.PictureBox();
            this.btnImg2 = new System.Windows.Forms.Button();
            this.btnSomarImagens = new System.Windows.Forms.Button();
            this.btnSubtrairImagens = new System.Windows.Forms.Button();
            this.btnMultiplicarImagens = new System.Windows.Forms.Button();
            this.btnDividirImagens = new System.Windows.Forms.Button();
            this.btnSalvarImagem = new System.Windows.Forms.Button();
            this.numMultiDivisor = new System.Windows.Forms.NumericUpDown();
            this.btnDiferencaEntreImagens = new System.Windows.Forms.Button();
            this.btnInverterImgHorizontal = new System.Windows.Forms.Button();
            this.btnInverterImgVertical = new System.Windows.Forms.Button();
            this.btnConverterBinario = new System.Windows.Forms.Button();
            this.btnBlending = new System.Windows.Forms.Button();
            this.numBlending = new System.Windows.Forms.NumericUpDown();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnNOT = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.btnLimiarizacao = new System.Windows.Forms.Button();
            this.gbOperacoesAritmeticas = new System.Windows.Forms.GroupBox();
            this.gbOperacoesLogicas = new System.Windows.Forms.GroupBox();
            this.gbFiltrosPassaBaixa = new System.Windows.Forms.GroupBox();
            this.txtGaussiano = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.btnGaussiano = new System.Windows.Forms.Button();
            this.btnSuavizacaoConservativa = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.numUpDownOrdem = new System.Windows.Forms.NumericUpDown();
            this.gbOperacoesMorfologicas = new System.Windows.Forms.GroupBox();
            this.btnContorno = new System.Windows.Forms.Button();
            this.btnDilatacao = new System.Windows.Forms.Button();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.btnErosao = new System.Windows.Forms.Button();
            this.btnAbertura = new System.Windows.Forms.Button();
            this.gbFiltrosPassaAlta = new System.Windows.Forms.GroupBox();
            this.btnLaplaciano = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnPrewitt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiDivisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.gbOperacoesAritmeticas.SuspendLayout();
            this.gbOperacoesLogicas.SuspendLayout();
            this.gbFiltrosPassaBaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOrdem)).BeginInit();
            this.gbOperacoesMorfologicas.SuspendLayout();
            this.gbFiltrosPassaAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImg1
            // 
            this.btnImg1.BackColor = System.Drawing.Color.Beige;
            this.btnImg1.Location = new System.Drawing.Point(37, 235);
            this.btnImg1.Margin = new System.Windows.Forms.Padding(4);
            this.btnImg1.Name = "btnImg1";
            this.btnImg1.Size = new System.Drawing.Size(217, 32);
            this.btnImg1.TabIndex = 0;
            this.btnImg1.Text = "Carregar Imagem";
            this.btnImg1.UseVisualStyleBackColor = false;
            this.btnImg1.Click += new System.EventHandler(this.btImg1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbImg1
            // 
            this.pbImg1.Location = new System.Drawing.Point(13, 13);
            this.pbImg1.Margin = new System.Windows.Forms.Padding(4);
            this.pbImg1.Name = "pbImg1";
            this.pbImg1.Size = new System.Drawing.Size(277, 214);
            this.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg1.TabIndex = 1;
            this.pbImg1.TabStop = false;
            // 
            // pbImgResultado
            // 
            this.pbImgResultado.Location = new System.Drawing.Point(1632, 13);
            this.pbImgResultado.Margin = new System.Windows.Forms.Padding(4);
            this.pbImgResultado.Name = "pbImgResultado";
            this.pbImgResultado.Size = new System.Drawing.Size(279, 214);
            this.pbImgResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgResultado.TabIndex = 2;
            this.pbImgResultado.TabStop = false;
            // 
            // numBrilho
            // 
            this.numBrilho.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBrilho.Location = new System.Drawing.Point(606, 12);
            this.numBrilho.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBrilho.Name = "numBrilho";
            this.numBrilho.Size = new System.Drawing.Size(90, 22);
            this.numBrilho.TabIndex = 3;
            // 
            // btnAumentarBrilho
            // 
            this.btnAumentarBrilho.Location = new System.Drawing.Point(584, 41);
            this.btnAumentarBrilho.Name = "btnAumentarBrilho";
            this.btnAumentarBrilho.Size = new System.Drawing.Size(137, 29);
            this.btnAumentarBrilho.TabIndex = 4;
            this.btnAumentarBrilho.Text = "Aumentar Brilho";
            this.btnAumentarBrilho.UseVisualStyleBackColor = true;
            this.btnAumentarBrilho.Click += new System.EventHandler(this.btAumentarBrilho_Click_1);
            // 
            // btnDiminuirBrilho
            // 
            this.btnDiminuirBrilho.Location = new System.Drawing.Point(584, 76);
            this.btnDiminuirBrilho.Name = "btnDiminuirBrilho";
            this.btnDiminuirBrilho.Size = new System.Drawing.Size(137, 29);
            this.btnDiminuirBrilho.TabIndex = 5;
            this.btnDiminuirBrilho.Text = "Diminuir Brilho";
            this.btnDiminuirBrilho.UseVisualStyleBackColor = true;
            this.btnDiminuirBrilho.Click += new System.EventHandler(this.btDiminuirBrilho_Click_1);
            // 
            // btnConverterCinza
            // 
            this.btnConverterCinza.Location = new System.Drawing.Point(756, 17);
            this.btnConverterCinza.Name = "btnConverterCinza";
            this.btnConverterCinza.Size = new System.Drawing.Size(161, 29);
            this.btnConverterCinza.TabIndex = 6;
            this.btnConverterCinza.Text = "Converter para cinza";
            this.btnConverterCinza.UseVisualStyleBackColor = true;
            this.btnConverterCinza.Click += new System.EventHandler(this.btConverterCinza_Click);
            // 
            // pbImg2
            // 
            this.pbImg2.Location = new System.Drawing.Point(298, 13);
            this.pbImg2.Margin = new System.Windows.Forms.Padding(4);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(279, 214);
            this.pbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg2.TabIndex = 8;
            this.pbImg2.TabStop = false;
            // 
            // btnImg2
            // 
            this.btnImg2.BackColor = System.Drawing.Color.Beige;
            this.btnImg2.Location = new System.Drawing.Point(329, 235);
            this.btnImg2.Margin = new System.Windows.Forms.Padding(4);
            this.btnImg2.Name = "btnImg2";
            this.btnImg2.Size = new System.Drawing.Size(217, 32);
            this.btnImg2.TabIndex = 9;
            this.btnImg2.Text = "Carregar Imagem";
            this.btnImg2.UseVisualStyleBackColor = false;
            this.btnImg2.Click += new System.EventHandler(this.btImg2_Click);
            // 
            // btnSomarImagens
            // 
            this.btnSomarImagens.Location = new System.Drawing.Point(88, 21);
            this.btnSomarImagens.Name = "btnSomarImagens";
            this.btnSomarImagens.Size = new System.Drawing.Size(151, 29);
            this.btnSomarImagens.TabIndex = 10;
            this.btnSomarImagens.Text = "Somar Imagens";
            this.btnSomarImagens.UseVisualStyleBackColor = true;
            this.btnSomarImagens.Click += new System.EventHandler(this.btSomarImagens_Click);
            // 
            // btnSubtrairImagens
            // 
            this.btnSubtrairImagens.Location = new System.Drawing.Point(88, 56);
            this.btnSubtrairImagens.Name = "btnSubtrairImagens";
            this.btnSubtrairImagens.Size = new System.Drawing.Size(151, 29);
            this.btnSubtrairImagens.TabIndex = 11;
            this.btnSubtrairImagens.Text = "Subtrair Imagens";
            this.btnSubtrairImagens.UseVisualStyleBackColor = true;
            this.btnSubtrairImagens.Click += new System.EventHandler(this.btSubtrairImagens_Click);
            // 
            // btnMultiplicarImagens
            // 
            this.btnMultiplicarImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicarImagens.Location = new System.Drawing.Point(88, 91);
            this.btnMultiplicarImagens.Name = "btnMultiplicarImagens";
            this.btnMultiplicarImagens.Size = new System.Drawing.Size(151, 29);
            this.btnMultiplicarImagens.TabIndex = 12;
            this.btnMultiplicarImagens.Text = "Multiplicar Imagens";
            this.btnMultiplicarImagens.UseVisualStyleBackColor = true;
            this.btnMultiplicarImagens.Click += new System.EventHandler(this.btMultiplicarImagens_Click);
            // 
            // btnDividirImagens
            // 
            this.btnDividirImagens.Location = new System.Drawing.Point(88, 128);
            this.btnDividirImagens.Name = "btnDividirImagens";
            this.btnDividirImagens.Size = new System.Drawing.Size(151, 29);
            this.btnDividirImagens.TabIndex = 13;
            this.btnDividirImagens.Text = "Dividir Imagens";
            this.btnDividirImagens.UseVisualStyleBackColor = true;
            this.btnDividirImagens.Click += new System.EventHandler(this.btnDividirImagens_Click);
            // 
            // btnSalvarImagem
            // 
            this.btnSalvarImagem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvarImagem.Location = new System.Drawing.Point(1697, 232);
            this.btnSalvarImagem.Name = "btnSalvarImagem";
            this.btnSalvarImagem.Size = new System.Drawing.Size(151, 39);
            this.btnSalvarImagem.TabIndex = 14;
            this.btnSalvarImagem.Text = "Salvar Imagem";
            this.btnSalvarImagem.UseVisualStyleBackColor = false;
            this.btnSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // numMultiDivisor
            // 
            this.numMultiDivisor.DecimalPlaces = 2;
            this.numMultiDivisor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMultiDivisor.Location = new System.Drawing.Point(22, 111);
            this.numMultiDivisor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMultiDivisor.Name = "numMultiDivisor";
            this.numMultiDivisor.Size = new System.Drawing.Size(60, 22);
            this.numMultiDivisor.TabIndex = 16;
            // 
            // btnDiferencaEntreImagens
            // 
            this.btnDiferencaEntreImagens.Location = new System.Drawing.Point(756, 89);
            this.btnDiferencaEntreImagens.Name = "btnDiferencaEntreImagens";
            this.btnDiferencaEntreImagens.Size = new System.Drawing.Size(183, 29);
            this.btnDiferencaEntreImagens.TabIndex = 17;
            this.btnDiferencaEntreImagens.Text = "Diferença entre imagens";
            this.btnDiferencaEntreImagens.UseVisualStyleBackColor = true;
            this.btnDiferencaEntreImagens.Click += new System.EventHandler(this.btnDiferencaEntreImagens_Click);
            // 
            // btnInverterImgHorizontal
            // 
            this.btnInverterImgHorizontal.Location = new System.Drawing.Point(746, 124);
            this.btnInverterImgHorizontal.Name = "btnInverterImgHorizontal";
            this.btnInverterImgHorizontal.Size = new System.Drawing.Size(213, 31);
            this.btnInverterImgHorizontal.TabIndex = 18;
            this.btnInverterImgHorizontal.Text = "Inverter imagem horizontalmente";
            this.btnInverterImgHorizontal.UseVisualStyleBackColor = true;
            this.btnInverterImgHorizontal.Click += new System.EventHandler(this.btnInverterImgHorizontal_Click);
            // 
            // btnInverterImgVertical
            // 
            this.btnInverterImgVertical.Location = new System.Drawing.Point(746, 161);
            this.btnInverterImgVertical.Name = "btnInverterImgVertical";
            this.btnInverterImgVertical.Size = new System.Drawing.Size(213, 31);
            this.btnInverterImgVertical.TabIndex = 19;
            this.btnInverterImgVertical.Text = "Inverter imagem verticalmente";
            this.btnInverterImgVertical.UseVisualStyleBackColor = true;
            this.btnInverterImgVertical.Click += new System.EventHandler(this.btnInverterImgVertical_Click);
            // 
            // btnConverterBinario
            // 
            this.btnConverterBinario.Location = new System.Drawing.Point(756, 52);
            this.btnConverterBinario.Name = "btnConverterBinario";
            this.btnConverterBinario.Size = new System.Drawing.Size(161, 29);
            this.btnConverterBinario.TabIndex = 20;
            this.btnConverterBinario.Text = "Converter para binário";
            this.btnConverterBinario.UseVisualStyleBackColor = true;
            this.btnConverterBinario.Click += new System.EventHandler(this.btnConverterBinario_Click);
            // 
            // btnBlending
            // 
            this.btnBlending.Location = new System.Drawing.Point(826, 269);
            this.btnBlending.Name = "btnBlending";
            this.btnBlending.Size = new System.Drawing.Size(151, 29);
            this.btnBlending.TabIndex = 21;
            this.btnBlending.Text = "Calcular Blending";
            this.btnBlending.UseVisualStyleBackColor = true;
            this.btnBlending.Click += new System.EventHandler(this.btnBlending_Click);
            // 
            // numBlending
            // 
            this.numBlending.DecimalPlaces = 1;
            this.numBlending.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBlending.Location = new System.Drawing.Point(872, 241);
            this.numBlending.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBlending.Name = "numBlending";
            this.numBlending.Size = new System.Drawing.Size(63, 22);
            this.numBlending.TabIndex = 0;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(826, 304);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(151, 29);
            this.btnMedia.TabIndex = 22;
            this.btnMedia.Text = "Calcular Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnAND
            // 
            this.btnAND.Location = new System.Drawing.Point(15, 23);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(137, 29);
            this.btnAND.TabIndex = 23;
            this.btnAND.Text = "AND";
            this.btnAND.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAND.UseVisualStyleBackColor = true;
            this.btnAND.Click += new System.EventHandler(this.btnAND_Click);
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(15, 58);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(137, 29);
            this.btnOR.TabIndex = 24;
            this.btnOR.Text = "OR";
            this.btnOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnNOT
            // 
            this.btnNOT.Location = new System.Drawing.Point(15, 93);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(137, 29);
            this.btnNOT.TabIndex = 25;
            this.btnNOT.Text = "NOT";
            this.btnNOT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNOT.UseVisualStyleBackColor = true;
            this.btnNOT.Click += new System.EventHandler(this.btnNOT_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.Location = new System.Drawing.Point(15, 128);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(137, 29);
            this.btnXOR.TabIndex = 26;
            this.btnXOR.Text = "XOR";
            this.btnXOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXOR.UseVisualStyleBackColor = true;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(13, 775);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(654, 300);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(1220, 775);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(646, 300);
            this.chart2.TabIndex = 28;
            this.chart2.Text = "chart2";
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(826, 364);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(151, 29);
            this.btnHistograma.TabIndex = 29;
            this.btnHistograma.Text = "Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // btnLimiarizacao
            // 
            this.btnLimiarizacao.Location = new System.Drawing.Point(826, 402);
            this.btnLimiarizacao.Name = "btnLimiarizacao";
            this.btnLimiarizacao.Size = new System.Drawing.Size(151, 29);
            this.btnLimiarizacao.TabIndex = 30;
            this.btnLimiarizacao.Text = "Limiarização";
            this.btnLimiarizacao.UseVisualStyleBackColor = true;
            this.btnLimiarizacao.Click += new System.EventHandler(this.btnLimiarizacao_Click);
            // 
            // gbOperacoesAritmeticas
            // 
            this.gbOperacoesAritmeticas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbOperacoesAritmeticas.Controls.Add(this.btnSomarImagens);
            this.gbOperacoesAritmeticas.Controls.Add(this.btnSubtrairImagens);
            this.gbOperacoesAritmeticas.Controls.Add(this.numMultiDivisor);
            this.gbOperacoesAritmeticas.Controls.Add(this.btnMultiplicarImagens);
            this.gbOperacoesAritmeticas.Controls.Add(this.btnDividirImagens);
            this.gbOperacoesAritmeticas.Location = new System.Drawing.Point(37, 296);
            this.gbOperacoesAritmeticas.Name = "gbOperacoesAritmeticas";
            this.gbOperacoesAritmeticas.Size = new System.Drawing.Size(245, 169);
            this.gbOperacoesAritmeticas.TabIndex = 31;
            this.gbOperacoesAritmeticas.TabStop = false;
            this.gbOperacoesAritmeticas.Text = "Operações Aritméticas";
            // 
            // gbOperacoesLogicas
            // 
            this.gbOperacoesLogicas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbOperacoesLogicas.Controls.Add(this.btnAND);
            this.gbOperacoesLogicas.Controls.Add(this.btnOR);
            this.gbOperacoesLogicas.Controls.Add(this.btnNOT);
            this.gbOperacoesLogicas.Controls.Add(this.btnXOR);
            this.gbOperacoesLogicas.Location = new System.Drawing.Point(313, 296);
            this.gbOperacoesLogicas.Name = "gbOperacoesLogicas";
            this.gbOperacoesLogicas.Size = new System.Drawing.Size(166, 169);
            this.gbOperacoesLogicas.TabIndex = 32;
            this.gbOperacoesLogicas.TabStop = false;
            this.gbOperacoesLogicas.Text = "Operações Lógicas";
            // 
            // gbFiltrosPassaBaixa
            // 
            this.gbFiltrosPassaBaixa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbFiltrosPassaBaixa.Controls.Add(this.txtGaussiano);
            this.gbFiltrosPassaBaixa.Controls.Add(this.comboBox1);
            this.gbFiltrosPassaBaixa.Controls.Add(this.txtOrdem);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnGaussiano);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnSuavizacaoConservativa);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnOrdem);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnMediana);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnMean);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnMaximo);
            this.gbFiltrosPassaBaixa.Controls.Add(this.btnMinimo);
            this.gbFiltrosPassaBaixa.Location = new System.Drawing.Point(507, 296);
            this.gbFiltrosPassaBaixa.Name = "gbFiltrosPassaBaixa";
            this.gbFiltrosPassaBaixa.Size = new System.Drawing.Size(196, 275);
            this.gbFiltrosPassaBaixa.TabIndex = 33;
            this.gbFiltrosPassaBaixa.TabStop = false;
            this.gbFiltrosPassaBaixa.Text = "Filtros Passa-Baixa";
            // 
            // txtGaussiano
            // 
            this.txtGaussiano.Location = new System.Drawing.Point(28, 233);
            this.txtGaussiano.Name = "txtGaussiano";
            this.txtGaussiano.Size = new System.Drawing.Size(58, 22);
            this.txtGaussiano.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3X3",
            "5x5",
            "7x7"});
            this.comboBox1.Location = new System.Drawing.Point(16, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(28, 156);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(58, 22);
            this.txtOrdem.TabIndex = 34;
            // 
            // btnGaussiano
            // 
            this.btnGaussiano.Location = new System.Drawing.Point(92, 232);
            this.btnGaussiano.Name = "btnGaussiano";
            this.btnGaussiano.Size = new System.Drawing.Size(89, 23);
            this.btnGaussiano.TabIndex = 6;
            this.btnGaussiano.Text = "Gaussiano";
            this.btnGaussiano.UseVisualStyleBackColor = true;
            this.btnGaussiano.Click += new System.EventHandler(this.btnGaussiano_Click);
            // 
            // btnSuavizacaoConservativa
            // 
            this.btnSuavizacaoConservativa.Location = new System.Drawing.Point(83, 184);
            this.btnSuavizacaoConservativa.Name = "btnSuavizacaoConservativa";
            this.btnSuavizacaoConservativa.Size = new System.Drawing.Size(104, 42);
            this.btnSuavizacaoConservativa.TabIndex = 5;
            this.btnSuavizacaoConservativa.Text = "Suavização Conservativa";
            this.btnSuavizacaoConservativa.UseVisualStyleBackColor = true;
            this.btnSuavizacaoConservativa.Click += new System.EventHandler(this.btnSuavizacaoConservativa_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.Location = new System.Drawing.Point(99, 155);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(75, 23);
            this.btnOrdem.TabIndex = 4;
            this.btnOrdem.Text = "Ordem";
            this.btnOrdem.UseVisualStyleBackColor = true;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(99, 126);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(75, 26);
            this.btnMediana.TabIndex = 3;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(99, 82);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(75, 23);
            this.btnMean.TabIndex = 2;
            this.btnMean.Text = "MEAN";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnMaximo
            // 
            this.btnMaximo.Location = new System.Drawing.Point(99, 53);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(75, 23);
            this.btnMaximo.TabIndex = 1;
            this.btnMaximo.Text = "MAX";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click_1);
            // 
            // btnMinimo
            // 
            this.btnMinimo.Location = new System.Drawing.Point(99, 24);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(75, 23);
            this.btnMinimo.TabIndex = 0;
            this.btnMinimo.Text = "MIN";
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // numUpDownOrdem
            // 
            this.numUpDownOrdem.Location = new System.Drawing.Point(444, 491);
            this.numUpDownOrdem.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownOrdem.Name = "numUpDownOrdem";
            this.numUpDownOrdem.Size = new System.Drawing.Size(57, 22);
            this.numUpDownOrdem.TabIndex = 34;
            // 
            // gbOperacoesMorfologicas
            // 
            this.gbOperacoesMorfologicas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbOperacoesMorfologicas.Controls.Add(this.btnContorno);
            this.gbOperacoesMorfologicas.Controls.Add(this.btnDilatacao);
            this.gbOperacoesMorfologicas.Controls.Add(this.btnFechamento);
            this.gbOperacoesMorfologicas.Controls.Add(this.btnErosao);
            this.gbOperacoesMorfologicas.Controls.Add(this.btnAbertura);
            this.gbOperacoesMorfologicas.Location = new System.Drawing.Point(795, 501);
            this.gbOperacoesMorfologicas.Name = "gbOperacoesMorfologicas";
            this.gbOperacoesMorfologicas.Size = new System.Drawing.Size(182, 168);
            this.gbOperacoesMorfologicas.TabIndex = 35;
            this.gbOperacoesMorfologicas.TabStop = false;
            this.gbOperacoesMorfologicas.Text = "Operações Morfológicas";
            // 
            // btnContorno
            // 
            this.btnContorno.Location = new System.Drawing.Point(53, 137);
            this.btnContorno.Name = "btnContorno";
            this.btnContorno.Size = new System.Drawing.Size(75, 23);
            this.btnContorno.TabIndex = 40;
            this.btnContorno.Text = "Contorno";
            this.btnContorno.UseVisualStyleBackColor = true;
            // 
            // btnDilatacao
            // 
            this.btnDilatacao.Location = new System.Drawing.Point(53, 22);
            this.btnDilatacao.Name = "btnDilatacao";
            this.btnDilatacao.Size = new System.Drawing.Size(75, 23);
            this.btnDilatacao.TabIndex = 36;
            this.btnDilatacao.Text = "Dilatação";
            this.btnDilatacao.UseVisualStyleBackColor = true;
            // 
            // btnFechamento
            // 
            this.btnFechamento.Location = new System.Drawing.Point(38, 109);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(104, 23);
            this.btnFechamento.TabIndex = 39;
            this.btnFechamento.Text = "Fechamento";
            this.btnFechamento.UseVisualStyleBackColor = true;
            // 
            // btnErosao
            // 
            this.btnErosao.Location = new System.Drawing.Point(53, 51);
            this.btnErosao.Name = "btnErosao";
            this.btnErosao.Size = new System.Drawing.Size(75, 23);
            this.btnErosao.TabIndex = 37;
            this.btnErosao.Text = "Erosao";
            this.btnErosao.UseVisualStyleBackColor = true;
            // 
            // btnAbertura
            // 
            this.btnAbertura.Location = new System.Drawing.Point(53, 80);
            this.btnAbertura.Name = "btnAbertura";
            this.btnAbertura.Size = new System.Drawing.Size(75, 23);
            this.btnAbertura.TabIndex = 38;
            this.btnAbertura.Text = "Abertura";
            this.btnAbertura.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosPassaAlta
            // 
            this.gbFiltrosPassaAlta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbFiltrosPassaAlta.Controls.Add(this.btnLaplaciano);
            this.gbFiltrosPassaAlta.Controls.Add(this.btnSobel);
            this.gbFiltrosPassaAlta.Controls.Add(this.btnPrewitt);
            this.gbFiltrosPassaAlta.Location = new System.Drawing.Point(111, 559);
            this.gbFiltrosPassaAlta.Name = "gbFiltrosPassaAlta";
            this.gbFiltrosPassaAlta.Size = new System.Drawing.Size(143, 127);
            this.gbFiltrosPassaAlta.TabIndex = 36;
            this.gbFiltrosPassaAlta.TabStop = false;
            this.gbFiltrosPassaAlta.Text = "Filtros Passa-Alta";
            // 
            // btnLaplaciano
            // 
            this.btnLaplaciano.Location = new System.Drawing.Point(27, 89);
            this.btnLaplaciano.Name = "btnLaplaciano";
            this.btnLaplaciano.Size = new System.Drawing.Size(90, 23);
            this.btnLaplaciano.TabIndex = 39;
            this.btnLaplaciano.Text = "Laplaciano";
            this.btnLaplaciano.UseVisualStyleBackColor = true;
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(34, 60);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(75, 23);
            this.btnSobel.TabIndex = 38;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.Location = new System.Drawing.Point(34, 31);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(75, 23);
            this.btnPrewitt.TabIndex = 37;
            this.btnPrewitt.Text = "Prewitt";
            this.btnPrewitt.UseVisualStyleBackColor = true;
            this.btnPrewitt.Click += new System.EventHandler(this.btnPrewitt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1131);
            this.Controls.Add(this.gbFiltrosPassaAlta);
            this.Controls.Add(this.gbOperacoesMorfologicas);
            this.Controls.Add(this.numUpDownOrdem);
            this.Controls.Add(this.gbFiltrosPassaBaixa);
            this.Controls.Add(this.gbOperacoesLogicas);
            this.Controls.Add(this.gbOperacoesAritmeticas);
            this.Controls.Add(this.btnLimiarizacao);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.numBlending);
            this.Controls.Add(this.btnBlending);
            this.Controls.Add(this.btnConverterBinario);
            this.Controls.Add(this.btnInverterImgVertical);
            this.Controls.Add(this.btnInverterImgHorizontal);
            this.Controls.Add(this.btnDiferencaEntreImagens);
            this.Controls.Add(this.btnSalvarImagem);
            this.Controls.Add(this.btnImg2);
            this.Controls.Add(this.pbImg2);
            this.Controls.Add(this.btnConverterCinza);
            this.Controls.Add(this.btnDiminuirBrilho);
            this.Controls.Add(this.btnAumentarBrilho);
            this.Controls.Add(this.numBrilho);
            this.Controls.Add(this.pbImgResultado);
            this.Controls.Add(this.pbImg1);
            this.Controls.Add(this.btnImg1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiDivisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.gbOperacoesAritmeticas.ResumeLayout(false);
            this.gbOperacoesLogicas.ResumeLayout(false);
            this.gbFiltrosPassaBaixa.ResumeLayout(false);
            this.gbFiltrosPassaBaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOrdem)).EndInit();
            this.gbOperacoesMorfologicas.ResumeLayout(false);
            this.gbFiltrosPassaAlta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImg1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbImg1;
        private System.Windows.Forms.PictureBox pbImgResultado;
        private System.Windows.Forms.NumericUpDown numBrilho;
        private System.Windows.Forms.Button btnAumentarBrilho;
        private System.Windows.Forms.Button btnDiminuirBrilho;
        private System.Windows.Forms.Button btnConverterCinza;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pbImg2;
        private System.Windows.Forms.Button btnImg2;
        private System.Windows.Forms.Button btnSomarImagens;
        private System.Windows.Forms.Button btnSubtrairImagens;
        private System.Windows.Forms.Button btnMultiplicarImagens;
        private System.Windows.Forms.Button btnDividirImagens;
        private System.Windows.Forms.Button btnSalvarImagem;
        private System.Windows.Forms.NumericUpDown numMultiDivisor;
        private System.Windows.Forms.Button btnDiferencaEntreImagens;
        private System.Windows.Forms.Button btnInverterImgHorizontal;
        private System.Windows.Forms.Button btnInverterImgVertical;
        private System.Windows.Forms.Button btnConverterBinario;
        private System.Windows.Forms.Button btnBlending;
        private System.Windows.Forms.NumericUpDown numBlending;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.Button btnLimiarizacao;
        private System.Windows.Forms.GroupBox gbOperacoesAritmeticas;
        private System.Windows.Forms.GroupBox gbOperacoesLogicas;
        private System.Windows.Forms.GroupBox gbFiltrosPassaBaixa;
        private System.Windows.Forms.Button btnGaussiano;
        private System.Windows.Forms.Button btnSuavizacaoConservativa;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numUpDownOrdem;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.TextBox txtGaussiano;
        private System.Windows.Forms.GroupBox gbOperacoesMorfologicas;
        private System.Windows.Forms.Button btnDilatacao;
        private System.Windows.Forms.Button btnErosao;
        private System.Windows.Forms.Button btnAbertura;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.Button btnContorno;
        private System.Windows.Forms.GroupBox gbFiltrosPassaAlta;
        private System.Windows.Forms.Button btnLaplaciano;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnPrewitt;
    }
}