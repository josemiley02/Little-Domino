namespace Domino
{
    public static class Game
    {
        public static void NewGame()
        {
            int player = 0;
            for (int i = 0; i < 4; i++)
            {
                if(GamePieces.articles!.Players[i].Hand.Contains((6,6)))
                {
                    GamePieces.articles.Table.Add((6,6));
                    GamePieces.articles.Players[i].Hand.Remove((6,6));
                    player = i;
                    System.Console.WriteLine($"Player{i} incio el juego");
                    System.Console.WriteLine();
                    Prints.Table();
                    break;
                }
            }
            GameCicle(player + 1);
        }
        public static bool Winner()
        {
            foreach (var item in GamePieces.articles!.Players)
            {
                if(item.Hand.Count == 0) return true;
            }
            return false;
        }
        public static void GameCicle(int actualplayer)
        {
            Player[] players = GamePieces.articles!.Players;
            int tranc = 0;
            while (!Winner())
            {
                if(Rules.CanPlay(players[actualplayer % 4]))
                {
                    tranc = 0;
                    System.Console.WriteLine($"Turno del Player{actualplayer % 4}");
                    System.Console.WriteLine();
                    Prints.Hand(players[actualplayer % 4]);
                    int select = int.Parse(Console.ReadLine()!);
                    while(select >= players[actualplayer % 4].Hand.Count || !Rules.IsValidPlay(players[actualplayer % 4].Hand[select]))
                    {
                        System.Console.WriteLine("Selecciona otra posicion");
                        select = int.Parse(Console.ReadLine()!);
                    }
                    players[actualplayer % 4].Hand.RemoveAt(select);
                    System.Console.WriteLine();
                    Prints.Table();
                }
                else
                {
                    tranc += 1;
                    if(tranc == 4)
                    {
                        System.Console.WriteLine("El Juego Termino");
                        return;
                    }
                    System.Console.WriteLine($"Player{actualplayer % 4} no lleva");
                }
                actualplayer += 1;
            }
        }
    }
}