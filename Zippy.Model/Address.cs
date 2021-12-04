using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Zippy.Model
{
    /// <summary>
    /// Address entity, we keep all adresses belonged to the client ever
    /// </summary>
    public class Address : ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public string Zip { get; set; } = string.Empty;
        [ForeignKey("Client")]
        public int ClientId { get; set; }
    }
}
