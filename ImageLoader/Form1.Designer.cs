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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGaussiano = new System.Windows.Forms.Button();
            this.btnSuavizacaoConservativa = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.numUpDownOrdem = new System.Windows.Forms.NumericUpDown();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiDivisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOrdem)).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 775);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(654, 300);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1220, 775);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnSomarImagens);
            this.groupBox1.Controls.Add(this.btnSubtrairImagens);
            this.groupBox1.Controls.Add(this.numMultiDivisor);
            this.groupBox1.Controls.Add(this.btnMultiplicarImagens);
            this.groupBox1.Controls.Add(this.btnDividirImagens);
            this.groupBox1.Location = new System.Drawing.Point(37, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 169);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Aritméticas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnAND);
            this.groupBox2.Controls.Add(this.btnOR);
            this.groupBox2.Controls.Add(this.btnNOT);
            this.groupBox2.Controls.Add(this.btnXOR);
            this.groupBox2.Location = new System.Drawing.Point(313, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 169);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações Lógicas";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.txtOrdem);
            this.groupBox3.Controls.Add(this.btnGaussiano);
            this.groupBox3.Controls.Add(this.btnSuavizacaoConservativa);
            this.groupBox3.Controls.Add(this.btnOrdem);
            this.groupBox3.Controls.Add(this.btnMediana);
            this.groupBox3.Controls.Add(this.btnMean);
            this.groupBox3.Controls.Add(this.btnMaximo);
            this.groupBox3.Controls.Add(this.btnMinimo);
            this.groupBox3.Location = new System.Drawing.Point(507, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 275);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros Passa-Baixa";
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
            // btnGaussiano
            // 
            this.btnGaussiano.Location = new System.Drawing.Point(92, 232);
            this.btnGaussiano.Name = "btnGaussiano";
            this.btnGaussiano.Size = new System.Drawing.Size(89, 23);
            this.btnGaussiano.TabIndex = 6;
            this.btnGaussiano.Text = "Gaussiano";
            this.btnGaussiano.UseVisualStyleBackColor = true;
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
            this.numUpDownOrdem.Location = new System.Drawing.Point(433, 491);
            this.numUpDownOrdem.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDownOrdem.Name = "numUpDownOrdem";
            this.numUpDownOrdem.Size = new System.Drawing.Size(57, 22);
            this.numUpDownOrdem.TabIndex = 34;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(35, 156);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(58, 22);
            this.txtOrdem.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1131);
            this.Controls.Add(this.numUpDownOrdem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownOrdem)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
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
    }
}