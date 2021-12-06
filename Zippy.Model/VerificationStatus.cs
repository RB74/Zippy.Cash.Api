using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Entity represents Verification Status, Values are pending, accepted or rejected
    /// </summary>
    public class VerificationStatus : ZippyBase
    {
        public VerificationStatus()
        {
            Documents = new List<Document>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Document> Documents { get; set; }
    }
}
