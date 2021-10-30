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
    [Table("HoldNoteScores")]
    [DataContract]
    public class HoldNoteScores
    {
        [DataMember]
        [Key]
        public long Id { get; set; }

        [DataMember]
        public int LetGo { get; set; }

        [DataMember]
        public int Held { get; set; }

        [DataMember]
        public int MissedHold { get; set; }
	}
}
