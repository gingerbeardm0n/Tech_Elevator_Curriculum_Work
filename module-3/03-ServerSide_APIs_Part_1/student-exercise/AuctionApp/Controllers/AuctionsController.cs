using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao _dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
                _dao = new AuctionDao();
            else
                _dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0D)
        {

            if (!string.IsNullOrEmpty(title_like))
            {
                return _dao.SearchByTitle(title_like);
            }

            if (title_like == "" && currentBid_lte > 0)
            {
                return _dao.SearchByPrice(currentBid_lte);
            }
            return _dao.List();
        }


        [HttpGet("{id}")]
        public Auction Get(int id)
        {
            return _dao.Get(id);
        }

        [HttpPost]
        public Auction Create(Auction inputAuction)
        {
            Auction specificAuction = _dao.Create(inputAuction);

            if (specificAuction.IsValid == true)
            {
                return specificAuction;
            }
            return null;
        }


    }



}

