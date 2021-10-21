using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "NumSongsPlayedByMeter")]
	public class NumSongsPlayedByMeter
	{
		[XmlElement(ElementName = "Meter1")]
		public string Meter1 { get; set; }
		[XmlElement(ElementName = "Meter2")]
		public string Meter2 { get; set; }
		[XmlElement(ElementName = "Meter3")]
		public string Meter3 { get; set; }
	}
}
