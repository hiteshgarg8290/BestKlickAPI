using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoContestAPI.Model
{
    public class AdminModel 
    {
        [Key]
        public int AdminId { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }

        public virtual UserModel User { get; set; }
    }
}
