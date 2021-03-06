﻿using System.Threading.Tasks;
using Pekka.ClashRoyaleApi.Client.FilterModels;
using Pekka.ClashRoyaleApi.Client.Models.TournamentModels;
using Pekka.Core.Responses;

namespace Pekka.ClashRoyaleApi.Client.Contracts
{
    public interface ITournamentClient
    {
        Task<ApiResponse<TournamentSearchResult>> SearchTournamentResponseAsync(TournamentFilter tournamentFilter);
        Task<ApiResponse<Tournament>> GetTournamentResponseAsync(string tournamentTag);
        Task<TournamentSearchResult> SearchTournamentAsync(TournamentFilter tournamentFilter);
        Task<Tournament> GetTournamentAsync(string tournamentTag);
    }
}