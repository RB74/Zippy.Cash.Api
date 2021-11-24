using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        [ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}