using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zippy.Model
{
    /// <summary>
    /// Document Types are passport, license, id, other
    /// </summary>
    public class DocumentType : ZippyBase
    {
        public DocumentType()
        {
            Documents = new List<Document>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Document> Documents { get; set; }
    }
}
