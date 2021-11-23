using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "CaloriesBurned")]
	public class CaloriesBurned
	{
		[XmlAttribute(AttributeName = "Date", DataType = "date")]
		public DateTime Date { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
