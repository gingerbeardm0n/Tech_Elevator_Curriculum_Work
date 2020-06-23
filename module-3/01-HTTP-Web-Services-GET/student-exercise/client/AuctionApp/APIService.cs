using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        RestClient client = new RestClient();
<<<<<<< HEAD
        string URL = "http://localhost:3001/";
=======
        string URL = "http://localhost:3000/";
>>>>>>> 4ff26181376882962c9fd240352702503bc5d88e

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(URL + "auctions");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
<<<<<<< HEAD
            if (response.Data == null)
            {
                response.Data = new List<Auction>();
            }
=======
            if(response.Data == null)
            {
                response.Data = new List<Auction>();
            }

>>>>>>> 4ff26181376882962c9fd240352702503bc5d88e
            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(URL + "auctions/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(request);
            if (response.Data == null)
            {
                response.Data = new Auction();
            }
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(URL + "auctions?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.Data == null)
            {
                response.Data = new List<Auction>();
            }
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(URL + "auctions?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (response.Data == null)
            {
                response.Data = new List<Auction>();
            }
            return response.Data;
        }
    }
}
