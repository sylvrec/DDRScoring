using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "CalorieData")]
	public class CalorieData
	{
		[XmlElement(ElementName = "CaloriesBurned")]
		public List<CaloriesBurned> CaloriesBurned { get; set; }
	}
}
