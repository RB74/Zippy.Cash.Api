using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Client entity represents Merchant or Person 
    /// </summary>
    public class Client : ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        public string Email { get; set; } = string.Empty;
        public string UserToken { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
        public string TaxID { get; set; } = string.Empty;
        public string TypeOfBusiness { get; set; } = string.Empty;
        public string PurposeOfBusiness { get; set; } = string.Empty;
    }
}
