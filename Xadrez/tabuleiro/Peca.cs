namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
      
        public Cor cor { get;  set; }
        public int movimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca (Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            movimentos = 0;
        }
    }
}
