using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "HighScoreList")]
	public class HighScoreList
	{
		[XmlElement(ElementName = "NumTimesPlayed")]
		public long NumTimesPlayed { get; set; }
		[XmlElement(ElementName = "LastPlayed", DataType = "date")]
		public DateTime LastPlayed { get; set; }
		[XmlElement(ElementName = "HighGrade")]
		public string HighGrade { get; set; }
		[XmlElement(ElementName = "HighScore")]
		public List<HighScore> HighScore { get; set; }
	}
}
