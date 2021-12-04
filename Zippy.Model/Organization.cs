using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Entity represents Zippy companies
    /// We can have multiple Zippys in different countries
    /// </summary>
    public class Organization : ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TaxID { get; set; } = string.Empty;
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public string AccountId { get; set; } = string.Empty;
    }
}
