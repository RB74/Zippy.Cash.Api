using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Zippy.Model
{
    /// <summary>
    /// Address entity, we keep all adresses belonged to the client ever
    /// </summary>
    public class Address:ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Address1 { get; set; } = String.Empty;
        public string Address2 { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public string Zip { get; set; } = String.Empty;
        [ForeignKey("Client")]
        public int ClientId { get; set; } 
    }
}
