using System;

namespace GuernseyPool.Model
{

    public class ScoreCard
    {
        public string League { get; set; }
        public Boolean IsWinterLeague { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public Team Home { get; set; } = new Team();
        public Team Away { get; set; } = new Team();
        public List<Frame> Frames { get; set; } = new List<Frame>();
        public string Comments { get; set; }
        public int HomeWins { get; set; }
        public int AwayWins { get; set; }

        public ScoreCard(Boolean IsWinterLeague){
            this.IsWinterLeague = IsWinterLeague;
        }

    }

    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }

    public class Frame
    {
        public int HomePlayerIndex { get; set; }
        public int AwayPlayerIndex { get; set; }
        public bool IsHomeWin { get; set; }
    }

}