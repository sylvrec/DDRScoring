using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "Screenshot")]
	public class Screenshot
	{
		[XmlElement(ElementName = "FileName")]
		public string FileName { get; set; }
		[XmlElement(ElementName = "MD5")]
		public string MD5 { get; set; }
		[XmlElement(ElementName = "HighScore")]
		public HighScore HighScore { get; set; }
	}
}
