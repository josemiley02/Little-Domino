namespace Domino
{
    public class Player
    {
        public List<(int,int)> Hand;

        public Player(List<(int, int)> hand)
        {
            Hand = hand;
        }

        public static List<(int, int)> GetHands(List<(int, int)> fichas)
        {
            List<(int, int)> Hand = new List<(int, int)>();
            while (Hand.Count < 7)
            {
                Hand.Add(fichas[0]);
                fichas.Remove(fichas[0]);
            }
            return Hand;
        }
    }
}