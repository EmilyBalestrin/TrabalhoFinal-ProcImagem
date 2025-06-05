using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {

        Bitmap img1;
        Bitmap img2;
        Bitmap imgCinza; // Imagem convertida para escala de cinza
        byte[,] vImg1Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        bool isGrayScale = false; // Flag para indicar se a imagem exibida está em escala de cinza

        public Form1()
        {
            InitializeComponent();
        }

        private void btImg1_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                try
                {
                    img1 = new Bitmap(filePath);
                    img2 = new Bitmap(img1); // Copia a imagem original para processamento

                    pbImg1.Image = img1; // Mostra a imagem original na interface
                    isGrayScale = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btImg2_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                try
                {
                    img2 = new Bitmap(filePath);
                    pbImg2.Image = img2; // Exibe a segunda imagem na interface
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConverterParaCinza()
        {
            if (img1 == null) return;

            imgCinza = new Bitmap(img1.Width, img1.Height);
            vImg1Gray = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);
                    byte pixelIntensity = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                    vImg1Gray[i, j] = pixelIntensity;
                    imgCinza.SetPixel(i, j, Color.FromArgb(255, pixelIntensity, pixelIntensity, pixelIntensity));
                }
            }

            pbImgResultado.Image = imgCinza;
            isGrayScale = true;
        }


        private void AjustarBrilho(int brilho)
        {
            if (img1 == null) return;

            Bitmap imgBrilho = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    if (isGrayScale && vImg1Gray != null)
                    {
                        int novoValor = vImg1Gray[i, j] + brilho;
                        novoValor = Math.Max(0, Math.Min(255, novoValor));
                        imgBrilho.SetPixel(i, j, Color.FromArgb(255, (byte)novoValor, (byte)novoValor, (byte)novoValor));
                    }
                    else
                    {
                        Color pixel = img1.GetPixel(i, j);
                        int novoR = Math.Max(0, Math.Min(255, pixel.R + brilho));
                        int novoG = Math.Max(0, Math.Min(255, pixel.G + brilho));
                        int novoB = Math.Max(0, Math.Min(255, pixel.B + brilho));
                        imgBrilho.SetPixel(i, j, Color.FromArgb(pixel.A, (byte)novoR, (byte)novoG, (byte)novoB));
                    }
                }
            }

            pbImgResultado.Image = imgBrilho;
        }


        private void SomarImagens()
        {
            if (img1 == null || img2 == null) return;

            int largura = Math.Min(img1.Width, img2.Width);
            int altura = Math.Min(img1.Height, img2.Height);
            Bitmap imgSoma = new Bitmap(largura, altura);

            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    Color p1 = img1.GetPixel(i, j);
                    Color p2 = img2.GetPixel(i, j);

                    int novoR = Math.Min(255, p1.R + p2.R);
                    int novoG = Math.Min(255, p1.G + p2.G);
                    int novoB = Math.Min(255, p1.B + p2.B);

                    imgSoma.SetPixel(i, j, Color.FromArgb(255, (byte)novoR, (byte)novoG, (byte)novoB));
                }
            }

            pbImgResultado.Image = imgSoma;
        }

        private void SubtrairImagens()
        {
            if (img1 == null || img2 == null) return;

            int largura = Math.Min(img1.Width, img2.Width);
            int altura = Math.Min(img1.Height, img2.Height);
            Bitmap imgSubtracao = new Bitmap(largura, altura);

            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    Color p1 = img1.GetPixel(i, j);
                    Color p2 = img2.GetPixel(i, j);

                    int novoR = Math.Max(0, p1.R - p2.R);
                    int novoG = Math.Max(0, p1.G - p2.G);
                    int novoB = Math.Max(0, p1.B - p2.B);

                    imgSubtracao.SetPixel(i, j, Color.FromArgb(255, (byte)novoR, (byte)novoG, (byte)novoB));
                }
            }

            pbImgResultado.Image = imgSubtracao;
        }

        //rever a multiplicação e divisão
        private void MultiplicarImagem(float fator)
        {
            if (img1 == null) return;

            Bitmap imgResultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    // Calcula os novos valores
                    float novoR = pixel.R * fator;
                    float novoG = pixel.G * fator;
                    float novoB = pixel.B * fator;

                    // Limita os valores entre 0 e 255 manualmente
                    byte r = (novoR > 255) ? (byte)255 : (novoR < 0) ? (byte)0 : (byte)novoR;
                    byte g = (novoG > 255) ? (byte)255 : (novoG < 0) ? (byte)0 : (byte)novoG;
                    byte b = (novoB > 255) ? (byte)255 : (novoB < 0) ? (byte)0 : (byte)novoB;

                    imgResultado.SetPixel(x, y, Color.FromArgb(pixel.A, r, g, b));
                }
            }

            pbImgResultado.Image = imgResultado;
        }

        //rever a multiplicação e divisão
        private void DividirImagem(float fator)
        {
            if (img1 == null || fator < 0.01f)
            {
                MessageBox.Show("Fator inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap imgResultado = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    // Calcula os novos valores
                    float novoR = pixel.R / fator;
                    float novoG = pixel.G / fator;
                    float novoB = pixel.B / fator;

                    // Limita os valores entre 0 e 255 manualmente
                    byte r = (novoR > 255) ? (byte)255 : (novoR < 0) ? (byte)0 : (byte)novoR;
                    byte g = (novoG > 255) ? (byte)255 : (novoG < 0) ? (byte)0 : (byte)novoG;
                    byte b = (novoB > 255) ? (byte)255 : (novoB < 0) ? (byte)0 : (byte)novoB;

                    imgResultado.SetPixel(x, y, Color.FromArgb(pixel.A, r, g, b));
                }
            }

            pbImgResultado.Image = imgResultado;
        }

        private void InverterHorizontalmente()
        {
            Image imagemFonte = pbImgResultado.Image ?? pbImg1.Image;
            if (imagemFonte == null) return;

            Bitmap imgAtual = new Bitmap(imagemFonte);
            Bitmap imgInvertida = new Bitmap(imgAtual.Width, imgAtual.Height);

            for (int i = 0; i < imgAtual.Width; i++)
            {
                for (int j = 0; j < imgAtual.Height; j++)
                {
                    Color pixel = imgAtual.GetPixel(i, j);
                    imgInvertida.SetPixel(imgAtual.Width - 1 - i, j, pixel);
                }
            }

            pbImgResultado.Image = imgInvertida;
        }

        private void InverterVerticalmente()
        {
            Image imagemFonte = pbImgResultado.Image ?? pbImg1.Image;
            if (imagemFonte == null) return;

            Bitmap imgAtual = new Bitmap(imagemFonte);
            Bitmap imgInvertida = new Bitmap(imgAtual.Width, imgAtual.Height);

            for (int i = 0; i < imgAtual.Width; i++)
            {
                for (int j = 0; j < imgAtual.Height; j++)
                {
                    Color pixel = imgAtual.GetPixel(i, j);
                    imgInvertida.SetPixel(i, imgAtual.Height - 1 - j, pixel);
                }
            }

            pbImgResultado.Image = imgInvertida;
        }

        private void DiferencaEntreImagens()
        {
            if (img1 == null || img2 == null) return;

            int largura = Math.Min(img1.Width, img2.Width);
            int altura = Math.Min(img1.Height, img2.Height);
            Bitmap imgResultado = new Bitmap(largura, altura);

            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Diferença absoluta (já garante valores entre 0-255)
                    byte diffR = (byte)Math.Abs(p1.R - p2.R);
                    byte diffG = (byte)Math.Abs(p1.G - p2.G);
                    byte diffB = (byte)Math.Abs(p1.B - p2.B);

                    imgResultado.SetPixel(x, y, Color.FromArgb(255, diffR, diffG, diffB));
                }
            }

            pbImgResultado.Image = imgResultado;
        }

        private void ConverterParaBinario()
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bitmap imgBinaria = new Bitmap(img1.Width, img1.Height);
            const byte limiar = 128; // Limiar fixo (0-255)

            if (isGrayScale && vImg1Gray != null)
            {
                // Caso 1: Imagem já está em escala de cinza (usa a matriz de bytes)
                for (int x = 0; x < img1.Width; x++)
                {
                    for (int y = 0; y < img1.Height; y++)
                    {
                        byte intensidade = vImg1Gray[x, y];
                        imgBinaria.SetPixel(x, y, intensidade >= limiar ? Color.White : Color.Black);
                    }
                }
            }
            else
            {
                // Caso 2: Imagem RGB (converte para byte e aplica limiar)
                for (int x = 0; x < img1.Width; x++)
                {
                    for (int y = 0; y < img1.Height; y++)
                    {
                        Color pixel = img1.GetPixel(x, y);
                        // Converte RGB para byte (média simples)
                        byte intensidade = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                        imgBinaria.SetPixel(x, y, intensidade >= limiar ? Color.White : Color.Black);
                    }
                }
            }

            pbImgResultado.Image = imgBinaria;
            isGrayScale = true; // Atualiza o flag para binário (tons de cinza)
        }

        


        private void SalvarImagem()
        {
            if (pbImgResultado.Image == null) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Salvar imagem";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImgResultado.Image.Save(saveFileDialog.FileName);
            }
        }

        private void btConverterCinza_Click(object sender, EventArgs e)
        {
            ConverterParaCinza();
        }

        private void btAumentarBrilho_Click_1(object sender, EventArgs e)
        {
            int brilho = (int)numBrilho.Value; // Obtém o valor inserido no NumericUpDown
            AjustarBrilho(brilho);
        }

        private void btDiminuirBrilho_Click_1(object sender, EventArgs e)
        {
            int brilho = -(int)numBrilho.Value; // Obtém o valor e inverte o sinal para diminuir
            AjustarBrilho(brilho);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSomarImagens_Click(object sender, EventArgs e)
        {
            SomarImagens();
        }

        private void btSubtrairImagens_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Nenhuma imagem carregada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SubtrairImagens();
            }
        }

        private void btMultiplicarImagens_Click(object sender, EventArgs e)
        {
            float fator = (float)numMultiDivisor.Value;  // Converte o valor para float

            if (img1 != null)
            {
                MultiplicarImagem(fator);  // Chama a função de multiplicação (agora modificando img1 diretamente)
            }
            else
            {
                MessageBox.Show("Nenhuma imagem carregada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDividirImagens_Click(object sender, EventArgs e)
        {
            float fator = (float)numMultiDivisor.Value;  // Converte o valor para float

            if (fator == 0)
            {
                MessageBox.Show("O fator de divisão não pode ser zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (img1 != null)
            {
                DividirImagem(fator);  // Chama a função de divisão (agora modificando img1 diretamente)
            }
            else
            {
                MessageBox.Show("Nenhuma imagem carregada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBlending_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float alpha = (float)numBlending.Value;
            int largura = Math.Min(img1.Width, img2.Width);
            int altura = Math.Min(img1.Height, img2.Height);
            Bitmap imgBlend = new Bitmap(largura, altura);

            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Cálculo dos canais de cor
                    byte r = (byte)Math.Max(0, Math.Min(255, (alpha * p1.R) + ((1 - alpha) * p2.R)));
                    byte g = (byte)Math.Max(0, Math.Min(255, (alpha * p1.G) + ((1 - alpha) * p2.G)));
                    byte b = (byte)Math.Max(0, Math.Min(255, (alpha * p1.B) + ((1 - alpha) * p2.B)));

                    imgBlend.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            }

            pbImgResultado.Image = imgBlend;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int largura = Math.Min(img1.Width, img2.Width);
            int altura = Math.Min(img1.Height, img2.Height);
            Bitmap imgMedia = new Bitmap(largura, altura);

            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Cálculo direto da média (0.5 * p1 + 0.5 * p2)
                    byte r = (byte)((p1.R / 2) + (p2.R / 2));
                    byte g = (byte)((p1.G / 2) + (p2.G / 2));
                    byte b = (byte)((p1.B / 2) + (p2.B / 2));

                    imgMedia.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                }
            }

            pbImgResultado.Image = imgMedia;
        }

        private bool IsBinaryImage(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    // Verifica se todos os canais são 0 ou 255
                    if ((pixel.R != 0 && pixel.R != 255) ||
                        (pixel.G != 0 && pixel.G != 255) ||
                        (pixel.B != 0 && pixel.B != 255))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // OPERAÇÃO AND
        private void btnAND_Click(object sender, EventArgs e)
        {
            // Verifica se as imagens foram carregadas
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se as imagens têm o mesmo tamanho
            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho para calcular o AND lógico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria uma nova imagem para o resultado
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            // Calcula o AND lógico
            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Aplica a operação AND em todos os canais de cor
                    byte andR = (byte)(p1.R & p2.R);
                    byte andG = (byte)(p1.G & p2.G);
                    byte andB = (byte)(p1.B & p2.B);

                    result.SetPixel(x, y, Color.FromArgb(255, andR, andG, andB));
                }
            }
            pbImgResultado.Image = result;
        }

        // OPERAÇÃO OR
        private void btnOR_Click(object sender, EventArgs e)
        {
            // Verifica se as imagens foram carregadas
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se as imagens têm o mesmo tamanho
            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho para calcular o OR lógico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria uma nova imagem para o resultado
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            // Calcula o OR lógico
            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Aplica a operação OR em todos os canais de cor
                    byte orR = (byte)(p1.R | p2.R);
                    byte orG = (byte)(p1.G | p2.G);
                    byte orB = (byte)(p1.B | p2.B);

                    result.SetPixel(x, y, Color.FromArgb(255, orR, orG, orB));
                }
            }
            pbImgResultado.Image = result;
        }

        // OPERAÇÃO XOR
        private void btnXOR_Click(object sender, EventArgs e)
        {
            // Verifica se as imagens foram carregadas
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se as imagens têm o mesmo tamanho
            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens devem ter o mesmo tamanho para calcular o XOR lógico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria uma nova imagem para o resultado
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            // Calcula o XOR lógico
            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color p1 = img1.GetPixel(x, y);
                    Color p2 = img2.GetPixel(x, y);

                    // Aplica a operação XOR em todos os canais de cor
                    byte xorR = (byte)(p1.R ^ p2.R);
                    byte xorG = (byte)(p1.G ^ p2.G);
                    byte xorB = (byte)(p1.B ^ p2.B);

                    result.SetPixel(x, y, Color.FromArgb(255, xorR, xorG, xorB));
                }
            }
            pbImgResultado.Image = result;
        }

        // OPERAÇÃO NOT (Inversão)
        private void btnNOT_Click(object sender, EventArgs e)
        {
            // Verifica se a imagem foi carregada
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria uma nova imagem para o resultado
            Bitmap result = new Bitmap(img1.Width, img1.Height);

            // Calcula o NOT lógico
            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    // Aplica a operação NOT em todos os canais de cor
                    byte notR = (byte)(255 - pixel.R);
                    byte notG = (byte)(255 - pixel.G);
                    byte notB = (byte)(255 - pixel.B);

                    result.SetPixel(x, y, Color.FromArgb(255, notR, notG, notB));
                }
            }
            pbImgResultado.Image = result;
        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {

            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;
                int totalPixels = largura * altura;

                // Passo 1: Criar o Histograma da Imagem Original
                int[] histogramaOriginal = new int[256];
                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        Color pixel = img1.GetPixel(x, y);
                        int intensidade = pixel.R;
                        histogramaOriginal[intensidade]++;
                    }
                }

                // Exibir o histograma da imagem original no chart1
                chart1.Series.Clear();  // Limpa séries anteriores
                var serieOriginal = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Histograma Original",
                    Color = Color.Blue,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chart1.Series.Add(serieOriginal);

                for (int i = 0; i < histogramaOriginal.Length; i++)
                {
                    serieOriginal.Points.AddXY(i, histogramaOriginal[i]);
                }

                chart1.Invalidate();  // Atualiza o gráfico

                // Passo 2: Calcular o CFD (Cumulative Frequency Distribution)
                int[] cfd = new int[256];
                cfd[0] = histogramaOriginal[0];
                for (int i = 1; i < 256; i++)
                {
                    cfd[i] = cfd[i - 1] + histogramaOriginal[i];
                }

                // Encontrar o menor valor de CFD maior que 0
                int cfdMin = int.MaxValue;
                for (int i = 0; i < 256; i++)
                {
                    if (cfd[i] > 0)
                    {
                        cfdMin = Math.Min(cfdMin, cfd[i]);
                    }
                }

                // Passo 3: Ajustar os valores dos pixels (Equalização de Histograma)
                Bitmap imgEqualizada = new Bitmap(largura, altura);
                int[] histogramaEqualizado = new int[256];  // Para armazenar o novo histograma
                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        Color pixel = img1.GetPixel(x, y);
                        int intensidade = pixel.R;
                        int novoValor = (int)(((cfd[intensidade] - cfdMin) / (float)(totalPixels - cfdMin)) * 255);
                        novoValor = Math.Max(0, Math.Min(255, novoValor));
                        Color novoPixel = Color.FromArgb(novoValor, novoValor, novoValor);
                        imgEqualizada.SetPixel(x, y, novoPixel);
                        histogramaEqualizado[novoValor]++;
                    }
                }

                // Atualizar o PictureBox com a imagem equalizada (se aplicável)
                pbImgResultado.Image = imgEqualizada;

                // Exibir o histograma da imagem equalizada no chart2
                chart2.Series.Clear();  // Limpa séries anteriores
                var serieEqualizada = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Histograma Equalizado",
                    Color = Color.Red,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chart2.Series.Add(serieEqualizada);

                for (int i = 0; i < histogramaEqualizado.Length; i++)
                {
                    serieEqualizada.Points.AddXY(i, histogramaEqualizado[i]);
                }

                chart2.Invalidate();  // Atualiza o gráfico
            }
        }



        

        // Método auxiliar para exibir erros
        private void ShowBinaryError()
        {
            MessageBox.Show("Operação requer duas imagens binárias (preto e branco)!", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            SalvarImagem();
        }
 
        private void btnDiferencaEntreImagens_Click(object sender, EventArgs e)
        {
            DiferencaEntreImagens();
        }

        private void btnInverterImgHorizontal_Click(object sender, EventArgs e)
        {
            InverterHorizontalmente();
        }

        private void btnInverterImgVertical_Click(object sender, EventArgs e)
        {
            InverterVerticalmente();
        }

        private void btnConverterBinario_Click(object sender, EventArgs e)
        {
            ConverterParaBinario();
        }

      

        private void btnLimiarizacao_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Bitmap imgBinaria = new Bitmap(img1.Width, img1.Height);
            const byte limiar = 128; // Limiar fixo (0-255)
            if (isGrayScale && vImg1Gray != null)
            {
                // Caso 1: Imagem já está em escala de cinza (usa a matriz de bytes)
                for (int x = 0; x < img1.Width; x++)
                {
                    for (int y = 0; y < img1.Height; y++)
                    {
                        byte intensidade = vImg1Gray[x, y];
                        imgBinaria.SetPixel(x, y, intensidade >= limiar ? Color.White : Color.Black);
                    }
                }
            }
            else
            {
                // Caso 2: Imagem RGB (converte para byte e aplica limiar)
                for (int x = 0; x < img1.Width; x++)
                {
                    for (int y = 0; y < img1.Height; y++)
                    {
                        Color pixel = img1.GetPixel(x, y);
                        // Converte RGB para byte (média simples)
                        byte intensidade = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                        imgBinaria.SetPixel(x, y, intensidade >= limiar ? Color.White : Color.Black);
                    }
                }
            }
            pbImgResultado.Image = imgBinaria;
            isGrayScale = true; // Atualiza o flag para binário (tons de cinza)
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                // Criar uma nova imagem para armazenar o resultado
                Bitmap imgFiltrada = new Bitmap(largura, altura);

                // Varrer a imagem pixel por pixel
                for (int y = 1; y < altura - 1; y++) // Evita as bordas
                {
                    for (int x = 1; x < largura - 1; x++) // Evita as bordas
                    {
                        // List para armazenar os valores de intensidade dos pixels vizinhos
                        List<int> vizinhos = new List<int>();

                        // Varre a matriz 3x3 ao redor do pixel (x, y)
                        for (int j = -1; j <= 1; j++)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                // Pega o pixel vizinho
                                Color pixel = img1.GetPixel(x + i, y + j);
                                // Adiciona a intensidade do pixel (R, G ou B, pois a imagem é em escala de cinza)
                                vizinhos.Add(pixel.R); // Usando R, G e B são iguais para imagens em escala de cinza
                            }
                        }

                        // Encontrar o menor valor de intensidade na vizinhança 3x3
                        int menorValor = vizinhos.Min();

                        // Definir o novo valor do pixel na imagem filtrada
                        imgFiltrada.SetPixel(x, y, Color.FromArgb(menorValor, menorValor, menorValor));
                    }
                }

                // Atualiza a PictureBox com a imagem filtrada
                pbImgResultado.Image = imgFiltrada;

                // Se quiser exibir o histograma da imagem filtrada no chart2, pode-se seguir o mesmo processo usado anteriormente.
            }
        }

        private void btnMaximo_Click_1(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                // Criar uma nova imagem para armazenar o resultado
                Bitmap imgFiltrada = new Bitmap(largura, altura);

                // Varrer a imagem pixel por pixel
                for (int y = 1; y < altura - 1; y++) // Evita as bordas
                {
                    for (int x = 1; x < largura - 1; x++) // Evita as bordas
                    {
                        // List para armazenar os valores de intensidade dos pixels vizinhos
                        List<int> vizinhos = new List<int>();

                        // Varre a matriz 3x3 ao redor do pixel (x, y)
                        for (int j = -1; j <= 1; j++)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                // Pega o pixel vizinho
                                Color pixel = img1.GetPixel(x + i, y + j);
                                // Adiciona a intensidade do pixel (R, G ou B, pois a imagem é em escala de cinza)
                                vizinhos.Add(pixel.R); // Usando R, G e B são iguais para imagens em escala de cinza
                            }
                        }

                        // Encontrar o menor valor de intensidade na vizinhança 3x3
                        int menorValor = vizinhos.Max();

                        // Definir o novo valor do pixel na imagem filtrada
                        imgFiltrada.SetPixel(x, y, Color.FromArgb(menorValor, menorValor, menorValor));
                    }
                }

                // Atualiza a PictureBox com a imagem filtrada
                pbImgResultado.Image = imgFiltrada;

                // Se quiser exibir o histograma da imagem filtrada no chart2, pode-se seguir o mesmo processo usado anteriormente.
            }
        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                // Criar uma nova imagem para armazenar o resultado
                Bitmap imgFiltrada = new Bitmap(largura, altura);

                // Varrer a imagem pixel por pixel, exceto as bordas
                for (int y = 1; y < altura - 1; y++)
                {
                    for (int x = 1; x < largura - 1; x++)
                    {
                        int soma = 0; // Variável para armazenar a soma dos valores dos 9 pixels

                        // Varre a matriz 3x3 ao redor do pixel (x, y)
                        for (int j = -1; j <= 1; j++)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                // Pega o pixel vizinho
                                Color pixel = img1.GetPixel(x + i, y + j);
                                // Adiciona a intensidade do pixel (R, G ou B, pois a imagem é em escala de cinza)
                                soma += pixel.R; // Usando R, G e B são iguais para imagens em escala de cinza
                            }
                        }

                        // Calcula a média dos 9 valores
                        int media = soma / 9;

                        // Define o novo valor do pixel na imagem filtrada
                        imgFiltrada.SetPixel(x, y, Color.FromArgb(media, media, media));
                    }
                }

                // Atualiza a PictureBox com a imagem filtrada
                pbImgResultado.Image = imgFiltrada;

                // Se quiser exibir o histograma da imagem filtrada no chart2, pode-se seguir o mesmo processo usado anteriormente.
            }
        }
    }
 }