using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "RadarValues")]
	public class RadarValues
	{
		[XmlElement(ElementName = "Stream")]
		public decimal Stream { get; set; }
		[XmlElement(ElementName = "Voltage")]
		public decimal Voltage { get; set; }
		[XmlElement(ElementName = "Air")]
		public decimal Air { get; set; }
		[XmlElement(ElementName = "Freeze")]
		public decimal Freeze { get; set; }
		[XmlElement(ElementName = "Chaos")]
		public decimal Chaos { get; set; }
		[XmlElement(ElementName = "Notes")]
		public decimal Notes { get; set; }
		[XmlElement(ElementName = "TapsAndHolds")]
		public long TapsAndHolds { get; set; }
		[XmlElement(ElementName = "Jumps")]
		public long Jumps { get; set; }
		[XmlElement(ElementName = "Holds")]
		public long Holds { get; set; }
		[XmlElement(ElementName = "Mines")]
		public long Mines { get; set; }
		[XmlElement(ElementName = "Hands")]
		public long Hands { get; set; }
		[XmlElement(ElementName = "Rolls")]
		public long Rolls { get; set; }
		[XmlElement(ElementName = "Lifts")]
		public long Lifts { get; set; }
		[XmlElement(ElementName = "Fakes")]
		public long Fakes { get; set; }
	}
}
