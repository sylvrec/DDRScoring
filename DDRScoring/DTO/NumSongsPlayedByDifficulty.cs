using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "NumSongsPlayedByDifficulty")]
	public class NumSongsPlayedByDifficulty
	{
		[XmlElement(ElementName = "Beginner")]
		public string Beginner { get; set; }
		[XmlElement(ElementName = "Easy")]
		public string Easy { get; set; }
	}
}
