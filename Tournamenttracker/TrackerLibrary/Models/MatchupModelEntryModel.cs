using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModelEntryModel
    {
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

        public MatchupModelEntryModel (double initialScore)
        {
            Console.WriteLine();
        }

    }
}
