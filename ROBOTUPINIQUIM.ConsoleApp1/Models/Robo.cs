namespace Tupiniquim.Models
{
    public class Robo
    {
        public Posicao Posicao { get; private set; }

        public Robo(Posicao posicao)
        {
            Posicao = posicao;
        }
    }
}
