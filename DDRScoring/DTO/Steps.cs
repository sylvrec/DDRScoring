using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "Steps")]
	public class Steps
	{
		[XmlElement(ElementName = "HighScoreList")]
		public HighScoreList HighScoreList { get; set; }
		[XmlAttribute(AttributeName = "Difficulty")]
		public string Difficulty { get; set; }
		[XmlAttribute(AttributeName = "StepsType")]
		public string StepsType { get; set; }
	}
}
