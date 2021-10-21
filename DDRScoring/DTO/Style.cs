using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "Style")]
	public class Style
	{
		[XmlAttribute(AttributeName = "Game")]
		public string Game { get; set; }
		[XmlAttribute(AttributeName = "Style")]
		public string _Style { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
