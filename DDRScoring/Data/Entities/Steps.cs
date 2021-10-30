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

        [DataMember]
        public HighScoreList HigScoreList { get; set; }
        
        [DataMember]
        public string Difficulty { get; set; }

        [DataMember]
        public string StepsType { get; set; }
    }
}
