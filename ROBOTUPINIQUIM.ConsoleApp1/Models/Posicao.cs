namespace Tupiniquim.Models
{
    public class Posicao
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direcao { get; set; } // N, S, L, O

        public Posicao(int x, int y, char direcao)
        {
            X = x;
            Y = y;
            Direcao = direcao;
        }
    }
}
