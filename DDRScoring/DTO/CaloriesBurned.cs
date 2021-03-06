using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "CaloriesBurned")]
	public class CaloriesBurned
	{
		[XmlAttribute(AttributeName = "Date")]
		public string Date { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
