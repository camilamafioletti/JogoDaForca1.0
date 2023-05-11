namespace JogoDaForca.WinFormsApp
{
    public class Forca
    {
        private string[] palavras = { "ABACAXI", "BANANA", "MELANCIA", "LARANJA", "MORANGO", "ABACATE", "ACEROLA" };
        public string palavraRandom;
        public string palavraCriptografada;
        public List<char> LetrasEscolhidas;

        public Forca()
        {
            Random random = new Random();
            palavraRandom = palavras[random.Next(palavras.Length)];
            palavraCriptografada = new string('_', palavraRandom.Length);
            LetrasEscolhidas = new List<char>();
        }
    }
}
