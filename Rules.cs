namespace Domino
{
    public static class Rules
    {
        public static bool CanPlay(Player player)
        {
            foreach (var ficha in player.Hand)
            {
                if (ficha.Item1 == GamePieces.articles!.Table[0].Item1) return true;
                if (ficha.Item2 == GamePieces.articles.Table[0].Item1) return true;
                if (ficha.Item1 == GamePieces.articles.Table[GamePieces.articles.Table.Count - 1].Item2) return true;
                if (ficha.Item2 == GamePieces.articles.Table[GamePieces.articles.Table.Count - 1].Item2) return true;
            }
            return false;
        }
        public static bool IsValidPlay((int, int) played)
        {
            if (played.Item1 == GamePieces.articles!.Table[0].Item1)
            {
                (int, int) newplay = (played.Item2, played.Item1);
                Put(newplay, 0);
                return true;
            }
            if (played.Item2 == GamePieces.articles.Table[0].Item1)
            {
                Put(played, 0);
                return true;
            }
            if (played.Item1 == GamePieces.articles.Table[GamePieces.articles.Table.Count - 1].Item2)
            {
                Put(played, 1);
                return true;
            }
            if (played.Item2 == GamePieces.articles.Table[GamePieces.articles.Table.Count - 1].Item2) 
            {
                (int, int) newplay = (played.Item2, played.Item1);
                Put(newplay, 1);
                return true;
            }
            return false;
        }
        public static void Put((int, int) played, int index)
        {
            if (index == 0)
            {
                GamePieces.articles!.Table.Insert(0, played);
            }
            else
            {
                GamePieces.articles!.Table.Add(played);
            }
        }
    }
}