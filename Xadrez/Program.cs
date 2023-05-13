using Xadrez.tabuleiro;
using Xadrez.game;

namespace Xadrez
{
     class Program
    {
        static void Main(string[] args) {
            try
            {

            Tabuleiro tabuleiro = new Tabuleiro(8,8);
            tabuleiro.colocarPeca(new Rei(tabuleiro,Cor.Branca),new Posicao(0,3));
            tabuleiro.colocarPeca(new Rei(tabuleiro,Cor.Preta),new Posicao(7,3));
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Branca),new Posicao(0,0));
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Branca),new Posicao(0,7));
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Preta),new Posicao(7,0));
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Preta),new Posicao(7,7));
            tabuleiro.colocarPeca(new Torre(tabuleiro,Cor.Preta), new Posicao(0,0));
            Tela.imprimirTabuleiro(tabuleiro);
            Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
