using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Entities
{
    [Table("Song")]
    [DataContract]
    public class Song
    {
        [DataMember]
        [Key]
        public long Id { get; set; }
        
        [DataMember]
        [Required]
        public string Name { get; set; } // Dir (DTO)
        
        [DataMember]
        public List<Steps> Steps { get; set; }

        [ForeignKey(nameof(Player))]
        public long PlayerId { get; set; }

        public Player Player { get; set; }
    }
}
