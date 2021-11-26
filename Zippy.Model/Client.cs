using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Client entity represents Merchant or Person 
    /// </summary>
    public class Client:ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        public string Email { get; set; } = String.Empty;
        public string UserToken { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string Website { get; set; } = String.Empty;
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public string TaxID { get; set; } = String.Empty;
        public string TypeOfBusiness { get; set; } = String.Empty;
        public string PurposeOfBusiness { get; set; } = String.Empty;
    }
}
