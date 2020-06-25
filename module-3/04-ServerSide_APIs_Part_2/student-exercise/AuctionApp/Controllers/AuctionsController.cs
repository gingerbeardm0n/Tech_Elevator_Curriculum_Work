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
        private readonly AuctionDao dao;

        public AuctionsController(AuctionDao auctionDao = null)
        {
            if (auctionDao == null)
                dao = new AuctionDao();
            else
                dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction newAuction = dao.Create(auction);

            return Created($"/auctions/{newAuction.Id}", newAuction);
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(Auction auction, int id)
        {
            Auction existingAuction = dao.Get(id);

            if (existingAuction == null)
            {
                return NotFound("Auction does not exist, but what is existence anyway? That's what I'd like to know.");
            }
            Auction updatedAuction = dao.Update(id, auction);
            return Ok(updatedAuction);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Auction badAuction = dao.Get(id);
            if (badAuction == null)
            {
                return NotFound("Auction does not exist, so it can't be deleted.");
            }
            dao.Delete(id);
            return NoContent();
        }

    }
}
