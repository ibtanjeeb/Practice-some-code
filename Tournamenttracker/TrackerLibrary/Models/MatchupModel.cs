using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchupModelEntryModel> Enteries { get; set; } = new List<MatchupModelEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }


    }
}
