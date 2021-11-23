using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "Stats")]
	public class Stats
	{
		[XmlElement(ElementName = "GeneralData")]
		public GeneralData GeneralData { get; set; }
		[XmlElement(ElementName = "SongScores")]
		public SongScores SongScores { get; set; }
		[XmlElement(ElementName = "CourseScores")]
		public string CourseScores { get; set; }
		[XmlElement(ElementName = "CategoryScores")]
		public string CategoryScores { get; set; }
		[XmlElement(ElementName = "ScreenshotData")]
		public ScreenshotData ScreenshotData { get; set; }
		[XmlElement(ElementName = "CalorieData")]
		public CalorieData CalorieData { get; set; }
	}
}
