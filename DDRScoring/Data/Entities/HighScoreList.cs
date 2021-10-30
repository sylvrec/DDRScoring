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
    [Table("HighScoreList")]
    [DataContract]
    public class HighScoreList
    {
        [DataMember]
        [Key]
        public long Id { get; set; }

        [DataMember]
        public long NumTimesPlayed { get; set; }

        [DataMember]
        public string LastPlayed { get; set; }

        [DataMember]
        public string HighGrade { get; set; }

        [DataMember]
        public List<HighScore> HighScore { get; set; }

    }
}
