using JogoDaForca.WinFormsApp.Properties;
using System.Diagnostics.Contracts;

namespace JogoDaForca.WinFormsApp
{
    public partial class Form1 : Form
    {
        Forca forca;

        public Form1()
        {
            InitializeComponent();

            RegistrarEventos();

            forca = new Forca();

            ObterPalavraParcial();

        }

        private void RegistrarEventos()
        {
            foreach (Button botao in pnlBotoes.Controls)
            {
                botao.Click += DarPalpite;
                botao.Click += AtualizarBotoesPainel;
            }

            btnNovoJogo.Click += ReiniciarJogo;
        }

        private void DarPalpite(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            char palpite = botaoClicado.Text[0];

            if (forca.JogadorAcertou(palpite) || forca.JogadorPerdeu())
                FinalizarJogo();

            ObterPalavraParcial();

            AtualizarForca();
        }
        private void ReiniciarJogo(object sender, EventArgs e)
        {
           forca = new Forca();

            ObterPalavraParcial();

            ObterDicaPalavra();

            AtualizarForca();

            lblMensagemFinal.Text = "";

            pnlBotoes.Enabled = true;

            foreach (Button botao in pnlBotoes.Controls)
                botao.Enabled = true;
        }

        private void AtualizarBotoesPainel(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            botaoClicado.Enabled = false;
        }
        private void FinalizarJogo()
        {

            bool jogadorPerdeu = forca.JogadorPerdeu();

            if (jogadorPerdeu)
                lblMensagemFinal.ForeColor = Color.Red;
            else
                lblMensagemFinal.ForeColor = Color.Green;

            pnlBotoes.Enabled = false;

            lblMensagemFinal.Text = forca.mensagemFinal;
        }

        private void AtualizarForca()
        {
            switch (forca.Erros)
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

                case 6: imgPernaE.Visible = true;break;

                default:
                    imgForca.Image = Properties.Resources.forca;
                  
                    break;
            }
        }
        private void ObterPalavraParcial()
        {
            lblPalavra.Text = forca.PalavraParcial;
        }

        private void ObterDicaPalavra()
        {
            lblDica.Text = forca.QuantidadeLetras + " letras";
        }
    }
}