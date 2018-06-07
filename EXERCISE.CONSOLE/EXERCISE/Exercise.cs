using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; }

        private Player()
        {

        }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    public class FiveASide
    {
        public static int ChooseSides(Player[] players)
        {
            List<Player> list = new List<Player>(players);
            // se dispari aggiungo un player con nome "#" e score 0 (verrà eliminato)
            if ((list.Count % 2) != 0)
            {
                list.Add(new Player("#", 0));
            }
            int playerNumber = list.Count;

            // divide ciecamente in due squadre
            List<Player> team1 = new List<Player>(list.Take(playerNumber/2));
            List<Player> team2 = new List<Player>(list.Skip(playerNumber/2));

            // terrà la differenza della somma dei punti di t1 - t2
            int minDifference = Math.Abs(team1.Sum(p => p.Score) - team2.Sum(p => p.Score));

            // numero di iterazioni necessari per questa sessione
            int iterations = (int)Math.Pow(2, playerNumber / 2) / 2;

            for (int i = 0; i < iterations; i++)
            {
                Utilities.Swap(team1, team2, Utilities.GreyIndexs[i]);
                int curDifference = Math.Abs(team1.Sum(p => p.Score) - team2.Sum(p => p.Score));
                if (curDifference < minDifference)
                {
                    minDifference = curDifference;
                }
            }

            return Math.Abs(minDifference);
        }
    }
}
