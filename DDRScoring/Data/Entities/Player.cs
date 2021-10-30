using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Entities
{
    public class Player
    {
        public long Id { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public IList<Song> Songs { get; set; }
        public IList<CaloriesBurned> CaloriesBurneds { get; set; }
    }
}
