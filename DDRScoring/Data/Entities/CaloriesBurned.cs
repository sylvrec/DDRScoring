using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Entities
{
    [Table("CaloriesBurned")]
    [DataContract]
    public class CaloriesBurned
    {
        [DataMember]
        [Key]
        public long Id { get; set; }
        
        [DataMember]
        [Required]
        public string Date { get; set; }
        
        [DataMember]
        [Required]
        public string Text { get; set; }
    }
}
