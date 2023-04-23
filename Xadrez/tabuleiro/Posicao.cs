namespace Xadrez.tabuleiro
{
    class Posicao { 
        protected int linha { get; set; }
        protected int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }
        public Posicao() { }

        public override string ToString()
        {
            return (linha +", "+coluna).ToString();
        }
    }
}
