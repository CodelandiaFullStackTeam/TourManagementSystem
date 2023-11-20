﻿using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class CityDAL: BaseRepository<City, TourDbEntities>,ICityDAL { }
}