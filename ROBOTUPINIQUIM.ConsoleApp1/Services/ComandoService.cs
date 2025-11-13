using Tupiniquim.Models;

namespace Tupiniquim.Services
{
    public class ComandoService
    {
        public void ExecutarComandos(Robo robo, Area area, string comandos)
        {
            foreach (char comando in comandos)
            {
                switch (comando)
                {
                    case 'E':
                        VirarEsquerda(robo.Posicao);
                        break;

                    case 'D':
                        VirarDireita(robo.Posicao);
                        break;

                    case 'M':
                        Mover(robo.Posicao, area);
                        break;

                    default:
                        throw new Exception($"Comando inválido: {comando}");
                }
            }
        }

        private void VirarEsquerda(Posicao p)
        {
            p.Direcao = p.Direcao switch
            {
                'N' => 'O',
                'O' => 'S',
                'S' => 'L',
                'L' => 'N',
                _ => p.Direcao
            };
        }

        private void VirarDireita(Posicao p)
        {
            p.Direcao = p.Direcao switch
            {
                'N' => 'L',
                'L' => 'S',
                'S' => 'O',
                'O' => 'N',
                _ => p.Direcao
            };
        }

        private void Mover(Posicao p, Area area)
        {
            int novoX = p.X;
            int novoY = p.Y;

            switch (p.Direcao)
            {
                case 'N': novoY++; break;
                case 'S': novoY--; break;
                case 'L': novoX++; break;
                case 'O': novoX--; break;
            }

            if (!area.DentroDoLimite(novoX, novoY))
                return; // Impede sair da área

            p.X = novoX;
            p.Y = novoY;
        }
    }
}
