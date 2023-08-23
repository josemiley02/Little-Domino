namespace Domino
{
    public static class Prints
    {
        public static void Hand(Player player)
        {
            foreach (var item in player.Hand)
            {
                System.Console.Write(item);
            }
        }
        public static void Table()
        {
            foreach (var item in GamePieces.articles!.Table)
            {
                System.Console.Write(item);
            }
        }
    }
}