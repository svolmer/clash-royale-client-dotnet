﻿using System.Threading.Tasks;
using Pekka.ClashRoyaleApi.Client.Contracts;
using Pekka.ClashRoyaleApi.Client.Models;
using Pekka.Core.Contracts;
using Pekka.Core.Helpers;
using Pekka.Core.Responses;

namespace Pekka.ClashRoyaleApi.Client.Clients
{
    public class CardClient : ICardClient
    {
        private readonly IRestApiClient _restApiClient;

        public CardClient(IRestApiClient restApiClient)
        {
            _restApiClient = restApiClient;
        }

        public async Task<ApiResponse<CardList>> GetCardsResponseAsync()
        {
            var apiResponse = await _restApiClient.GetApiResponseAsync<CardList>(UrlPathBuilder.CardUrl);

            return apiResponse;
        }

        public async Task<CardList> GetCardsAsync()
        {
            var apiResponse = await GetCardsResponseAsync();

            return apiResponse.GetModel();
        }
    }
}
