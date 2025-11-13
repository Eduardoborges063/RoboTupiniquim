using Tupiniquim.Models;

namespace Tupiniquim.Services
{
    public class MenuService
    {
        private Area? area;
        private List<(Robo robo, string comandos)> filaRobos = new();

        private readonly ComandoService comandoService = new();

        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====== ROBÔ TUPINIQUIM — MENU PRINCIPAL ======\n");
                Console.WriteLine("1 - Definir área");
                Console.WriteLine("2 - Adicionar robô à fila");
                Console.WriteLine("3 - Executar todos os robôs");
                Console.WriteLine("4 - Listar robôs adicionados");
                Console.WriteLine("5 - Resetar tudo");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        DefinirArea();
                        break;
                    case "2":
                        AdicionarRobo();
                        break;
                    case "3":
                        ExecutarRobos();
                        break;
                    case "4":
                        ListarRobos();
                        break;
                    case "5":
                        Resetar();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Pause();
                        break;
                }
            }
        }

        private void DefinirArea()
        {
            Console.Clear();
            Console.WriteLine("=== Definir área ===");

            Console.Write("Digite o tamanho máximo X: ");
            int maxX = int.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho máximo Y: ");
            int maxY = int.Parse(Console.ReadLine());

            area = new Area(maxX, maxY);

            Console.WriteLine("\nÁrea definida com sucesso!");
            Pause();
        }

        private void AdicionarRobo()
        {
            if (area == null)
            {
                Console.WriteLine("⚠ Defina a área primeiro!");
                Pause();
                return;
            }

            Console.Clear();
            Console.WriteLine("=== Adicionar Robô ===");

            Console.Write("Posição X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Posição Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Direção (N/S/L/O): ");
            char dir = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Comandos (E, D, M): ");
            string comandos = Console.ReadLine().Trim().ToUpper();

            var robo = new Robo(new Posicao(x, y, dir));
            filaRobos.Add((robo, comandos));

            Console.WriteLine("\nRobô adicionado à fila!");
            Pause();
        }

        private void ExecutarRobos()
        {
            if (area == null)
            {
                Console.WriteLine("⚠ Defina a área primeiro!");
                Pause();
                return;
            }

            Console.Clear();
            Console.WriteLine("=== Executar Todos os Robôs ===\n");

            foreach (var item in filaRobos)
            {
                comandoService.ExecutarComandos(item.robo, area, item.comandos);
                Console.WriteLine($"Resultado: {item.robo.Posicao.X} {item.robo.Posicao.Y} {item.robo.Posicao.Direcao}");
            }

            Console.WriteLine("\nExecução finalizada!");
            Pause();
        }

        private void ListarRobos()
        {
            Console.Clear();
            Console.WriteLine("=== Robôs Adicionados ===\n");

            if (!filaRobos.Any())
            {
                Console.WriteLine("Nenhum robô adicionado.");
            }
            else
            {
                for (int i = 0; i < filaRobos.Count; i++)
                {
                    var r = filaRobos[i].robo.Posicao;
                    Console.WriteLine($"{i + 1}. Posição inicial: {r.X} {r.Y} {r.Direcao} | Comandos: {filaRobos[i].comandos}");
                }
            }

            Pause();
        }

        private void Resetar()
        {
            area = null;
            filaRobos.Clear();

            Console.WriteLine("\nSistema resetado!");
            Pause();
        }

        private void Pause()
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
