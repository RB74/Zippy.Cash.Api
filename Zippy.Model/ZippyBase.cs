namespace Zippy.Model
{
    /// <summary>
    /// Zippy Base entity
    /// </summary>
    public class ZippyBase
    {
        public DateTime CreatedOnUTC { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUTC { set; get; } = DateTime.UtcNow;
    }
}