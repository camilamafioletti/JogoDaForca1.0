using JogoDaForca.WinFormsApp.Properties;
using System.Diagnostics.Contracts;

namespace JogoDaForca.WinFormsApp
{
    public partial class Form1 : Form
    {
        private int numErros = 0;

        Forca forca;

        public Form1()
        {
            forca = new Forca();
            InitializeComponent();
            ConfigurarBotoes();
        }

        private void ConfigurarBotoes()
        {
            btnA.Click += AtribuirLetra;
            btnB.Click += AtribuirLetra;
            btnC.Click += AtribuirLetra;
            btnD.Click += AtribuirLetra;
            btnE.Click += AtribuirLetra;
            btnF.Click += AtribuirLetra;
            btnG.Click += AtribuirLetra;
            btnH.Click += AtribuirLetra;
            btnI.Click += AtribuirLetra;
            btnJ.Click += AtribuirLetra;
            btnK.Click += AtribuirLetra;
            btnL.Click += AtribuirLetra;
            btnM.Click += AtribuirLetra;
            btnN.Click += AtribuirLetra;
            btnO.Click += AtribuirLetra;
            btnP.Click += AtribuirLetra;
            btnQ.Click += AtribuirLetra;
            btnR.Click += AtribuirLetra;
            btnS.Click += AtribuirLetra;
            btnT.Click += AtribuirLetra;
            btnU.Click += AtribuirLetra;
            btnV.Click += AtribuirLetra;
            btnW.Click += AtribuirLetra;
            btnX.Click += AtribuirLetra;
            btnY.Click += AtribuirLetra;
            btnZ.Click += AtribuirLetra;
            btnCedilha.Click += AtribuirLetra;
        }
        private void AtribuirLetra(object sender, EventArgs e)
        {
            lblPalavra.Text = forca.palavraCriptografada;

            Button botaoClicado = (Button)sender;
            char letra = botaoClicado.Text.ToUpper()[0];

            if (forca.LetrasEscolhidas.Contains(letra))
            {
                MessageBox.Show("Letra ja escolhida!");
                return;
            }

            forca.LetrasEscolhidas.Add(letra);

            if (forca.palavraRandom.Contains(letra))
            {
                for (int i = 0; i < forca.palavraRandom.Length; i++)
                {
                    if (forca.palavraRandom[i] == letra)
                    {
                        forca.palavraCriptografada = forca.palavraCriptografada.Substring(0, i) + letra + forca.palavraCriptografada.Substring(i + 1);
                    }
                }

                lblPalavra.Text = forca.palavraCriptografada;

                botaoClicado.BackColor = Color.Olive;

                if (forca.palavraCriptografada == forca.palavraRandom)
                {
                    MessageBox.Show("Parabéns, você acertou a palavra!");
                }
            }
            else
            {
                botaoClicado.BackColor = Color.Peru;

                numErros++;

                switch (numErros)
                {
                    case 1:
                        imgCabeca.Visible = true; break;
                    case 2:
                        imgCorpo.Visible = true; break;
                    case 3:
                        imgBracoD.Visible = true; break;
                    case 4:
                        imgBracoE.Visible = true; break;
                    case 5:
                        imgPernaD.Visible = true; break;

                    case 6:
                        imgPernaE.Visible = true;
                        MessageBox.Show("Que pena, você perdeu! A palavra era " + forca.palavraRandom);
                        break;
                }
            }
        }
    }
}