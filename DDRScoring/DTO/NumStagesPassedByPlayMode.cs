using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "NumStagesPassedByPlayMode")]
	public class NumStagesPassedByPlayMode
	{
		[XmlElement(ElementName = "Regular")]
		public string Regular { get; set; }
	}
}
