using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// UserStatus entity, Statuses will be activated, deactivated, suspended, pending
    /// </summary>
    public class UserStatus : ZippyBase
    {
        public UserStatus()
        {
            Users = new List<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<User> Users { get; set; }
    }
}