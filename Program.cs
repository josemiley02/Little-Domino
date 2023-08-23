namespace Domino
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamePieces.articles = new Articles();
            Game.NewGame();
        }
    }
}