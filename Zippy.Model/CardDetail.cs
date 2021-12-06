using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Card Detail Entity
    /// </summary>
    public class CardDetail : ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Brand is VISA, Mastercard, etc..
        /// </summary>
        public string Brand { get; set; } = string.Empty;
        public int Number { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpriationYear { get; set; }
        /// <summary>
        /// Name is name on card
        /// </summary>
        public string Name { get; set; } = string.Empty;
        public int SourceId { get; set; }
    }
}
