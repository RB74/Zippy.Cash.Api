using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Document Entity
    /// </summary>
    public class Document : ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Url is where the document is located.
        /// </summary>
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Entity is what/who the document is associated with. Can be a customer, merchant.
        /// </summary>
        public int EntityId { get; set; }

        public int VerificationStatusId { get; set; }
        public int TypeId { get; set; }

        [ForeignKey(nameof(VerificationStatusId))]
        public VerificationStatus VerificationStatus { get; set; }
        [ForeignKey(nameof(TypeId))]
        public DocumentType DocumentType { get; set; }
    }
}
