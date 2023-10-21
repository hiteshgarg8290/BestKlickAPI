using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoContestAPI.Model
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string GovtIdType { get; set; }
        [Required]
        public string GovtIdNumber { get; set; }
        [Required]
        public bool IsBlackListed { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public List<VoteModel> Votes { get; set; }
        public virtual UserModel User { get; set; }
    }
}
