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
    [Table("Steps")]
    [DataContract]
    public class Steps
    {
        [DataMember]
        [Key]
        public long Id { get; set; }

        public HighScoreList HighScoreList { get; set; }
        
        [DataMember]
        public string Difficulty { get; set; }

        [DataMember]
        public string StepsType { get; set; }

        public Song Song { get; set; }

        [ForeignKey(nameof(Song))]
        public long SongId { get; set; }

        [ForeignKey(nameof(HighScoreList))]
        public long HighScoreListId { get; set; }

    }
}
