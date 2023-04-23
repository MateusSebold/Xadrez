namespace Xadrez.tabuleiro
{
    class Tabuleiro
    {
        protected int linhas { get; set; }
        protected int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }
    }
}