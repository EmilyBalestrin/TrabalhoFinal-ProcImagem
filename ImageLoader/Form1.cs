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

        private void btnMediana_Click(object sender, EventArgs e)
        {
            {
                if (img1 != null)
                {
                    int largura = img1.Width;
                    int altura = img1.Height;

                    Bitmap imgFiltrada = new Bitmap(largura, altura);

                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            // Array para armazenar os valores dos 9 pixels vizinhos
                            int[] valores = new int[9];
                            int contador = 0;

                            // Varre a matriz 3x3 ao redor do pixel (x, y)
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel (R, G ou B, pois a imagem é em escala de cinza)
                                    valores[contador] = pixel.R; // Usando R, G e B são iguais para imagens em escala de cinza
                                    contador++;
                                }
                            }

                            Array.Sort(valores);

                            int valorMediano = valores[4];

                            imgFiltrada.SetPixel(x, y, Color.FromArgb(valorMediano, valorMediano, valorMediano));
                        }
                    }

                    pbImgResultado.Image = imgFiltrada;

                }
                else
                {
                    MessageBox.Show("Por favor, carregue uma imagem antes de aplicar o filtro.");
                }
            }
        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                // Verifica se o valor da TextBox está entre 0 e 8
                int posicao;
                if (!int.TryParse(txtOrdem.Text, out posicao) || posicao < 0 || posicao > 8)
                {
                    MessageBox.Show("Por favor, insira um valor entre 0 e 8.");
                    return;
                }

                Bitmap imgFiltrada = new Bitmap(largura, altura);

                for (int y = 1; y < altura - 1; y++)
                {
                    for (int x = 1; x < largura - 1; x++)
                    {
                        int[] valores = new int[9];
                        int contador = 0;

                        for (int j = -1; j <= 1; j++)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                Color pixel = img1.GetPixel(x + i, y + j);
                                valores[contador] = pixel.R;
                                contador++;
                            }
                        }

                        Array.Sort(valores);

                        int valorSelecionado = valores[posicao];

                        imgFiltrada.SetPixel(x, y, Color.FromArgb(valorSelecionado, valorSelecionado, valorSelecionado));
                    }
                }

                pbImgResultado.Image = imgFiltrada;
            }
            else
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de aplicar o filtro.");
            }
        }

        private void btnSuavizacaoConservativa_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgFiltrada = new Bitmap(largura, altura);

                for (int y = 1; y < altura - 1; y++)
                {
                    for (int x = 1; x < largura - 1; x++)
                    {
                        int[] valoresVizinhos = new int[8];
                        int contador = 0;

                        Color pixelCentral = img1.GetPixel(x, y);
                        int valorCentral = pixelCentral.R; 

                        for (int j = -1; j <= 1; j++)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (i == 0 && j == 0)
                                    continue;

                                Color pixelVizinho = img1.GetPixel(x + i, y + j);
                                valoresVizinhos[contador] = pixelVizinho.R;
                                contador++;
                            }
                        }

                        int valorMaximo = valoresVizinhos.Max();
                        int valorMinimo = valoresVizinhos.Min();

                        int novoValor;
                        if (valorCentral > valorMaximo)
                        {
                            novoValor = valorMaximo;
                        }
                        else if (valorCentral < valorMinimo)
                        {
                            novoValor = valorMinimo;
                        }
                        else
                        {
                            novoValor = valorCentral; 
                        }

                        imgFiltrada.SetPixel(x, y, Color.FromArgb(novoValor, novoValor, novoValor));
                    }
                }

                pbImgResultado.Image = imgFiltrada;
            }
            else
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de aplicar o filtro.");
            }

        }

        private void btnGaussiano_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de aplicar o filtro.");
                return;
            }

            if (!IsGrayscaleImage(img1))
            {
                MessageBox.Show("A imagem não está em preto e branco. Carregue uma imagem em escala de cinza.");
                return;
            }

            // Obter o valor de sigma da TextBox
            if (!double.TryParse(txtGaussiano.Text, out double sigma) || sigma <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido para sigma.");
                return;
            }

            int largura = img1.Width;
            int altura = img1.Height;

            // Criar o kernel gaussiano 5x5
            double[,] kernel = new double[5, 5];
            double soma = 0.0;
            int halfSize = 2; // Para um kernel 5x5

            // Gerar o kernel gaussiano
            for (int y = -halfSize; y <= halfSize; y++)
            {
                for (int x = -halfSize; x <= halfSize; x++)
                {
                    double gauss = (1 / (2 * Math.PI * sigma * sigma)) *
                                   Math.Exp(-(x * x + y * y) / (2 * sigma * sigma));
                    kernel[y + halfSize, x + halfSize] = gauss;
                    soma += gauss;
                }
            }

            // Normalizar o kernel
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    kernel[y, x] /= soma;
                }
            }

            Bitmap imgFiltrada = new Bitmap(largura, altura);

            // Aplicar o filtro usando convolução
            for (int y = 2; y < altura - 2; y++)
            {
                for (int x = 2; x < largura - 2; x++)
                {
                    double intensidade = 0;

                    // Convolução para intensidade (escala de cinza)
                    for (int ky = -halfSize; ky <= halfSize; ky++)
                    {
                        for (int kx = -halfSize; kx <= halfSize; kx++)
                        {
                            Color pixel = img1.GetPixel(x + kx, y + ky);

                            // Calcular a intensidade média (escala de cinza)
                            byte intensidadePixel = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                            double coef = kernel[ky + halfSize, kx + halfSize];

                            // Somar o valor da intensidade ponderado pelo coeficiente do kernel
                            intensidade += intensidadePixel * coef;
                        }
                    }

                    int valorFinal = Clamp((int)intensidade);
                    imgFiltrada.SetPixel(x, y, Color.FromArgb(valorFinal, valorFinal, valorFinal));
                }
            }

            pbImgResultado.Image = imgFiltrada;
        }

        // Método auxiliar para garantir que os valores estejam entre 0 e 255
        private int Clamp(int valor)
        {
            return Math.Max(0, Math.Min(255, valor));
        }

        // Função para verificar se a imagem é em preto e branco (escala de cinza)
        private bool IsGrayscaleImage(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);

                    if (pixel.R != pixel.G || pixel.G != pixel.B)
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }

        private void btnPrewitt_Click(object sender, EventArgs e)
        {
            {
                if (img1 == null)
                {
                    MessageBox.Show("Carregue uma imagem antes de aplicar o filtro.");
                    return;
                }

                int largura = img1.Width;
                int altura = img1.Height;
                Bitmap imgFiltrada = new Bitmap(largura, altura);

                for (int y = 1; y < altura - 1; y++)
                {
                    for (int x = 1; x < largura - 1; x++)
                    {
                        // Valores dos pixels vizinhos para Gx
                        int v00x = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                        int v01x = img1.GetPixel(x - 1, y).R;     // Cima
                        int v02x = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                        int v10x = img1.GetPixel(x, y - 1).R;     // Esquerda
                        int v11x = img1.GetPixel(x, y).R;         // Centro
                        int v12x = img1.GetPixel(x, y + 1).R;     // Direita
                        int v20x = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                        int v21x = img1.GetPixel(x + 1, y).R;     // Baixo
                        int v22x = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                        // Calcular Gx
                        double gx = (-1 * v00x) + (0 * v01x) + (1 * v02x) +
                                    (-1 * v10x) + (0 * v11x) + (1 * v12x) +
                                    (-1 * v20x) + (0 * v21x) + (1 * v22x);

                        // Valores dos pixels vizinhos para Gy
                        int v00y = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                        int v01y = img1.GetPixel(x - 1, y).R;     // Cima
                        int v02y = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                        int v10y = img1.GetPixel(x, y - 1).R;     // Esquerda
                        int v11y = img1.GetPixel(x, y).R;         // Centro
                        int v12y = img1.GetPixel(x, y + 1).R;     // Direita
                        int v20y = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                        int v21y = img1.GetPixel(x + 1, y).R;     // Baixo
                        int v22y = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                        // Calcular Gy
                        double gy = (-1 * v00y) + (-1 * v01y) + (-1 * v02y) +
                                    (0 * v10y) + (0 * v11y) + (0 * v12y) +
                                    (1 * v20y) + (1 * v21y) + (1 * v22y);

                        // Calcular a magnitude e aplicar o clamp
                        int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                        imgFiltrada.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                    }
                }

                pbImgResultado.Image = imgFiltrada;
            }

        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem antes de aplicar o filtro.");
                return;
            }

            int largura = img1.Width;
            int altura = img1.Height;
            Bitmap imgFiltrada = new Bitmap(largura, altura);

            for (int y = 1; y < altura - 1; y++)
            {
                for (int x = 1; x < largura - 1; x++)
                {
                    // Valores dos pixels vizinhos para Gx
                    int v00x = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                    int v01x = img1.GetPixel(x - 1, y).R;     // Cima
                    int v02x = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                    int v10x = img1.GetPixel(x, y - 1).R;     // Esquerda
                    int v11x = img1.GetPixel(x, y).R;         // Centro
                    int v12x = img1.GetPixel(x, y + 1).R;     // Direita
                    int v20x = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                    int v21x = img1.GetPixel(x + 1, y).R;     // Baixo
                    int v22x = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                    // Calcular Gx usando o kernel de Sobel
                    int gx = (-1 * v00x) + (0 * v01x) + (1 * v02x) +
                             (-2 * v10x) + (0 * v11x) + (2 * v12x) +
                             (-1 * v20x) + (0 * v21x) + (1 * v22x);

                    // Valores dos pixels vizinhos para Gy
                    int v00y = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                    int v01y = img1.GetPixel(x - 1, y).R;     // Cima
                    int v02y = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                    int v10y = img1.GetPixel(x, y - 1).R;     // Esquerda
                    int v11y = img1.GetPixel(x, y).R;         // Centro
                    int v12y = img1.GetPixel(x, y + 1).R;     // Direita
                    int v20y = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                    int v21y = img1.GetPixel(x + 1, y).R;     // Baixo
                    int v22y = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                    // Calcular Gy usando o kernel de Sobel
                    int gy = (1 * v00y) + (2 * v01y) + (1 * v02y) +
                             (0 * v10y) + (0 * v11y) + (0 * v12y) +
                             (-1 * v20y) + (-2 * v21y) + (-1 * v22y);

                    // Calcular a magnitude e aplicar o clamp
                    int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                    imgFiltrada.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                }
            }

            pbImgResultado .Image = imgFiltrada;
        }

        private void btnLaplaciano_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem antes de aplicar o filtro.");
                return;
            }

            int largura = img1.Width;
            int altura = img1.Height;
            Bitmap imgFiltrada = new Bitmap(largura, altura);

            for (int y = 1; y < altura - 1; y++)
            {
                for (int x = 1; x < largura - 1; x++)
                {
                    // Valores dos pixels vizinhos para Gx
                    int v00x = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                    int v01x = img1.GetPixel(x - 1, y).R;     // Cima
                    int v02x = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                    int v10x = img1.GetPixel(x, y - 1).R;     // Esquerda
                    int v11x = img1.GetPixel(x, y).R;         // Centro
                    int v12x = img1.GetPixel(x, y + 1).R;     // Direita
                    int v20x = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                    int v21x = img1.GetPixel(x + 1, y).R;     // Baixo
                    int v22x = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                    // Calcular Gx usando o kernel Laplaciano
                    int gx = (0 * v00x) + (1 * v01x) + (0 * v02x) +
                             (1 * v10x) + (-4 * v11x) + (1 * v12x) +
                             (0 * v20x) + (1 * v21x) + (0 * v22x);

                    // Valores dos pixels vizinhos para Gy
                    int v00y = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                    int v01y = img1.GetPixel(x - 1, y).R;     // Cima
                    int v02y = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                    int v10y = img1.GetPixel(x, y - 1).R;     // Esquerda
                    int v11y = img1.GetPixel(x, y).R;         // Centro
                    int v12y = img1.GetPixel(x, y + 1).R;     // Direita
                    int v20y = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                    int v21y = img1.GetPixel(x + 1, y).R;     // Baixo
                    int v22y = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                    // Calcular Gy usando o kernel Laplaciano
                    int gy = (0 * v00y) + (-1 * v01y) + (0 * v02y) +
                             (-1 * v10y) + (4 * v11y) + (-1 * v12y) +
                             (0 * v20y) + (-1 * v21y) + (0 * v22y);

                    // A intensidade final pode ser baseada em gx ou gy (ou ambos)
                    int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                    imgFiltrada.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                }
            }

            pbImgResultado.Image = imgFiltrada;
        }

        private void btnDilatacao_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de aplicar o filtro.");
                return;
            }

            int largura = img1.Width;
            int altura = img1.Height;

            Bitmap imgDilatada = new Bitmap(largura, altura);

            // Percorrer a imagem original e aplicar a dilatação
            for (int y = 1; y < altura - 1; y++) 
            {
                for (int x = 1; x < largura - 1; x++) 
                {
                    bool dilatado = false;

                    // Verificar a vizinhança 3x3 ao redor do pixel (x, y)
                    for (int ky = -1; ky <= 1; ky++) // Loop vertical
                    {
                        for (int kx = -1; kx <= 1; kx++) // Loop horizontal
                        {
                            // Criar a cruz do elemento estruturante 3x3
                            if (kx == 0 || ky == 0) // A cruz é composta por elementos na linha e coluna centrais
                            {
                                Color pixel = img1.GetPixel(x + kx, y + ky);

                                // Verificar se o pixel é "diferente de 0" (qualquer pixel diferente de preto)
                                if (pixel.R > 0 || pixel.G > 0 || pixel.B > 0) // Se o pixel não for preto
                                {
                                    dilatado = true; // Se qualquer pixel na vizinhança for diferente de preto, dilata
                                    break;
                                }
                            }
                        }
                        if (dilatado) break;
                    }

                    // Se a vizinhança tem pelo menos um pixel "branco", dilate (coloque 1)
                    if (dilatado)
                    {
                        imgDilatada.SetPixel(x, y, Color.White); // Coloca branco (1 na imagem binária)
                    }
                    else
                    {
                        imgDilatada.SetPixel(x, y, Color.Black); // Coloca preto (0 na imagem binária)
                    }
                }
            }

            // Atualizar a PictureBox com a imagem dilatada
            pbImgResultado.Image = imgDilatada;
        }
    }
}


 