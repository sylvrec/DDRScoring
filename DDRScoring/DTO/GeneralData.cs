using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "GeneralData")]
	public class GeneralData
	{
		[XmlElement(ElementName = "DisplayName")]
		public string DisplayName { get; set; }
		[XmlElement(ElementName = "CharacterID")]
		public string CharacterID { get; set; }
		[XmlElement(ElementName = "LastUsedHighScoreName")]
		public string LastUsedHighScoreName { get; set; }
		[XmlElement(ElementName = "WeightPounds")]
		public string WeightPounds { get; set; }
		[XmlElement(ElementName = "Voomax")]
		public string Voomax { get; set; }
		[XmlElement(ElementName = "BirthYear")]
		public string BirthYear { get; set; }
		[XmlElement(ElementName = "IgnoreStepCountCalories")]
		public string IgnoreStepCountCalories { get; set; }
		[XmlElement(ElementName = "IsMale")]
		public string IsMale { get; set; }
		[XmlElement(ElementName = "IsMachine")]
		public string IsMachine { get; set; }
		[XmlElement(ElementName = "Guid")]
		public string Guid { get; set; }
		[XmlElement(ElementName = "SortOrder")]
		public string SortOrder { get; set; }
		[XmlElement(ElementName = "LastDifficulty")]
		public string LastDifficulty { get; set; }
		[XmlElement(ElementName = "LastCourseDifficulty")]
		public string LastCourseDifficulty { get; set; }
		[XmlElement(ElementName = "LastStepsType")]
		public string LastStepsType { get; set; }
		[XmlElement(ElementName = "Song")]
		public Song Song { get; set; }
		[XmlElement(ElementName = "Course")]
		public string Course { get; set; }
		[XmlElement(ElementName = "CurrentCombo")]
		public string CurrentCombo { get; set; }
		[XmlElement(ElementName = "TotalSessions")]
		public string TotalSessions { get; set; }
		[XmlElement(ElementName = "TotalSessionSeconds")]
		public string TotalSessionSeconds { get; set; }
		[XmlElement(ElementName = "TotalGameplaySeconds")]
		public string TotalGameplaySeconds { get; set; }
		[XmlElement(ElementName = "TotalCaloriesBurned")]
		public string TotalCaloriesBurned { get; set; }
		[XmlElement(ElementName = "GoalType")]
		public string GoalType { get; set; }
		[XmlElement(ElementName = "GoalCalories")]
		public string GoalCalories { get; set; }
		[XmlElement(ElementName = "GoalSeconds")]
		public string GoalSeconds { get; set; }
		[XmlElement(ElementName = "LastPlayedMachineGuid")]
		public string LastPlayedMachineGuid { get; set; }
		[XmlElement(ElementName = "LastPlayedDate")]
		public string LastPlayedDate { get; set; }
		[XmlElement(ElementName = "TotalDancePoints")]
		public string TotalDancePoints { get; set; }
		[XmlElement(ElementName = "NumExtraStagesPassed")]
		public string NumExtraStagesPassed { get; set; }
		[XmlElement(ElementName = "NumExtraStagesFailed")]
		public string NumExtraStagesFailed { get; set; }
		[XmlElement(ElementName = "NumToasties")]
		public string NumToasties { get; set; }
		[XmlElement(ElementName = "TotalTapsAndHolds")]
		public string TotalTapsAndHolds { get; set; }
		[XmlElement(ElementName = "TotalJumps")]
		public string TotalJumps { get; set; }
		[XmlElement(ElementName = "TotalHolds")]
		public string TotalHolds { get; set; }
		[XmlElement(ElementName = "TotalRolls")]
		public string TotalRolls { get; set; }
		[XmlElement(ElementName = "TotalMines")]
		public string TotalMines { get; set; }
		[XmlElement(ElementName = "TotalHands")]
		public string TotalHands { get; set; }
		[XmlElement(ElementName = "TotalLifts")]
		public string TotalLifts { get; set; }
		[XmlElement(ElementName = "DefaultModifiers")]
		public DefaultModifiers DefaultModifiers { get; set; }
		[XmlElement(ElementName = "Unlocks")]
		public string Unlocks { get; set; }
		[XmlElement(ElementName = "NumSongsPlayedByPlayMode")]
		public NumSongsPlayedByPlayMode NumSongsPlayedByPlayMode { get; set; }
		[XmlElement(ElementName = "NumSongsPlayedByStyle")]
		public NumSongsPlayedByStyle NumSongsPlayedByStyle { get; set; }
		[XmlElement(ElementName = "NumSongsPlayedByDifficulty")]
		public NumSongsPlayedByDifficulty NumSongsPlayedByDifficulty { get; set; }
		[XmlElement(ElementName = "NumSongsPlayedByMeter")]
		public NumSongsPlayedByMeter NumSongsPlayedByMeter { get; set; }
		[XmlElement(ElementName = "NumTotalSongsPlayed")]
		public string NumTotalSongsPlayed { get; set; }
		[XmlElement(ElementName = "NumStagesPassedByPlayMode")]
		public NumStagesPassedByPlayMode NumStagesPassedByPlayMode { get; set; }
		[XmlElement(ElementName = "NumStagesPassedByGrade")]
		public NumStagesPassedByGrade NumStagesPassedByGrade { get; set; }
		[XmlElement(ElementName = "UserTable")]
		public string UserTable { get; set; }
	}
}
