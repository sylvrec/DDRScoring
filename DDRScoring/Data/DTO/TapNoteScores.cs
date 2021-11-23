using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "TapNoteScores")]
	public class TapNoteScores
	{
		[XmlElement(ElementName = "HitMine")]
		public long HitMine { get; set; }
		[XmlElement(ElementName = "AvoidMine")]
		public long AvoidMine { get; set; }
		[XmlElement(ElementName = "CheckpointMiss")]
		public long CheckpointMiss { get; set; }
		[XmlElement(ElementName = "Miss")]
		public long Miss { get; set; }
		[XmlElement(ElementName = "W5")]
		public long W5 { get; set; }
		[XmlElement(ElementName = "W4")]
		public long W4 { get; set; }
		[XmlElement(ElementName = "W3")]
		public long W3 { get; set; }
		[XmlElement(ElementName = "W2")]
		public long W2 { get; set; }
		[XmlElement(ElementName = "W1")]
		public long W1 { get; set; }
		[XmlElement(ElementName = "CheckpointHit")]
		public long CheckpointHit { get; set; }
	}
}
