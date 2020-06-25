using System.ComponentModel.DataAnnotations;


namespace AuctionApp.Models
{
    public class Auction
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "The field Title should not be blank.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The field Description should not be blank.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The field User should not be blank.")]
        public string User { get; set; }
        [Range(1,100000000000,ErrorMessage = "The field Current Bid should be greater than 0")]
        public double CurrentBid { get; set; }

        //public Auction(int? id, string title, string descrption, string user, double currentBid)
        //{
        //    Id = id;
        //    Title = title;
        //    Description = descrption;
        //    CurrentBid = currentBid;
        //}
    }
}
