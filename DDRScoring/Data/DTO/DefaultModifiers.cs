using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDRScoring.Data.DTO
{
	[XmlRoot(ElementName = "DefaultModifiers")]
	public class DefaultModifiers
	{
		[XmlElement(ElementName = "dance")]
		public string Dance { get; set; }
	}
}
