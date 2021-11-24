using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    public class Client:ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        public string? Email { get; set; }
        public string UserToken { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Website { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public string? TaxID { get; set; }
        public string? TypeOfBusiness { get; set; }
        public string? PurposeOfBusiness { get; set; }
    }
}
