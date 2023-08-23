namespace Domino
{
    public class Articles
    {
        public List<(int,int)> Fichas;
        public List<(int, int)> Table;
        public Player[] Players = new Player[4];
        public int Cant;

        public Articles()
        {
            Fichas = GetFichas();
            Table = new();
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i] = new Player(Player.GetHands(this.Fichas));
            }
        }

        public List<(int,int)> GetFichas()
        {
            List<(int,int)> fichas = new();
            for (int i = 0; i < 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    fichas.Add((i,j));
                }
            }
            return Merge(fichas);
        }
        public List<(int,int)> Merge(List<(int,int)> fichas)
        {
            Random R = new Random();
            List<(int,int)> ready = new();
            while (ready.Count != fichas.Count)
            {
                int add = R.Next(0,fichas.Count);
                if(!ready.Contains(fichas[add]))
                {
                    ready.Add(fichas[add]);
                }
            }
            return ready;
        }
    }
}