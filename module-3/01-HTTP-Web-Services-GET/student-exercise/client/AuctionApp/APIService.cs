using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        RestClient client = new RestClient();
        string URL = "http://localhost:3000/";

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(URL + "auctions");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if(response.Data == null)
            {
                response.Data = new List<Auction>();
            }

            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            throw new NotImplementedException();
        }
    }
}
