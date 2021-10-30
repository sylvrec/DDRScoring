using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "HoldNoteScores")]
	public class HoldNoteScores
	{
		[XmlElement(ElementName = "LetGo")]
		public int LetGo { get; set; }
		[XmlElement(ElementName = "Held")]
		public int Held { get; set; }
		[XmlElement(ElementName = "MissedHold")]
		public int MissedHold { get; set; }
	}
}
