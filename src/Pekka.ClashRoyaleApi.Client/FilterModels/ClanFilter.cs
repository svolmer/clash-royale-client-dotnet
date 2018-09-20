﻿using Pekka.Core;
using IFilter = Pekka.ClashRoyaleApi.Client.Contracts.IFilter;

namespace Pekka.ClashRoyaleApi.Client.FilterModels
{
    public class ClanFilter : IFilter
    {
        [Query("name")]
        public string Name { get; set; }

        [Query("locationId")]
        public int? LocationId { get; set; }

        [Query("minMembers")]
        public int? MinMembers { get; set; }

        [Query("maxMembers")]
        public int? MaxMembers { get; set; }

        [Query("minScore")]
        public int? MinScore { get; set; }

        [Query("limit")]
        public int? Limit { get; set; }

        [Query("after")]
        public int? After { get; set; }

        [Query("before")]
        public int? Before { get; set; }
    }
}