using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "NumSongsPlayedByPlayMode")]
	public class NumSongsPlayedByPlayMode
	{
		[XmlElement(ElementName = "Regular")]
		public string Regular { get; set; }
	}

}
