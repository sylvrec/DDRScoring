using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "SongScores")]
	public class SongScores
	{
		[XmlElement(ElementName = "Song")]
		public List<Song> Song { get; set; }
	}
}
