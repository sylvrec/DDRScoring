﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Entities
{
    public class Player
    {
        public StoreUser Account { get; set; }
        public IList<Song> Songs { get; set; }
        public IList<CaloriesBurned> CaloriesBurneds { get; set; }
    }
}
