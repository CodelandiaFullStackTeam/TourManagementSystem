using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourManagementSystem.DataAccess.Abstract;
using TourManagementSystem.Repository;

namespace TourManagementSystem.DataAccess.Concrete
{
    public class CountryDAL:BaseRepository<Country,TourDbEntities>,ICountryDAL
    {
    }
}