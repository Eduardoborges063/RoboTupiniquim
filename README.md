🏁 Jogo de Corrida de Dados — Console C#

Um jogo simples e divertido feito em C# Console, onde dois carros correm enquanto dados são lançados.
Cada rodada avança o carro conforme o valor obtido nos dados.
Vence o carro que alcançar a linha de chegada primeiro!

🚗 Funcionalidades
🎲 Mecânica do jogo

Dois jogadores (Carro 1 e Carro 2)

A cada rodada:

Sorteia-se dois dados

A pontuação dos dados movimenta o carro correspondente

A corrida continua até alguém atingir a distância final

🏎️ Animação simples no console

Os carros avançam visualmente com - formando a pista

Atualização a cada rodada

📄 Exibição de status

Mostra:

Pontuação dos dados

Posição atual dos carros

Rodada atual

No final:

Declara o vencedor

📜 Menu inicial

1. Iniciar corrida

2. Ver regras

3. Créditos

4. Sair

📁 Estrutura de Pastas
/JogoCorridaDados
│
├── Program.cs
│
├── /Menu
│   ├── MenuPrincipal.cs
│   └── RegrasDoJogo.cs
│
├── /Jogo
│   ├── Corrida.cs
│   ├── Carro.cs
│   └── Dados.cs
│
└── /Utils
    ├── Animacao.cs
    └── InputHelper.cs

▶️ Como executar
Pré-requisitos

.NET 6 ou superior

Execução
dotnet run

📘 Regras do Jogo

Cada carro avança conforme o resultado dos dados.

O primeiro carro a atingir a distância final vence.

Empate é possível caso alcancem juntos.

👨‍💻 Tecnologias usadas

C#

.NET Console

Programação estruturada

Orientação a objetos (POO)

🧾 Licença

Código livre para estudos.
