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
	[Table("HighScores")]
	[DataContract]
    public class HighScore
    {
		[DataMember]
		[Key]
        public long Id { get; set; }

		[DataMember]
		[Required]
		[StringLength(250)]
        public string Name { get; set; }

		[DataMember]
		public string Grade { get; set; }

		[DataMember]
		public int Score { get; set; }

		[DataMember]
		public decimal PercentDP { get; set; }

		[DataMember]
		public decimal SurviveSeconds { get; set; }

		[DataMember]
		public int MaxCombo { get; set; }

		[DataMember]
		public string StageAward { get; set; }

		[DataMember]
		public string PeakComboAward { get; set; }

		[DataMember]
		public string Modifiers { get; set; }

		[DataMember]
		public string DateTime { get; set; }

		[DataMember]
		public string Machine { get; set; }

		[DataMember]
		public TapNoteScores TapNoteScores { get; set; }

		[DataMember]
		public HoldNoteScores HoldNoteScores { get; set; }

		[DataMember]
		public RadarValues RadarValues { get; set; }

		[DataMember]
		public decimal LifeRemainingSeconds { get; set; }

		[DataMember]
		public int Disqualified { get; set; }
	}
}
