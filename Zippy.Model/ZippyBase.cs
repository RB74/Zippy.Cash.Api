namespace Zippy.Model
{
    public class ZippyBase
    {
        public DateTime CreatedOnUTC { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUTC { set; get; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? Zip { get; set; }
    }
}