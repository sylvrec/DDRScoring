using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Models
{
	[XmlRoot(ElementName = "RadarValues")]
	public class RadarValues
	{
		[XmlElement(ElementName = "Stream")]
		public string Stream { get; set; }
		[XmlElement(ElementName = "Voltage")]
		public string Voltage { get; set; }
		[XmlElement(ElementName = "Air")]
		public string Air { get; set; }
		[XmlElement(ElementName = "Freeze")]
		public string Freeze { get; set; }
		[XmlElement(ElementName = "Chaos")]
		public string Chaos { get; set; }
		[XmlElement(ElementName = "Notes")]
		public string Notes { get; set; }
		[XmlElement(ElementName = "TapsAndHolds")]
		public string TapsAndHolds { get; set; }
		[XmlElement(ElementName = "Jumps")]
		public string Jumps { get; set; }
		[XmlElement(ElementName = "Holds")]
		public string Holds { get; set; }
		[XmlElement(ElementName = "Mines")]
		public string Mines { get; set; }
		[XmlElement(ElementName = "Hands")]
		public string Hands { get; set; }
		[XmlElement(ElementName = "Rolls")]
		public string Rolls { get; set; }
		[XmlElement(ElementName = "Lifts")]
		public string Lifts { get; set; }
		[XmlElement(ElementName = "Fakes")]
		public string Fakes { get; set; }
	}
}
