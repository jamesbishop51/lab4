using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    public enum Result
    {
        Win,
        Draw,
        Lose

    }
    class Team
    {

        public string Teams { get; private set; }

        public int NoOfWins { get; private set; }

        public int NoOfDraws { get; private set; }

        public int NoOflosses { get; private set; }

        public int NoOfGames { get; private set; }

        private int points;

        public int Points
        {
            get
            {
                points = (NoOfWins * 3) + (NoOfDraws * 1);
                return points;
            }
        }
        public Team(string name)
        {
            Teams = name;
        }


        public string DisplayTeamTable()
        {
            return string.Format($"{Teams,-15}{Points,-7}{NoOfWins, -7}{NoOfDraws, -7}{NoOflosses,-7}{NoOfGames,-7}");
        }

        public void Addresult(Result result)
        {
            NoOfGames++;

            switch (result)
            {
                case Result.Win:
                    NoOfWins++;
                    break;

                case Result.Draw:
                    NoOfDraws++;
                    break;
                case Result.Lose:
                    NoOflosses++;
                    break;


            }
        }

    }
    
}
