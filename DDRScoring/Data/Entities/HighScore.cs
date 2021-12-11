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
	[Table("HighScore")]
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
		[Column(TypeName = "decimal(18,10)")]
		public decimal PercentDP { get; set; }

		[DataMember]
		[Column(TypeName = "decimal(18,10)")]
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
		public DateTime DateTime { get; set; }

		[DataMember]
        public string PlayerGuid { get; set; }

        [DataMember]
		public string MachineGuid { get; set; }
        
		[DataMember]
		public int ProductId { get; set; }

        [DataMember]
		public TapNoteScores TapNoteScores { get; set; }

		[DataMember]
		public HoldNoteScores HoldNoteScores { get; set; }

		[DataMember]
		public RadarValues RadarValues { get; set; }

		[DataMember]
		[Column(TypeName="decimal(18,10)")]
		public decimal LifeRemainingSeconds { get; set; }

		[DataMember]
		public int Disqualified { get; set; }

        public HighScoreList HighScoreList { get; set; }

        [ForeignKey(nameof(HighScoreList))]
        public long HighScoreListId { get; set; }

		[ForeignKey(nameof(TapNoteScores))]
        public long TapNoteScoresId { get; set; }

		[ForeignKey(nameof(RadarValues))]
        public long RadarValuesId { get; set; }

		[ForeignKey(nameof(HoldNoteScores))]
        public long HoldNoteScoreId { get; set; }
    }
}
