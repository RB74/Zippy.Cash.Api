using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Zippy.Model
{
    /// <summary>
    /// Adress entity, we keep all adresses belonged to the client ever
    /// </summary>
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public string? Zip { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; } 
    }
}
