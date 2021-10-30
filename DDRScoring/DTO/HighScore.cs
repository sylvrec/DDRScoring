using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "HighScore")]
	public class HighScore
	{
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Grade")]
		public string Grade { get; set; }
		[XmlElement(ElementName = "Score")]
		public int Score { get; set; }
		[XmlElement(ElementName = "PercentDP")]
		public decimal PercentDP { get; set; }
		[XmlElement(ElementName = "SurviveSeconds")]
		public decimal SurviveSeconds { get; set; }
		[XmlElement(ElementName = "MaxCombo")]
		public int MaxCombo { get; set; }
		[XmlElement(ElementName = "StageAward")]
		public string StageAward { get; set; }
		[XmlElement(ElementName = "PeakComboAward")]
		public string PeakComboAward { get; set; }
		[XmlElement(ElementName = "Modifiers")]
		public string Modifiers { get; set; }
		[XmlElement(ElementName = "DateTime")]
		public string DateTime { get; set; }
		[XmlElement(ElementName = "PlayerGuid")]
		public string PlayerGuid { get; set; }
		[XmlElement(ElementName = "MachineGuid")]
		public string MachineGuid { get; set; }
		[XmlElement(ElementName = "ProductID")]
		public int ProductID { get; set; }
		[XmlElement(ElementName = "TapNoteScores")]
		public TapNoteScores TapNoteScores { get; set; }
		[XmlElement(ElementName = "HoldNoteScores")]
		public HoldNoteScores HoldNoteScores { get; set; }
		[XmlElement(ElementName = "RadarValues")]
		public RadarValues RadarValues { get; set; }
		[XmlElement(ElementName = "LifeRemainingSeconds")]
		public decimal LifeRemainingSeconds { get; set; }
		[XmlElement(ElementName = "Disqualified")]
		public int Disqualified { get; set; }
	}
}
