﻿using Lab12_HotelDataBase.Models;
using Lab12_HotelDataBase.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data.Repositories
{
    public interface IAmenitiesRepository
    {
        Task<IEnumerable<AmenitiesDTO>> GetAllAmenities();

        Task<AmenitiesDTO> GetOneAmenity(int id);

        Task<bool> UpdateAmenity(int id, Amenities amenities);

        Task<AmenitiesDTO> SaveNewAmenity(Amenities amenities);

        Task<Amenities> DeleteAmenity(int id);

        bool AmenityExists(int id);
    }
}
