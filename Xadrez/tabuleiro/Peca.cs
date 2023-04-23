namespace Xadrez.tabuleiro
{
    class Peca
    {
        protected Posicao posicao { get; set; }
      
        protected Cor cor { get;  set; }
        protected int movimentos { get; set; }
        protected Tabuleiro tabuleiro { get; set; }

        public Peca (Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            movimentos = 0;
        }
    }
}
