using System.ComponentModel.DataAnnotations;

namespace PhotoContestAPI.Model
{
    public class VoteModel
    {
        [Key]
        public int VoteId { set; get; }
        public string VoteCategory { set; get; }
        public int VoteCount { set; get; }
    }
}
