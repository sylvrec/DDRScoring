using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "HighScoreList")]
	public class HighScoreList
	{
		[XmlElement(ElementName = "NumTimesPlayed")]
		public long NumTimesPlayed { get; set; }
		[XmlElement(ElementName = "LastPlayed")]
		public string LastPlayed { get; set; }
		[XmlElement(ElementName = "HighGrade")]
		public string HighGrade { get; set; }
		[XmlElement(ElementName = "HighScore")]
		public List<HighScore> HighScore { get; set; }
	}
}
