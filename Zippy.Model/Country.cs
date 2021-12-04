using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Entity represents Country
    /// </summary>
    public class Country : ZippyBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = "United States";
        //Navigation property
        public ICollection<Region> Regions { get; set; } = new HashSet<Region>();
    }
}
