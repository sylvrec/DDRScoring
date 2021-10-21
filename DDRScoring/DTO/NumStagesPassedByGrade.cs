using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "NumStagesPassedByGrade")]
	public class NumStagesPassedByGrade
	{
		[XmlElement(ElementName = "Tier04")]
		public string Tier04 { get; set; }
		[XmlElement(ElementName = "Tier05")]
		public string Tier05 { get; set; }
		[XmlElement(ElementName = "Tier06")]
		public string Tier06 { get; set; }
		[XmlElement(ElementName = "Tier07")]
		public string Tier07 { get; set; }
	}
}
