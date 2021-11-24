using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    public class Organization:ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? TaxID { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public int AccountId { get; set; }
    }
}
