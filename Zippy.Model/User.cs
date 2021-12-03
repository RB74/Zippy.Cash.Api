using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// User entity, represents applications users
    /// </summary>
    public class User : ZippyBase
    {
        public User()
        {
            UserRoles = new List<UserRole>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int ClientId { get; set; }
        public int ContactId { get; set; }
        /// <summary>
        /// Indicating whether the customer's identity has been verified or not
        /// </summary>
        public bool Verified { get; set; }
        public DateTimeOffset DOB { get; set; } = DateTimeOffset.Now;
        public string Id_adb2c { get; set; } = string.Empty;
        public string Metadata { get; set; } = string.Empty;

        [ForeignKey(nameof(StatusId))]
        public UserStatus UserStatus { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}