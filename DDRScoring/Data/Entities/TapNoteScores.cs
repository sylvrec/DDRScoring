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
	[Table("TapNoteScores")]
	[DataContract]
	public class TapNoteScores
    {
		[DataMember]
		[Key]
        public long Id { get; set; }

		[DataMember]
		public long HitMine { get; set; }

		[DataMember]
		public long AvoidMine { get; set; }

		[DataMember]
		public long CheckpointMiss { get; set; }

		[DataMember]
		public long Miss { get; set; }

		[DataMember]
		public long W5 { get; set; }

		[DataMember]
		public long W4 { get; set; }

		[DataMember]
		public long W3 { get; set; }

		[DataMember]
		public long W2 { get; set; }

		[DataMember]
		public long W1 { get; set; }

		[DataMember]
		public long CheckpointHit { get; set; }
	}
}
