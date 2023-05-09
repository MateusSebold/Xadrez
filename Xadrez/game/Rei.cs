using Xadrez.tabuleiro;

namespace Xadrez.game
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro,Cor cor) : base(tabuleiro,cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
