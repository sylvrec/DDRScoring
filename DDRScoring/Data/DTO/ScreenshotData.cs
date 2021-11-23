using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "ScreenshotData")]
	public class ScreenshotData
	{
		[XmlElement(ElementName = "Screenshot")]
		public Screenshot Screenshot { get; set; }
	}
}
