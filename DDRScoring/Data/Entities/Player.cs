using Microsoft.AspNetCore.Identity;
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
    [Table("Player")]
    [DataContract]
    public class Player
    {
        [Key]
        public long Id { get; set; }

        [DataMember]
        public StoreUser Account { get; set; }

        [DataMember]
        public IList<Song> Songs { get; set; }

        [DataMember]
        public IList<CaloriesBurned> CaloriesBurneds { get; set; }
    }
}
