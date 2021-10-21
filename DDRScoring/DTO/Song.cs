using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "Song")]
	public class Song
	{
		[XmlAttribute(AttributeName = "Dir")]
		public string Dir { get; set; }
		[XmlElement(ElementName = "Steps")]
		public List<Steps> Steps { get; set; }
	}
}
