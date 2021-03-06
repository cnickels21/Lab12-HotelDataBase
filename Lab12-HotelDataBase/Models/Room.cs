﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab12_HotelDataBase.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Layout Layout { get; set; }

        public ICollection<RoomAmenities> Amenities { get; set; }


    }

    public enum Layout
    {
        QuickNEasy,
        OneQueen,
        SevenQueens,
        TheWorks,
        ExoticRetreat,
        YouNeedMoreMoney,
    }
}
