using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    class TournamentModel
    {
        public string TournamnetName { get; set; }
        public decimal Entryfee { get; set; }
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();



    }
}
