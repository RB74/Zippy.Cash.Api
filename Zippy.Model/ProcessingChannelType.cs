using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zippy.Model
{
    /// <summary>
    /// ProcessingChannelType Entity, Values are ach, interac, real-time (upcoming fed service).
    /// </summary>
    public class ProcessingChannelType : ZippyBase
    {
        public ProcessingChannelType()
        {
            ProcessingChannels = new List<ProcessingChannel>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } =  string.Empty;
        public ICollection<ProcessingChannel> ProcessingChannels { get; set; }
    }
}
