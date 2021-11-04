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
	[Table("RadarValues")]
	[DataContract]
    public class RadarValues
    {
		[DataMember]
		[Key]
        public long Id { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(3,6)")]
		public decimal Stream { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(3,6)")]
		public decimal Voltage { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(3,6)")]
		public decimal Air { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(3,6)")]
		public decimal Freeze { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(3,6)")]
		public decimal Chaos { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(12,6)")]
		public decimal Notes { get; set; }

		[DataMember]
		public long TapsAndHolds { get; set; }

		[DataMember]
		public long Jumps { get; set; }

		[DataMember]
		public long Holds { get; set; }

		[DataMember]
		public long Mines { get; set; }

		[DataMember]
		public long Hands { get; set; }

		[DataMember]
		public long Rolls { get; set; }

		[DataMember]
		public long Lifts { get; set; }

		[DataMember]
		public long Fakes { get; set; }
	}
}
