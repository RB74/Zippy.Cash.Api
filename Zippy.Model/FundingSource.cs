using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// FundingSource entity, A funding source of type balance has a ledger.
    /// </summary>
    public class FundingSource : ZippyBase
    {
        public FundingSource()
        {
            ProcessingChannels = new List<ProcessingChannel>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// SourceId can be a User (customer) id or a merchant (business) id
        /// </summary>
        public int SourceId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        public int BankDetailsId { get; set; }
        public int CardDetailId { get; set; }
        public int LedgerId { get; set; }
        /// <summary>
        /// Removed is a bool indicating if it was removed or not.
        /// </summary>
        public bool Removed { get; set; }
        public string Metadata { get; set; } = string.Empty;

        public ICollection<ProcessingChannel> ProcessingChannels { get; set; }

        [ForeignKey(nameof(CardDetailId))]
        public CardDetail CardDetail { get; set; }
    }
}
