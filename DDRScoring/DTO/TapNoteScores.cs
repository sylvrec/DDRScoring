using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "TapNoteScores")]
	public class TapNoteScores
	{
		[XmlElement(ElementName = "HitMine")]
		public string HitMine { get; set; }
		[XmlElement(ElementName = "AvoidMine")]
		public string AvoidMine { get; set; }
		[XmlElement(ElementName = "CheckpointMiss")]
		public string CheckpointMiss { get; set; }
		[XmlElement(ElementName = "Miss")]
		public string Miss { get; set; }
		[XmlElement(ElementName = "W5")]
		public string W5 { get; set; }
		[XmlElement(ElementName = "W4")]
		public string W4 { get; set; }
		[XmlElement(ElementName = "W3")]
		public string W3 { get; set; }
		[XmlElement(ElementName = "W2")]
		public string W2 { get; set; }
		[XmlElement(ElementName = "W1")]
		public string W1 { get; set; }
		[XmlElement(ElementName = "CheckpointHit")]
		public string CheckpointHit { get; set; }
	}
}
