﻿using System.Collections.Generic;

namespace Pekka.RoyaleApi.Client.Models.ClanModels
{
    public class ClanWarLog
    {
        public int CreatedDate { get; set; }
        public List<ClanWarParticipant> Participants { get; set; }
        public List<ClanWarInfoClan> Standings { get; set; }
        public int SeasonNumber { get; set; }
    }
}