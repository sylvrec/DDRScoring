using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "NumSongsPlayedByStyle")]
	public class NumSongsPlayedByStyle
	{
		[XmlElement(ElementName = "Style")]
		public Style Style { get; set; }
	}
}
