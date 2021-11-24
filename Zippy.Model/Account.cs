using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Account entity
    /// </summary>
    public class Account:ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string AccountId { get; set; } = Guid.NewGuid().ToString();
        [ForeignKey("Client")]
        public int OwnnerId { get; set; }
    }
}
