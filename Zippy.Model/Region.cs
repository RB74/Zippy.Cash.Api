using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Region entity, represents region structure in different countries 
    /// </summary>
    public class Region:ZippyBase
    {
        public int Id { get; set; }
        public string RegionCode { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        [ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}