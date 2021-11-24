using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    public class Account:ZippyBase
    {
        public int Id { get; set; }
        public string AccountId { get; set; } = Guid.NewGuid().ToString();
        [ForeignKey("Client")]
        public int OwnnerId { get; set; }


    }
}
